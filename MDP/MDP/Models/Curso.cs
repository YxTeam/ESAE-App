using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Curso
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int anos { get; set; }
        public string coordenador { get; set; }
        public string tipo { get; set; }
    }
}
