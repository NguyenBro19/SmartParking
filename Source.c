#include <motor.h>
#use delay (clock = 4MHZ)
#use rs232(baud=9600, parity=N, xmit=PIN_C6,rcv=PIN_C7)

#define LCD_ENABLE_PIN  PIN_D3                                    
#define LCD_RS_PIN      PIN_D1                                    
#define LCD_RW_PIN      PIN_D2                                    
#define LCD_DATA4       PIN_D4                                    
#define LCD_DATA5       PIN_D5                                    
#define LCD_DATA6       PIN_D6                                    
#define LCD_DATA7       PIN_D7 

#define Wire1 PIN_B5
#define Wire2 PIN_A5

#define Wire3 PIN_B4
#define Wire4 PIN_B2

#define LED1 PIN_E1
#define LED2 PIN_C0
#define COI  PIN_D0

#include <lcd.c>

int a = 0, b = 0, i = 0;
char c;
int var = 0; //coi1
int var1 = 0; //coi2

Void LCD()
{
      if (i >= 3) 
      {
        lcd_gotoxy(1,1);
        printf (lcd_putc, "TONG XE: %d", i);
        lcd_gotoxy(1,2);
        lcd_putc ("BAI XE DAY");
      }
      if (i < 3)
      {
        lcd_gotoxy(1,1);
        printf (lcd_putc, "TONG XE: %d", i);
        lcd_gotoxy(1,2);
        lcd_putc ("CON TRONG ");
      }
}

Void Motor1()
{
         if (a == 0)
         {  
            output_low(Wire1);           
            output_high(Wire2);
            output_high(LED1); 
         }
         
         if(input(PIN_A3) == 0)  //CTHT 1: turn off motor2
         {
            output_low(Wire1);           
            output_low(Wire2);
      
            if(input(PIN_E0) == 1)  //Cambienvatthe: co vat the thi motor ko hoat dong
            {
               output_low(Wire1);           
               output_low(Wire2);       
            }    
            a = 1;
         }
         
         if(input(PIN_E0) == 0 && a == 1 )
         { 
            delay_ms(500);
            output_high(Wire1);           
            output_low(Wire2);
         }
         
         if(input(PIN_A2) == 1)     //CTHT 2: turn off motor2
         {
            output_low(Wire1);
            output_low(Wire2);
            output_low(LED1);
         }
      
         if(a == 1 && input(PIN_A2) == 1) 
         {
            c = '0';
            a = 0;
            i++;
            var = 0;
         }
}
Void Motor2()
{
         delay_ms(500);
         if (b == 0)
         {                      
            output_low(Wire3);           
            output_high(Wire4);
            output_high(LED2); 
         }
         
         if(input(PIN_A1) == 0)  //CTHT 3: turn off motor2
         {
            output_low(Wire3);           
            output_low(Wire4);
      
            if(input(PIN_C5) == 1)  //Cambienvatthe: co vat the thi motor ko hoat dong
            {
               output_low(Wire3);           
               output_low(Wire4);       
            }    
            b = 1;
         }
         
         if(input(PIN_C5) == 0 && b == 1 )
         { 
            delay_ms(500);
            output_high(Wire3);           
            output_low(Wire4);
         }
         
         if(input(PIN_A0) == 0)     //CTHT 4: turn off motor2
         {
            output_low(Wire3);
            output_low(Wire4);
            output_low(LED2);
         }
         
         if (b == 1 && input(PIN_A0) == 0)
         {
            b = 0;
            c = '0';
            i--;
            var1 = 0;
         }
}

void main()
{
   lcd_init();
   setup_timer_2(T2_DIV_BY_16,100,1);   // Set PWM frequency
   setup_ccp1(CCP_PWM);          // Configure CCP1 to PWM mode
   setup_ccp2(CCP_PWM);
   set_pwm1_duty(33);   //motor2
   set_pwm2_duty(33);  //motor1
   
   output_low(Wire1);           
   output_low(Wire2);
   
   output_low(Wire3);           
   output_low(Wire4);
   
   while(TRUE)
   {     
      LCD();
      if  (kbhit()) c = getch();
      
      if(c == '1')   
      { 
          if(var == 0)
          {
          output_high(COI);
          delay_ms(300);
          output_low(COI);
          var = 1;
          }
          Motor1();
      }
      
      if(c == '2')
      {    
          if(var1 == 0)
          {
          output_high(COI);
          delay_ms(300);
          output_low(COI);
          var1 = 1;
          }
          Motor2();
      }
   }
}
