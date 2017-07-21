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
    public class EstagioController
    {
        private WS servidor; //ligação ao servidor
        public List<Estagio> ListaEstagios; //lista de objetos do model

        public EstagioController()
        {
            servidor = new WS();
            ListaEstagios = JsonConvert.DeserializeObject<List<Estagio>>(servidor.PedidoServidor("http://myesae.x10host.com/api/estagios").ReadLine());
        }
    }
}
