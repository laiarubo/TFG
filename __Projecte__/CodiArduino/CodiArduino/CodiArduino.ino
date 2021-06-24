#define PIN_LED 13
#define USE_ARDUINO_INTERRUPTS true    // Set-up low-level interrupts for most acurate BPM math.
#include <ArduinoJson.h>
#include <PulseSensorPlayground.h>     // Includes the PulseSensorPlayground Library. 

// TASCA 1 = REBRE ORDRES
String ENTRADA = ""; // Agafa les dades d'entrada
String COMANDA = ""; // Agafa la comanda de les dades d'entrada
boolean STRING_COMPLET = false;
boolean CONNECTAT = false;

// TASCA 2 = VOSTRAR VALORS CADA X TEMPS
unsigned long PREVIOUS_TIME2 = millis();
unsigned long PREVIOUS_TIME3 = millis();
long TIME_INTERVAL2 = 500; 
long TIME_INTERVAL3 = 500; 
long VALOR_ALEATORI2;
long VALOR_ALEATORI3;

// TASCA 3 = LLEGIR LES DADES DEL PULSE SENSOR i del galvanic
const int PulseWire = 0;       // PulseSensor PURPLE WIRE connected to ANALOG PIN 0
int Threshold = 550;           // Default "count as a beat" signal value
PulseSensorPlayground pulseSensor;  // Creates an instance of the PulseSensorPlayground object called "pulseSensor"
int gsr_value = 0;
int gsr_average = 0;


void setup() {
  Serial.begin(9600); // baud rate

  // TASCA 1
  pinMode(PIN_LED, OUTPUT); // S'especifica que el pin funciona com a sortida

  // TASCA 2
  randomSeed(analogRead(0));  

  // TASCA 3
    // Configure the PulseSensor object, by assigning our variables to it. 
  pulseSensor.analogInput(PulseWire);   
  pulseSensor.setThreshold(Threshold);   

  

    // Double-check the "pulseSensor" object was created and "began" seeing a signal. 
   if (pulseSensor.begin()) {
    Serial.println("We created a pulseSensor Object !");  //This prints one time at Arduino power-up,  or on Arduino reset.  
  }
}



void loop() {  
  
  //
  //  TASCA 1
  //
  
  if (STRING_COMPLET) {
    STRING_COMPLET = false;

    getComanda();

    if (COMANDA.equals("FINAL")) 
      digitalWrite(PIN_LED, LOW); // S'apaga el LED    
    else if (COMANDA.equals("LED_O")) // Control del LED
    {
      boolean ences = LEDences();
      if (ences) 
        digitalWrite(PIN_LED, LOW); // S'apaga el LED        
      else 
        digitalWrite(PIN_LED, HIGH); // S'encén el LED        
    }

    ENTRADA = "";    
  }
  
  //
  // TASCA 2 
  //

    // Cardiograma
  
  int myBPM = pulseSensor.getBeatsPerMinute();  // Calls function on our pulseSensor object that returns BPM as an "int". "myBPM" hold this BPM value now. 
  
  if (pulseSensor.sawStartOfBeat()) {            // Constantly test to see if "a beat happened". 
    DynamicJsonBuffer jBuffer1;
    JsonObject& obj1 = jBuffer1.createObject();
    obj1["idDispositiu"] = 1;
    obj1["idSensor"] = 1;
    obj1["valor"] = myBPM;
    obj1.printTo(Serial);
    Serial.print('\n');
  }
    
    // Miograma
    
  unsigned long currentTime2 = millis();
  if (currentTime2 - PREVIOUS_TIME2 > TIME_INTERVAL2)
  {
    PREVIOUS_TIME2 = currentTime2;
    
    int muscleSensorValue = analogRead(A1);
    DynamicJsonBuffer jBuffer2;
    JsonObject& obj2 = jBuffer2.createObject();
    obj2["idDispositiu"] = 1;
    obj2["idSensor"] = 2;
    obj2["valor"] = muscleSensorValue;
    obj2.printTo(Serial);
    Serial.print('\n');
  }

    // Resposta galvànica
    
  unsigned long currentTime3 = millis();
  if (currentTime3 - PREVIOUS_TIME3 > TIME_INTERVAL3)
  {
    PREVIOUS_TIME3 = currentTime3;
    
    long sum=0;
    for(int i=0;i<50;i++) //Average the 10 measurements to remove the glitch
    {
      gsr_value = analogRead(A2);
      sum += gsr_value;
    }
    
    gsr_average = sum/50;

    DynamicJsonBuffer jBuffer3;
    JsonObject& obj3 = jBuffer3.createObject();
    obj3["idDispositiu"] = 1;
    obj3["idSensor"] = 3;
    obj3["valor"] = gsr_average;
    obj3.printTo(Serial);
    Serial.print('\n');
  }
}



boolean getComanda() {
  if (ENTRADA.length() > 0)
    COMANDA = ENTRADA.substring(1, 6);
}



boolean LEDences() {
  boolean retorn = false;

  if (ENTRADA.substring(5,7).equals("ON")) // El PC ha enviat la comanda #LED_ON\n. 5 i 7 són les posicions que ocupa "ON"
    retorn = true;
  else 
    retorn = false;

  return !retorn;
}



void serialEvent() {
  while(Serial.available()) {

    // LECTURA DE LA COMANDA
    char input = (char)Serial.read(); // Entrada de cada byte
    ENTRADA += input; 

    if (input == '\n') 
      STRING_COMPLET = true;
  }
}
