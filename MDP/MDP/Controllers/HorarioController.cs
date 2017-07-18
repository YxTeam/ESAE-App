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
    public class HorarioController
    {
        private WS servidor; //ligação ao servidor
        public List<Horario> ListaHorarios; //lista de objetos do model

        public HorarioController()
        {
            servidor = new WS();
            ListaHorarios = JsonConvert.DeserializeObject<List<Horario>>(servidor.PedidoServidor("http://myesae.x10host.com/api/horarios").ReadLine());
        }
    }
}
