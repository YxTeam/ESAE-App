using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Evento
    {
        public int id { get; set; }
        public string dia { get; set; }
        public string hora { get; set; }
        public string local { get; set; }
        public string assunto { get; set; }
        public string descricao { get; set; }
    }
}
