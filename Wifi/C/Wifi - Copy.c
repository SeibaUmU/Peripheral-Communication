#include <stdbool.h>
#include <stdint.h>
#include <stdio.h>
#include <string.h>
#include <stddef.h>
/** Some constants for ESP8266 **/
#define ESP8266_STATION 0x01
#define ESP8266_SOFTAP 0x02
#define ESP8266_BOTH 0x03
#define ESP8266_TCP 1
#define ESP8266_UDP 0
#define ESP8266_TRANS_PASS 1
#define ESP8266_TRANS_NOR 0
#define ESP8266_OK 1
#define ESP8266_READY 2
#define ESP8266_FAIL 3
#define ESP8266_NOCHANGE 4
#define ESP8266_LINKED 5
#define ESP8266_UNLINK 6
#define ESP8266_CONNECT 7

// Các biến phục vụ việc nhận chuỗi dữ liệu
char ReceiveData;
char rx_buffer[30];
unsigned char rx_index = 0;
bit packet_ready_flag;

// Biến đếm cho 3 nút nhấn
unsigned int sw0_count = 0;
unsigned int sw1_count = 0;
unsigned int sw2_count = 0;
char tx_buffer[20];

//=======================
void interrupt(void)
{
    if((RCIE_bit == 1) && (RCIF_bit == 1))
    {
        RCIF_bit = 0; // Clear interrupt bit
        ReceiveData = UART1_Read(); // Doc du lieu tu UART
        
        // Bắt gói tin cho đến khi gặp ký tự '&' theo chuẩn của C#
        if (ReceiveData == '&') 
        {
            rx_buffer[rx_index] = '\0'; // Chốt chuỗi
            packet_ready_flag = 1;      // Bật cờ báo có gói tin hoàn chỉnh
            rx_index = 0;               // Reset index cho gói tin tiếp theo
        }
        else if (rx_index < 29) 
        {
            rx_buffer[rx_index++] = ReceiveData; // Lưu vào buffer
        }
    }
}
//=======================

//**Function to send one byte of data to UART**//
void _esp8266_putch(char bt)
{
    while(!TXIF_bit); // hold the program till TX buffer is free
    TXREG = bt; //Load the transmitter buffer with the received value
}
//=======================

//**Function to get one byte of data from UART**//
char _esp8266_getch()
{
    if(OERR_bit) // check for Error
    {
        CREN_bit = 0; // If error -> Reset
        CREN_bit = 1; // If error -> Reset
    }
    while(!RCIF_bit); // hold the program till RX buffer is free
    return RCREG; //receive the value and send it to main function
}
//=======================

//**Function to convert string to byte**//
void ESP8266_send_string(char* st_pt)
{
    while(*st_pt) //if there is a char
    {
        _esp8266_putch(*st_pt++); //process it as a byte data
    }
}
//=======================

void _esp8266_print(unsigned char *ptr) {
    while (*ptr != 0)
    {
        _esp8266_putch(*ptr++);
    }
}
//=======================

inline uint16_t _esp8266_waitFor(unsigned char *string)
{
    unsigned char so_far = 0;
    unsigned char received;
    uint16_t counter = 0;
    do
    {
        received = _esp8266_getch();
        counter++;
        if (received == string[so_far])
        {
            so_far++;
        }
        else
        {
            so_far = 0;
        }
    }
    while (string[so_far] != 0);
    return counter;
}
//=======================

void esp8266_restart(void)
{
    _esp8266_print("AT+RST\r\n");
    _esp8266_waitFor("OK");
    _esp8266_waitFor("ready");
}
//=======================

void esp8266_isStarted (void)
{
    _esp8266_print("AT\r\n"); 
    _esp8266_waitFor("OK");   
}
//=======================

void esp8266_echoCmds (bool echo)
{
    _esp8266_print("ATE"); 
    if (echo)
    {
        _esp8266_putch('1');
    }
    else
    {
        _esp8266_putch('0');
    }
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK"); 
}
//=======================

void esp8266_mode (unsigned char mode)
{
    _esp8266_print("AT+CWMODE="); 
    _esp8266_putch (mode + '0');
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK"); 
}
//=======================

void esp8266_trans_mode(unsigned char mode)
{
    _esp8266_print("AT+CIPMODE="); 
    _esp8266_putch (mode + '0');
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK"); 
}
//=======================

void esp8266_connect(unsigned char* ssid, unsigned char* pass)
{
    _esp8266_print("AT+CWJAP=\""); 
    _esp8266_print(ssid);
    _esp8266_print("\",\"");
    _esp8266_print (pass);
    _esp8266_print("\"\r\n");
    _esp8266_waitFor("OK"); 
}
//=======================
unsigned char esp8266_start(unsigned char protocol, unsigned char* ip, unsigned int port)
{
    unsigned char port_str[5] = "\0\0\0\0";
    _esp8266_print("AT+CIPSTART=\"");

    if (protocol == ESP8266_TCP)
    {
        _esp8266_print("TCP");
    }
    else
    {
        _esp8266_print("UDP");
    }

    _esp8266_print("\",\"");
    _esp8266_print(ip);
    _esp8266_print("\",");

    sprintf(port_str, "%u", port);
    _esp8266_print (port_str);
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK");
}
//=======================

void esp8266_send(void) 
{
    _esp8266_print("AT+CIPSEND");
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK");
    while (_esp8266_getch() != '>');
}
//=======================

void esp8266_receive (unsigned char* store_in)
{
    unsigned char length = 0;
    unsigned char i;
    unsigned char received;

    _esp8266_waitFor("+IPD, "); 
    do
    {
        received = _esp8266_getch();
        if(received == ':') break; 
        length = length * 10 + (received - '0'); 
    }
    while (received >= '0' && received <= '9');

    for (i=0; i < length; i++) 
    {
        store_in[i] = _esp8266_getch();
    }
}
//=======================

