char rx_buffer[50];
unsigned int count = 0, count1 = 0, count2 = 0;
char str_count[7];
char uart_rd;
int i = 0;

void main() {
    ADCON1 |= 0X0F;
    CMCON  |= 7;

    TRISE = 0; LATE = 0;
    TRISB = 0x07;

    UART1_Init(115200);
    delay_ms(100);

    while (1) {
        if (UART1_Data_Ready()) {
            uart_rd = UART1_Read();
            if (uart_rd == '@') i = 0;
            rx_buffer[i++] = uart_rd;
            if (uart_rd == '&') {
                rx_buffer[i] = '\0';
                if (strstr(rx_buffer, "@le1_on")) { LATE0_bit = 1; UART1_Write_Text("@Lle1_on&"); }
                else if (strstr(rx_buffer, "@le1_of")) { LATE0_bit = 0; UART1_Write_Text("@Lle1_of&"); }
                else if (strstr(rx_buffer, "@le2_on")) { LATE1_bit = 1; UART1_Write_Text("@Lle2_on&"); }
                else if (strstr(rx_buffer, "@le2_of")) { LATE1_bit = 0; UART1_Write_Text("@Lle2_of&"); }
                else if (strstr(rx_buffer, "@le3_on")) { LATE2_bit = 1; UART1_Write_Text("@Lle3_on&"); }
                else if (strstr(rx_buffer, "@le3_of")) { LATE2_bit = 0; UART1_Write_Text("@Lle3_of&"); }
                i = 0;
            }
        }

        if (Button(&PORTB, 0, 10, 0)) {
            while (Button(&PORTB, 0, 10, 0));
            count++;
            IntToStr(count, str_count);
            Ltrim(str_count);
            UART1_Write_Text("@S0");
            UART1_Write_Text(str_count);
            UART1_Write('&');
        }

        if (Button(&PORTB, 1, 10, 0)) {
            while (Button(&PORTB, 1, 10, 0));
            count1++;
            IntToStr(count1, str_count);
            Ltrim(str_count);
            UART1_Write_Text("@S1");
            UART1_Write_Text(str_count);
            UART1_Write('&');
        }

        if (Button(&PORTB, 2, 10, 0)) {
            while (Button(&PORTB, 2, 10, 0));
            count2++;
            IntToStr(count2, str_count);
            Ltrim(str_count);
            UART1_Write_Text("@S2");
            UART1_Write_Text(str_count);
            UART1_Write('&');
        }
    }
}