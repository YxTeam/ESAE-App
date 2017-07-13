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
    public class EventoController
    {
        private WS servidor; //ligação ao servidor
        public List<Evento> ListaEventos; //lista de objetos do model

        public EventoController()
        {
            servidor = new WS();
            ListaEventos = JsonConvert.DeserializeObject<List<Evento>>(servidor.PedidoServidor("http://10.0.2.2/esae/public/api/eventos").ReadLine());
        }
    }
}
