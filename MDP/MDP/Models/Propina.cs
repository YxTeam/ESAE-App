using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Propina
    {
        public int id { get; set; }
        public string ano { get; set; }
        public string mes { get; set; }
        public string valor { get; set; }
        public List<Curso> cursos { get; set; }
        public List<Aluno> alunos { get; set; }
    }
}
