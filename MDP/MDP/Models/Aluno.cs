using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int cartao_cidadao { get; set; }
        public string nacionalidade { get; set; }
        public string morada { get; set; }
        public int telemovel { get; set; }
        public string email { get; set; }
        public List<Curso> cursos { get; set; }
        public List<Disciplina> disciplinas { get; set; }
    }
}
