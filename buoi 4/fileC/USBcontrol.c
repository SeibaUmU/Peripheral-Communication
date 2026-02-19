// Khai bao bien va du lieu
#define led_on     1    // Muc logic dieu khien trang thai LED
#define led_off    0
#define in_size    64   // Mac dinh kich thuoc du lieu doc/ghi
#define out_size   64
char count,count2,count3 = 0;         // Chua so lan nhan SW
bit oldstate;           // Co bao trang thai cho SW
unsigned char readbuff[in_size] absolute 0x500;    // Bo dem chua du lieu doc va ghi
unsigned char writebuff[out_size] absolute 0x540;
                        // Nen de trong vung USB RAM, xem them trong datasheet
void interrupt()
{
  if(PIR2.USBIF == 1)
  {
    PIR2.USBIF = 0;             // Clear interrupt bit
    USB_Interrupt_Proc();       // ISR cho USB
  }

  if(INTCON.INT0IF == 1)
  {
    INTCON.INT0IF = 0;          // Clear interrupt bit
    count++;
    writebuff[0] = count;
    oldstate = 1;
  }
  if (INTCON3.INT1IF) { //ngat ngoai tai RB1
        INTCON3.INT1IF = 0;          // Clear interrupt bit
        count2++;
        writebuff[1] = count2;
        oldstate = 1;
    }
    if (INTCON3.INT2IF) { //ngat ngoai tai RB2
        INTCON3.INT2IF = 0;          // Clear interrupt bit
        count3++;
        writebuff[2] = count3;
        oldstate = 1;
    }
}
void main(void)
{
  ADCON1 |= 0x0F;        // Tat ca chan Analog thanh chan Digital
  CMCON  |= 0x07;        // Cam modul Comparators

  // Cau hinh Port B
  PORTB = 0x00; LATB = 0x00;
  TRISB.TRISB0 = 1;          // Thiet lap RB0 la dau vao
  INTCON2.RBPU = 0;          // Bat dien tro keo len Port B

  // Cau hinh Port D 
  PORTD = 0x00; LATD = 0x00;
  TRISD = 0;          // Thiet lap RD0-7 la dau ra

  // Cau hinh modul USB
  HID_Enable(&readbuff,&writebuff);    // Cho phep USB o che do HID

  // Cau hinh ngat
  INTCON.INT0IF = 0;     // Clear interrupt bit
  INTCON3.INT1IF = 0;   // RB1
  INTCON3.INT2IF = 0;   // RB2

  INTCON.INT0IE = 1;     // Enable external interrupts
  INTCON3.INT1IE = 1;   // RB1
  INTCON3.INT2IE = 1;   // RB2

  INTCON2.INTEDG0 = 1;   // External interrupt on rising edge
  INTCON2.INTEDG1 = 1;
  INTCON2.INTEDG2 = 1;

  PIR2.USBIF = 0;        // Clear interrupt bit
  PIE2.USBIE = 1;        // Enable the USB interrupt
  INTCON.GIE = 1;        // Enable global interrupt
  INTCON.PEIE = 1;       // Enable periphiral interrupts

  while(1)
  {
    // Doc du lieu tu HOST thong qua USB
    if(HID_Read() != 0)
    {
      // --- PHẦN BẠN MUỐN SỬA ---
      
      // 1. Điều khiển LED
      // Lấy dữ liệu từ byte 1 gán thẳng vào LATD
      LATD = readbuff[0];

      // 2. Logic phản hồi O/F
      if (readbuff[0] > 0)
      {
         // Nếu giá trị > 0 (tức là có ít nhất 1 đèn bật)
         writebuff[8] = 'O'; 
         // Bạn có thể đổi màu trên C# thành Đỏ
      }
      else
      {
         // Nếu giá trị == 0 (tắt hết 8 đèn)
         writebuff[8] = 'F'; 
         // Bạn có thể đổi màu trên C# thành Xám
      }

      // 3. Gửi phản hồi về máy tính
      HID_Write(&writebuff, out_size);
    }

    // Kiem tra neu co ngat tu nut nhan
    if (oldstate == 1)
    {
      oldstate = 0;                    // Reset co trang thai
      HID_Write(&writebuff, out_size); // Gui so lan nhan den HOST
    }
  }
}