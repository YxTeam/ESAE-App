using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MDP.API;
using MDP.Models;

namespace MDP.Controllers
{
    public class AlunoController
    {
        private WS servidor; //ligação ao servidor
        public List<Aluno> ListaAlunos; //lista de objetos do model

        public AlunoController()
        {
            servidor = new WS();
            ListaAlunos = JsonConvert.DeserializeObject<List<Aluno>>(servidor.PedidoServidor("http://myesae.x10host.com/api/alunos").ReadLine());
        }

        public List<Aluno> getAlunoById(int _id)
        {
            List<Aluno> temp = new List<Aluno>();
            foreach (Aluno aluno in ListaAlunos)
            {
                if (aluno.id == _id)
                    temp.Add(aluno);
            }
            return temp;
        }
    }
}