void esp8266_disconnect(void)
{
    _esp8266_print("AT+CWQAP\r\n");
    _esp8266_waitFor("OK");
}
//=======================

void esp8266_stop_send(void)
{
    _esp8266_print("+++");
    delay_ms(2000);
}
//=======================

void esp8266_del_TCP(void)
{
    _esp8266_print("AT+CIPCLOSE\r\n");
    _esp8266_waitFor("OK");
}
//=======================

void main(void)
{
    // Khai bao & Chuong trinh
    ADCON1 = 0x0F;
    CMCON |= 7;

    // Cau hinh Port B (3 Button)
    PORTB = 0x00; LATB = 0x00;
    TRISB0_bit = 1; // Button 0
    TRISB1_bit = 1; // Button 1
    TRISB2_bit = 1; // Button 2

    // Cau hinh Port E (3 LED)
    PORTE = 0x00; LATE = 0x00;
    TRISE0_bit = 0; // LED 0
    TRISE1_bit = 0; // LED 1
    TRISE2_bit = 0; // LED 2

    // Cấu hình Port D (LED báo kết nối: RD0)
    TRISD0_bit = 0; 
    RD0_bit = 0; // Mặc định tắt LED kết nối

    // Cau hinh Port C
    PORTC = 0x00; LATC = 0x00;
    TRISC0_bit = 0; // Reset pin of ESP8266
    
    //LATE0_bit=1;    LATE1_bit=1; LATE2_bit=1; RD0_bit=1;
    

    UART1_Init(9600);
    delay_ms(100);
    
    // Reset for ESP8266 module
    RC0_bit = 0; delay_ms(100); RC0_bit = 1;
    delay_ms(1000); // For ESP8266 stable
    //LATE0_bit=1;
    //================================
    // Configure: Station, TCP Client Single connection UART-Wifi Passthrough
    esp8266_restart();
    esp8266_echoCmds(0);  
    esp8266_isStarted();  
    //LATE0_bit=1;
    esp8266_mode(ESP8266_STATION); 
    //LATE1_bit=1;
    esp8266_connect("ESP32 cua Khang", "12345678");
    //LATE2_bit=1;
    esp8266_start(ESP8266_TCP, "192.168.0.123", 8080);


    // Bật LED báo kết nối thành công
    RD0_bit = 1;

    esp8266_trans_mode(ESP8266_TRANS_PASS); 
    esp8266_send(); 

    //==============
    RCIF_bit = 0;   // Clear interrupt bit
    PIE1.RCIE = 1;  // Enable the EUSART receive interrupt
    GIE_bit = 1;    // Enable global interrupt
    PEIE_bit = 1;   // Enable peripheral interrupts
    packet_ready_flag = 0;

    while(1)
    {
        /******* Xử lý gửi trạng thái 3 Button ******/
        // Button 0 -> RB0
        if (Button(&PORTB, 0, 10, 0))
        {
            while(Button(&PORTB, 0, 10, 0));
            sw0_count++;
            sprintf(tx_buffer, "@S0_%u&", sw0_count);
            ESP8266_send_string(tx_buffer);
        }

        // Button 1 -> RB1
        if (Button(&PORTB, 1, 10, 0))
        {
            while(Button(&PORTB, 1, 10, 0));
            sw1_count++;
            sprintf(tx_buffer, "@S1_%u&", sw1_count);
            ESP8266_send_string(tx_buffer);
        }

        // Button 2 -> RB2
        if (Button(&PORTB, 2, 10, 0))
        {
            while(Button(&PORTB, 2, 10, 0));
            sw2_count++;
            sprintf(tx_buffer, "@S2_%u&", sw2_count);
            ESP8266_send_string(tx_buffer);
        }

        /******* Xử lý nhận lệnh từ C# Server điều khiển 3 LED ******/
        if(packet_ready_flag == 1)
        {
            packet_ready_flag = 0; // Xóa cờ để nhận gói tin mới

            // --- LED 0 (RE0) ---
            if (strstr(rx_buffer, "@le0_on") != NULL)
            {
                LATE0_bit = 1;
                ESP8266_send_string("@Lle0_on&");
            }
            else if (strstr(rx_buffer, "@le0_of") != NULL)
            {
                LATE0_bit = 0;
                ESP8266_send_string("@Lle0_off&");
            }

            // --- LED 1 (RE1) ---
            else if (strstr(rx_buffer, "@le1_on") != NULL)
            {
                LATE1_bit = 1;
                ESP8266_send_string("@Lle1_on&");
            }
            else if (strstr(rx_buffer, "@le1_of") != NULL)
            {
                LATE1_bit = 0;
                ESP8266_send_string("@Lle1_off&");
            }

            // --- LED 2 (RE2) ---
            else if (strstr(rx_buffer, "@le2_on") != NULL)
            {
                LATE2_bit = 1;
                ESP8266_send_string("@Lle2_on&");
            }
            else if (strstr(rx_buffer, "@le2_of") != NULL)
            {
                LATE2_bit = 0;
                ESP8266_send_string("@Lle2_off&");
            }

            // Lệnh ngắt kết nối thủ công từ Terminal (nếu cần dùng)
            else if (strstr(rx_buffer, "Z") != NULL)
            {
                GIE_bit = 0; 
                RD0_bit = 0; // Tắt LED kết nối
                esp8266_stop_send(); 
                esp8266_trans_mode(ESP8266_TRANS_NOR); 
                esp8266_del_TCP(); 
            }
            
            // Xóa rác mảng đệm sau khi xử lý xong
            memset(rx_buffer, 0, sizeof(rx_buffer));
        }
    }
}