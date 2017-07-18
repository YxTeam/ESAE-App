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
        public List<Aluno> alunos { get; set; }
        public List<Disciplina> disciplinas { get; set; }
        public List<Aviso> avisos { get; set; }
        public List<Evento> eventos { get; set; }
    }
}
