using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Disciplina
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int tipo { get; set; }
        public int etcs { get; set; }
        public List<Curso> cursos { get; set; }
        public List<Aluno> alunos { get; set; }
        public List<Aviso> avisos { get; set; }
        public List<Evento> eventos { get; set; }
        public List<Horario> horarios { get; set; }
    }
}
