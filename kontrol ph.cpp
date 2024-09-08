#include "DFRobot_PH.h"
#include <EEPROM.h>

#define PH_PIN A5
float voltage,phValue,temperature = 25;
DFRobot_PH ph;
int xxx = 0;
double atas,bawah;
bool xauto = false,up = false, down = false;

void setup(){
  
  Serial.begin(115200);  
  
  ph.begin();
  pinMode(10,OUTPUT); //~pwm pompa asam
  pinMode(6,OUTPUT);  // arah pompa asam
  pinMode(7,OUTPUT);  // arah pompa asam

  pinMode(11,OUTPUT); // ~pwm pompa basa
  pinMode(8,OUTPUT);  // arah pompa basa
  pinMode(9,OUTPUT);  // arah pompa basa

  pinMode(5,OUTPUT);  //~pwm pompa logam
  pinMode(4,OUTPUT);  // arah pompa logam
  pinMode(3,OUTPUT);  // arah pompa logam
}

String jadi;
String inData;
void loop(){
  

        voltage = analogRead(PH_PIN)/1024.0*5000;  // read the voltage
        phValue = ph.readPH(voltage,temperature);  // convert voltage to pH with temperature compensation
        
        //Serial.print("temperature:");
        //Serial.print(temperature,1);
        //Serial.print("^C  pH:");
        Serial.println(phValue);
        
        
        //ph.calibration(voltage,temperature);           // calibration process by Serail CMD

  while(Serial.available() > 0){    
        char recieved = Serial.read();
        inData += recieved; 
          if(recieved == '&'){         
            //Serial.println(inData);
            
              if (inData == "stop&"){
                analogWrite(10,0);
                analogWrite(11,0);
                analogWrite(5,0);
              }
              else if(inData == "runmetalsol&"){
                analogWrite(5,200);
                digitalWrite(3,HIGH);
                digitalWrite(4,LOW);
              }
              else if(inData == "runbase&"){
                analogWrite(11,200);
                digitalWrite(8,LOW);
                digitalWrite(9,HIGH);
              }
              else if(inData == "runacid&"){                
                analogWrite(10,200);
                digitalWrite(6,HIGH);
                digitalWrite(7,LOW);
              }
                
  inData = "";
}

if(recieved == '@'){

      
      //inData = inData.substring(0,3);
      //Serial.println(inData.toInt());

      if(inData.substring(0,4) == "basa"){
        
           analogWrite(11,map((inData.substring(4,7)).toInt(),0,20,0,95));           
           digitalWrite(8,LOW);
           digitalWrite(9,HIGH);
        }
      else if(inData.substring(0,4) == "asam"){
           analogWrite(10,map((inData.substring(4,7)).toInt(),0,20,0,88));
           digitalWrite(6,HIGH);
           digitalWrite(7,LOW);
        }
      else if(inData.substring(0,4) == "meta"){

            analogWrite(5,map((inData.substring(4,7)).toInt(),0,20,0,120));
            digitalWrite(3,HIGH);
            digitalWrite(4,LOW);
        }
       else if (inData == "a@"){            
            analogWrite(5,0);
        }
        else if (inData == "b@"){
            analogWrite(10,0);            
        }
        else if (inData == "c@"){            
            analogWrite(11,0);
            
        }

        


      
  inData = "";
  }








if(recieved == '*'){

  //if(phValue > inData.substring(0,5).toDouble()){
               atas = inData.substring(0,5).toDouble();
                up = true;
//                analogWrite(10,95);
//                digitalWrite(6,HIGH);
//                digitalWrite(7,LOW);
//                analogWrite(11,0);
     
  //  }

    //if(phValue < inData.substring(5,10).toDouble()){
                bawah = inData.substring(5,10).toDouble();
                down = true;
//                analogWrite(11,100);
//                digitalWrite(8,LOW);
//                digitalWrite(9,HIGH);
//                analogWrite(10,0);
      //}

    if(inData == "0*"){
      up = false;
      down = false;
      xxx = 0;
            analogWrite(10,0);
            analogWrite(11,0);
          
      }
  //Serial.println(inData.substring(5,10).toDouble());
  inData = "";
  }








    
//      analogWrite(10,jadi.toInt());
//      digitalWrite(6,HIGH);
//      digitalWrite(7,LOW);

//      analogWrite(11,jadi.toInt());
//digitalWrite(8,LOW);
//digitalWrite(9,HIGH);

//analogWrite(5,jadi.toInt());
//digitalWrite(3,HIGH);
//digitalWrite(4,LOW);


//Serial.println(receiveVal);




   }



if(phValue > atas){
  if(up == true && xxx<=500){
                analogWrite(10,98);
                digitalWrite(6,HIGH);
                digitalWrite(7,LOW);
                analogWrite(11,0);
  }
  else if (up == true && xxx >500){
     analogWrite(10,0);
    }
  }

  else if(phValue < bawah){
    if(down == true && xxx<=500){
                analogWrite(11,105);
                digitalWrite(8,LOW);
                digitalWrite(9,HIGH);
                analogWrite(10,0);
  }
  else if (down == true && xxx >500){
     analogWrite(11,0);
    }
    }
    
else{
  analogWrite(10,0);
  analogWrite(11,0);
  }




   
  xxx+=1;
  if(xxx == 5000){
    xxx = 0;
    }
   
  delay(1);
}







float readTemperature()
{
  //add your code here to get the temperature from your temperature sensor
}