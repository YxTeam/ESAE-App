using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Horario
    {
        public int id { get; set; }
        public string dia { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fim { get; set; }
        public string sala { get; set; }
        public List<Disciplina> disciplinas { get; set; }
    }
}
