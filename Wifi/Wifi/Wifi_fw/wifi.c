#include <stdbool.h>
#include <stdint.h>
#include <stdio.h>
#include <string.h>

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

char TransmitData, ReceiveData;
bit transmit_flag, receive_flag;

//============================================================================
void interrupt(void)
{
    if((RCIE_bit == 1) && (RCIF_bit == 1))
    {
        RCIF_bit = 0;
        ReceiveData = UART1_Read();
        receive_flag = 1;
    }
}
//============================================================================

void _esp8266_putch(char bt)
{
    while(!TXIF_bit);
    TXREG = bt;
}
//============================================================================

char _esp8266_getch()
{
    if(OERR_bit)
    {
        CREN_bit = 0;
        CREN_bit = 1;
    }

    while(!RCIF_bit);
    return RCREG;
}
//============================================================================

void ESP8266_send_string(char* st_pt)
{
    while(*st_pt)
    {
        _esp8266_putch(*st_pt++);
    }
}
//============================================================================

void _esp8266_print(unsigned char *ptr)
{
    while (*ptr != 0)
    {
        _esp8266_putch(*ptr++);
    }
}
//============================================================================

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
//============================================================================

void esp8266_restart(void)
{
    _esp8266_print("AT+RST\r\n");
    _esp8266_waitFor("OK");
    _esp8266_waitFor("ready");
}
//============================================================================

void esp8266_isStarted(void)
{
    _esp8266_print("AT\r\n");
    _esp8266_waitFor("OK");
}
//============================================================================

void esp8266_echoCmds(bool echo)
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
//============================================================================

void esp8266_mode(unsigned char mode)
{
    _esp8266_print("AT+CWMODE=");
    _esp8266_putch(mode + '0');
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK");
}
//============================================================================

void esp8266_trans_mode(unsigned char mode)
{
    _esp8266_print("AT+CIPMODE=");
    _esp8266_putch(mode + '0');
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK");
}
//============================================================================

void esp8266_connect(unsigned char* ssid, unsigned char* pass)
{
    _esp8266_print("AT+CWJAP=\"");
    _esp8266_print(ssid);
    _esp8266_print("\",\"");
    _esp8266_print(pass);
    _esp8266_print("\"\r\n");
    _esp8266_waitFor("OK");
}
//============================================================================

unsigned char esp8266_start(unsigned char protocol, unsigned char* ip, unsigned int port)
{
    unsigned char port_str[5] = "\0\0\0\0";

    _esp8266_print("AT+CIPSTART=\"");

    if (protocol == ESP8266_TCP)
        _esp8266_print("TCP");
    else
        _esp8266_print("UDP");

    _esp8266_print("\",\"");
    _esp8266_print(ip);
    _esp8266_print("\",");

    sprintf(port_str, "%u", port);
    _esp8266_print(port_str);
    _esp8266_print("\r\n");

    _esp8266_waitFor("OK");
}
//============================================================================

void esp8266_send(void)
{
    _esp8266_print("AT+CIPSEND");
    _esp8266_print("\r\n");
    _esp8266_waitFor("OK");

    while (_esp8266_getch() != '>');
}
//============================================================================

void esp8266_receive(unsigned char* store_in)
{
    unsigned char length = 0;
    unsigned char i;
    unsigned char received;

    _esp8266_waitFor("+IPD,");

    do
    {
        received = _esp8266_getch();

        if(received == ':') break;

        length = length * 10 + (received - '0');

    } while (received >= '0' && received <= '9');

    for (i = 0; i < length; i++)
    {
        store_in[i] = _esp8266_getch();
    }
}
//============================================================================

void esp8266_disconnect(void)
{
    _esp8266_print("AT+CWQAP\r\n");
    _esp8266_waitFor("OK");
}
//============================================================================

void esp8266_stop_send(void)
{
    _esp8266_print("+++");
    delay_ms(2000);
}
//============================================================================

void esp8266_del_TCP(void)
{
    _esp8266_print("AT+CIPCLOSE\r\n");
    _esp8266_waitFor("OK");
}
//============================================================================

void main(void)
{
    ADCON1 |= 0x0F;
    CMCON |= 7;

    PORTB = 0x00;
    LATB = 0x00;
    TRISB0_bit = 1;

    PORTE = 0x00;
    LATE = 0x00;
    TRISE0_bit = 0;
    TRISE1_bit = 0;

    PORTC = 0x00;
    LATC = 0x00;
    TRISC0_bit = 0;

    UART1_Init(115200);
    delay_ms(100);

    RC0_bit = 0;
    delay_ms(100);
    RC0_bit = 1;

    delay_ms(1000);

    esp8266_restart();
    esp8266_echoCmds(0);
    esp8266_isStarted();
    esp8266_mode(ESP8266_STATION);
    esp8266_connect(" "," ");
    esp8266_start(ESP8266_TCP, "192.168.1.4", 8000);

    RE0_bit = 1;

    esp8266_trans_mode(ESP8266_TRANS_PASS);
    esp8266_send();

    RCIF_bit = 0;
    PIE1.RCIE = 1;

    GIE_bit = 1;
    PEIE_bit = 1;

    while(1)
    {
        if (Button(&PORTB, 0, 10, 0))
        {
            while(Button(&PORTB, 0, 10, 0));

            TransmitData = 'S';
            UART1_Write(TransmitData);
        }

        if(receive_flag == 1)
        {
            receive_flag = 0;
            ReceiveData = UART1_Read();

            if (ReceiveData == '@')
            {
                LATE1_bit = 1;

                TransmitData = 'O';
                UART1_Write(TransmitData);
            }
            else if (ReceiveData == '$')
            {
                LATE1_bit = 0;

                TransmitData = 'F';
                UART1_Write(TransmitData);
            }
            else if (ReceiveData == 'Z')
            {
                GIE_bit = 0;

                RE0_bit = 0;

                esp8266_stop_send();
                esp8266_trans_mode(ESP8266_TRANS_NOR);
                esp8266_del_TCP();
            }
        }
    }
}