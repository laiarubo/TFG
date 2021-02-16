#define PIN_LED 13

// TASCA 1 - REBRE ORDRES
String ENTRADA = ""; // Agafa les dades d'entrada
String COMANDA = ""; // Agafa la comanda de les dades d'entrada
boolean STRING_COMPLET = false;
boolean CONNECTAT = false;

// TASCA 2 - CALCULAR VALOR_ALEATORI CADA SEGON
unsigned long PREVIOUS_TIME2 = millis();
unsigned long PREVIOUS_TIME3 = millis();
long TIME_INTERVAL2 = 1000; // 1 segon
long TIME_INTERVAL3 = 2000; // 2 segons
long VALOR_ALEATORI2;
long VALOR_ALEATORI3;



void setup() {
  Serial.begin(9600); // baud rate

  // TASCA 1
  pinMode(PIN_LED, OUTPUT); // S'especifica que el pin funciona com a sortida

  // TASCA 2
  randomSeed(analogRead(0));  
}



void loop() {  

  //  TASCA 1
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

  // TASCA 2 

  // Miograma
  unsigned long currentTime2 = millis();
  if (currentTime2 - PREVIOUS_TIME2 > TIME_INTERVAL2)
  {
    PREVIOUS_TIME2 = currentTime2;
    VALOR_ALEATORI2 = random(1,3); // Valor enter entre 1 i 2
    String id_miograma = "2|";
    Serial.println(id_miograma+=VALOR_ALEATORI2);   
  }

  // Resposta galvànica
  unsigned long currentTime3 = millis();
  if (currentTime3 - PREVIOUS_TIME3 > TIME_INTERVAL3)
  {
    PREVIOUS_TIME3 = currentTime3;
    VALOR_ALEATORI3 = random(10,50);
    String id_rg = "3|";  
    Serial.println(id_rg+=VALOR_ALEATORI3);
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
