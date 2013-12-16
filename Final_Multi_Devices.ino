
// GSR sensor variables
 int sensorPin = A5; // select the input pin for the GSR 
// Buzzer pin
int buzzerPin = 2;
int GsvBeep = 500;
 
// Time variables
 unsigned long time;
 int secForGSR;
 int curMillisForGSR;
 int preMillisForGSR;


const int analogInPin1 = A0;
const int analogInPin2 = A1;
const int analogInPin3 = A2;

float sensorValue = 0;
float sensorValue2 = 0;
float sensorValue3 = 0;

float outputValue = 0;
float outputValue2 = 0;
float outputValue3 = 0;

String newString;

void setup()
{
  Serial.begin(9600); 
 
  pinMode(buzzerPin, OUTPUT);
 
  secForGSR = 1; // How often do we get a GSR reading
  curMillisForGSR = 0;
  preMillisForGSR = -1;  
}

void loop()
{
  if(Serial.available())
  {  
    int Option = Serial.read();
    
    switch (Option) {
      case '1':
      
        analogInPin1 == HIGH;
        sensorPin == LOW;
        analogInPin3 == LOW;  

        //for(int i = 0; i < 21; i++)
        do
        {
          sensorValue = analogRead(analogInPin1);
          outputValue = ((sensorValue /1023) * 5 * 1000) / 30;          
    
          Serial.println(outputValue);
          delay(200);
         }    while(Serial.read() != '5');

         break;     
       
 
       case '2':
       {   
         analogInPin1 == LOW;
         sensorPin == HIGH;
         analogInPin3 == LOW;
 
           //for(int i = 0; i < 21; i++)
           do
           {   
                  time = millis();
 
     curMillisForGSR = time / (secForGSR * GsvBeep);
     if(curMillisForGSR != preMillisForGSR) 
     {
     // Read GSR sensor and send over Serial port
     sensorValue2 = analogRead(sensorPin);
     Serial.println(sensorValue2);
     preMillisForGSR = curMillisForGSR;
     }
     digitalWrite(buzzerPin, HIGH);
     tone(2,1500,10);
     delay(GsvBeep - sensorValue+100);
     digitalWrite(buzzerPin, LOW);
             
                    
           }    while(Serial.read() != '5');       
            
         break;
         }     
         
         case '3':  
         {    
           analogInPin1 == LOW;
           sensorPin == LOW;            
           analogInPin3 == HIGH;        
           
           //for(int i = 0; i < 21; i++)
           do
           {
             sensorValue3 = analogRead(analogInPin3);  
             outputValue3 = ((sensorValue3 /1023) * 5 * 1000) / 30;     
             
             Serial.println(outputValue3);
             delay(500);
           }   while(Serial.read() != '5');
           break;
         }    
         
         case '4':
         {      
           analogInPin1 == HIGH;
           sensorPin == HIGH;   
           analogInPin3 == HIGH;             
           

   
           time = millis();  
          
           curMillisForGSR = time / (secForGSR * GsvBeep);
   
           if(curMillisForGSR != preMillisForGSR)
           {
             // Read GSR sensor and send over Serial port
             sensorValue2 = analogRead(sensorPin);
             preMillisForGSR = curMillisForGSR;
           }
   
           digitalWrite(buzzerPin, HIGH);
           tone(2,1500,10);
           delay(GsvBeep - sensorValue+100);
           digitalWrite(buzzerPin, LOW);       
          
           //for(int i = 0; i < 21000; i++)
           do
           {
                        sensorValue = analogRead(analogInPin1);
           sensorValue2 = analogRead(sensorPin);
           sensorValue3 = analogRead(analogInPin3);  
             
             outputValue = (((sensorValue /1023) * 5 * 1000) / 30) +1000;
             outputValue2 = sensorValue2 + 10000;
             outputValue3 = (((sensorValue3 /1023) * 5 * 1000) / 30) + 100000;
   
             Serial.println(outputValue);
             Serial.println(outputValue2);
             Serial.println(outputValue3);
             
             delay(500);
           }while(Serial.read() != '5');
           

           break;
         }
   
         case'5':
         {
           analogInPin1 == LOW;
           sensorPin == LOW;      
           analogInPin3 == LOW;
   
           break;
         }       
        
         default: 
         analogInPin1 == LOW;
         analogInPin2 == LOW;  
         analogInPin3 == LOW;
       }   
     }
   }


    
  
  

    

  


