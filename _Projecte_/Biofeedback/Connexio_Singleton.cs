using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.CompilerServices;

namespace Biofeedback
{
    public sealed class Connexio_Singleton
    {
        // Static vol dir que per a tots els objectes del tipus Connexio_Singleton, aquella variable estàtica serà la mateixa
        private static Connexio_Singleton _instance;// = new Connexio_Singleton();

        // Per a la connexió PC - Arduino
        SerialPort PORTSELECCIONAT;

        // Per rebre dades de l'arduino en forma d'event
        public delegate void EventData(string s); // delegate és un disparador (avisa a tothom que hi ha un nou string disponible)
        public event EventData nouEventCardiograma; // això és l'event de tipus EventData
        public event EventData nouEventMiograma; 
        public event EventData nouEventRespostaGalvanica;

        static Connexio_Singleton()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)] // Per sincronitzar els threads
        public static Connexio_Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Connexio_Singleton();
               
            }
    
            return _instance;
        }

        public void ConnectarArduino(string port)
        {
            // public SerialPort (string portName, int baudRate, System.IO.Ports.Parity parity);
            PORTSELECCIONAT = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            PORTSELECCIONAT.DataReceived += EventDadaRebuda; // Es recull l'event de DataReceived i es tracta executant el codi EventDadaRebuda
            PORTSELECCIONAT.Open(); // S'activa el port COM
            if (PORTSELECCIONAT.IsOpen)
                PORTSELECCIONAT.Write("#INICI\n");
        }

        private void EventDadaRebuda(object sender, SerialDataReceivedEventArgs e) // Aquesta funció descobreix que hi ha una nova dada
        {
            SerialPort sp = (SerialPort)sender; // Es fa un cast de tipus SerialPort a l'objecte sender 
            string dada = sp.ReadLine(); // Llegeixes el contingut del sender (que ha provocat l'event )
         
            //tractar diagrama que toqui
            string[] valorsArduino = dada.Split('|'); // 2|10 Per separar el 2 del 10
            if (valorsArduino != null && valorsArduino.Count() == 2) // 2 perquè s'espera id + valor
            {
                switch (valorsArduino[0])
                {
                    case "1":
                        // cridar nouEventCardiograma
                        if (valorsArduino[1] != "" && valorsArduino[1] != "\r")
                            nouEventCardiograma.Invoke(valorsArduino[1]); // Se li envia el valor
                        break;
                    case "2":
                        // cridar nouEventMiograma
                        if (valorsArduino[1] != "" && valorsArduino[1] != "\r")
                            nouEventMiograma.Invoke(valorsArduino[1]); 
                        break;
                    case "3":
                        // cridar nouEventRespostsaGalvanica
                        if (valorsArduino[1] != "" && valorsArduino[1] != "\r")
                            nouEventRespostaGalvanica.Invoke(valorsArduino[1]);
                        break;
                    default:
                        break;
                }


            }
        }

        public bool writeCommand(string c)
        {
            if (PORTSELECCIONAT.IsOpen)
            {
                PORTSELECCIONAT.Write(c);
                return true;
            }
            else
                return false;
        }

        public string readFromArduino()
        {
            if (PORTSELECCIONAT != null)
                return PORTSELECCIONAT.ReadExisting();
            else return "";
        }

        public bool portObert()
        {
            return PORTSELECCIONAT.IsOpen;
        }
    }
}
