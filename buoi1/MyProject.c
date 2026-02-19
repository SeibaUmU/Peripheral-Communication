#define led_on 1 //muc logic dk trang thai led
#define led_off 0
#define max_count_ReceiveData 10 //quy dinh so luog data (kytu) nhan toi da
#define len_code 6 //quy dinh so ky tu trong ma lenh (le1_on: 6 ky tu)

char ReceiveData; //byte de luu gia tri data nhan duoc
char buffer[15]; //buffer de gui data di, bo dem du lieu gui di
int count0 = 0, count1 = 0, count2 = 0; //so lan nhan SW
bit oldstate; //co bao state cho SW
char start_sign = '@'; //ma bat dau chuoi lenh
char end_sign = '&';//ma ket thuc chuoi lenh
char count_ReceiveData = 0; //dem so luong data nhan duoc
char buf_string_receive[max_count_ReceiveData]; //buffer de luu chuoi lenh nhan duoc
char start_Data, end_Data; //bien luu gia tri ky tu bat dau va ket thuc
char receive_complete = 0; //co bao nhan du lieu hoan tat (0:chua, 1:hoan tat)

void Clear_buf_string_receive(void) { //xoa nd bo dem nhan du lieu
     unsigned char i;
     for (i=0;i<=max_count_ReceiveData;i++){
            buf_string_receive[i] = '\0';} //xoa tung byte trong chuoi lenh nhan duoc
}

void interrupt(void){
     if (INTCON.INT0IF) { //ngat ngoai tai RB0
        INTCON.INT0IF = 0;
        count0++;
        sprintf(buffer, "@S0_%d&", count0);
        UART1_Write_Text(buffer);
    }
    if (INTCON3.INT1IF) { //ngat ngoai tai RB1
        INTCON3.INT1IF = 0;
        count1++;
        sprintf(buffer, "@S1_%d&", count1);
        UART1_Write_Text(buffer);
    }
    if (INTCON3.INT2IF) { //ngat ngoai tai RB2
        INTCON3.INT2IF = 0;
        count2++;
        sprintf(buffer, "@S2_%d&", count2);
        UART1_Write_Text(buffer);
    }
     if(PIR1.RCIF==1) // ngat uart1 khi co data nhan duoc
     {
      PIR1.RCIF = 0;
      ReceiveData = UART1_Read(); //doc du lieu tu uart1
      if (ReceiveData == start_sign) //byte nhan dc la ky tu bat dau
      {
       count_ReceiveData = 0; //reset bo dem
       start_Data = ReceiveData; //luu ky tu bat dau
       buf_string_receive[count_ReceiveData] = ReceiveData; //luu ky tu bat dau vao bo dem
      }
      if (ReceiveData==end_sign)
      {
       end_Data = ReceiveData;
       buf_string_receive[count_ReceiveData] = ReceiveData;
      }
      if ((start_Data == start_sign) && (end_Data == end_sign)) //xac nhan chuoi lenh da duoc nhan hoan tat
      {
       receive_complete = 1; //dat co bao nhan du lieu hoan tat
       count_ReceiveData = 0; //reset bo dem
       start_Data = '\0'; //xoa bo dem ky tu bat dau
       end_Data = '\0'; //xoa bo dem ky tu ket thuc
      }
      else
      {
       buf_string_receive[count_ReceiveData] = ReceiveData; //xac nhan byte du lieu nhan la cac ky tu trong chuoi lenh (ch ket thuc chuoi)
       count_ReceiveData++;
       if (count_ReceiveData > max_count_ReceiveData)
       {
        count_ReceiveData = 0;
       }
      }
      //xu li, so sanh, dieu khien va gui phan hoi
      if (receive_complete == 1)
      {//led re0
       if (strncmp(strstr(buf_string_receive,"@le0_on"),"@le0_on",len_code) == 0) //so sanh chuoi lenh nhan duoc voi ma lenh
       {
        LATE.LATE0 = led_on; // bat led re0
        UART1_Write_Text("@Lle0_on&"); //gui phan hoi, voi du lieu dc gui co dang @...&
       }
       else if (strncmp(strstr(buf_string_receive,"@le0_of"),"@le0_of",len_code) == 0)
       {
        LATE.LATE0 = led_off; //tat led re0
        UART1_Write_Text("@Lle0_off&");
       }
       //led re1
       else if (strncmp(strstr(buf_string_receive,"@le1_on"),"@le1_on",len_code) == 0)
       {
        LATE.LATE1 = led_on;
        UART1_Write_Text("@Lle1_on&");
       }
       else if (strncmp(strstr(buf_string_receive,"@le1_of"),"@le1_of",len_code) == 0)
       {
        LATE.LATE1 = led_off;
        UART1_Write_Text("@Lle1_off&");
       }
       //led re2
       else if (strncmp(strstr(buf_string_receive,"@le2_on"),"@le2_on",len_code) == 0)
       {
        LATE.LATE2 = led_on;
        UART1_Write_Text("@Lle2_on&");
       }
       else if (strncmp(strstr(buf_string_receive,"@le2_of"),"@le2_of",len_code) == 0)
       {
        LATE.LATE2 = led_off;
        UART1_Write_Text("@Lle2_off&");
       }

       else
       {
        UART1_Write_Text("@Error&"); //gui phan hoi neu ma lenh khong hop le
       }
       

       receive_complete = 0; //thong bao ch nhan dung dinh dang
       count_ReceiveData = 0; //xoa bo dem
       Clear_buf_string_receive(); //xoa chuoi
       }
       }
}

void main(){
     ADCON1 |= 0x0F; //all pins digital
     CMCON |= 7; //cam modul comparator
     PORTB = 0x00; LATB = 0x00; 
     TRISB.TRISB0 = 1;  TRISB.TRISB1 = 1; TRISB.TRISB2 = 1;
     PORTE = 0x00; LATE = 0x00;
     TRISE.TRISE1 = 0; TRISE.TRISE0 = 0; TRISE.TRISE2 = 0;
    //bat ngat ngoai
     INTCON.INT0IF = 0;
     INTCON3.INT1IF = 0;   // RB1
     INTCON3.INT2IF = 0;   // RB2
     
    INTCON.INT0IE = 1;    // RB0
    INTCON3.INT1IE = 1;   // RB1
    INTCON3.INT2IE = 1;   // RB2

    INTCON2.INTEDG0 = 1;
    INTCON2.INTEDG1 = 1;
    INTCON2.INTEDG2 = 1;
    //bat ngat uart1
     PIR1.RCIF = 0;
     PIE1.RCIE = 1;
    //bat ngat toan cuc
     INTCON.GIE = 1;
     INTCON.PEIE = 1;
     UART1_Init(9600); //baud rate 9600
     delay_ms(100);
     while(1);
}