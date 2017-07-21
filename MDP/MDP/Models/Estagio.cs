using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Estagio
    {
        public int id { get; set; }
        public string empresa { get; set; }
        public string area { get; set; }
        public int n_horas { get; set; }
        public string local { get; set; }
        public int contacto { get; set; }
        public List<Curso> cursos { get; set; }
    }
}
