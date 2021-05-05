using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            try
            {
                dynamic json = JObject.Parse(dada);

                switch ((int)json.idSensor)
                {
                    case 1:
                        // cridar nouEventCardiograma
                        nouEventCardiograma.Invoke(json.valor.ToString()); // Se li envia el valor
                        break;
                    case 2:
                        // cridar nouEventMiograma
                        nouEventMiograma.Invoke(json.valor.ToString());
                        break;
                    case 3:
                        // cridar nouEventRespostsaGalvanica
                        nouEventRespostaGalvanica.Invoke(json.valor.ToString());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
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
            if (PORTSELECCIONAT != null)
                return true;// PORTSELECCIONAT.IsOpen;
            else
                return false;
        }
    }
}
