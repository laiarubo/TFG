
String ENTRADA = ""; // Agafa les dades d'entrada
String COMANDA = ""; // Agafa la comanda de les dades d'entrada

boolean STRING_COMPLET = false;
boolean CONNECTAT = false;

int PIN_LED = 13;

void setup() {
  Serial.begin(9600); // baud rate
  pinMode(PIN_LED, OUTPUT); // S'especifica que el pin funciona com a sortida
}

void loop() {
  
  
  if (STRING_COMPLET) {
    STRING_COMPLET = false;

    getComanda();

    /*if (COMANDA.equals("INICI")) 
      digitalWrite(PIN_LED, HIGH);  // !!! VERIFICAR QUE SIGUI CORRECTE !!!
    else*/ if (COMANDA.equals("FINAL")) 
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
    char input = (char)Serial.read(); // Entrada de cada byte
    ENTRADA += input; 

    if (input == '\n') 
      STRING_COMPLET = true;
}
}
