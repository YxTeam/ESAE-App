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
    public class PropinaController
    {
        private WS servidor; //ligação ao servidor
        public List<Propina> ListaPropinas; //lista de objetos do model

        public PropinaController()
        {
            servidor = new WS();
            ListaPropinas = JsonConvert.DeserializeObject<List<Propina>>(servidor.PedidoServidor("http://myesae.x10host.com/api/propinas").ReadLine());
        }
    }
}
