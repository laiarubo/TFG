using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContingutBD
{
    public class Apunts
    {
        public int id { get; set; }
        public string dataHora { get; set; }
        public string text { get; set; }
        public int Sessio_id { get; set; }
        public string Sessio_data { get; set; }
    }
}
