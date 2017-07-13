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

namespace MDP.Controller
{
    public class CursoController
    {
        private WS servidor; //ligação ao servidor
        public List<Curso> ListaCursos; //lista de objetos do model

        public CursoController()
        {
            servidor = new WS();
            ListaCursos = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://10.0.2.2/esae/public/api/cursos").ReadLine());
        }

        public List<Curso> getCursosByType(string _tipo)
        {
            List<Curso> temp = new List<Curso>();
            foreach (Curso curso in ListaCursos)
            {
                if (curso.tipo == _tipo)
                    temp.Add(curso);
            }
            return temp;
        }
    }
}
