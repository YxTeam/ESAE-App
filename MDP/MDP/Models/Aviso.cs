using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Models
{
    public class Aviso
    {
        public int id { get; set; }
        public string assunto { get; set; }
        public string descricao { get; set; }
        public List<Disciplina> disciplinas { get; set; }
        public List<Curso> cursos { get; set; }
    }
}
