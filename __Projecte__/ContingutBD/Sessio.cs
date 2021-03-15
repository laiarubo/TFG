using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContingutBD
{
    public class Sessio
    {
        public int id { get; set; }
        public string data { get; set; }
        public string horaInici { get; set; }
        public string horaFinal { get; set; }
        public int Pacient_id { get; set; }
        public int Terapeuta_id { get; set; }
        public int Cardiograma_id { get; set; }
        public int Miograma_id { get; set; }
        public int RespostaGalvanica_id { get; set; }
    }
}
