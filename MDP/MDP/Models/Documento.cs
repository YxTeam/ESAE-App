using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Documento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public string link { get; set; }
        public List<Curso> cursos { get; set; }
    }
}
