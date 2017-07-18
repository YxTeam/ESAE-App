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
    public class AvisoController
    {
        private WS servidor; //ligação ao servidor
        public List<Aviso> ListaAvisos; //lista de objetos do model

        public AvisoController()
        {
            servidor = new WS();
            ListaAvisos = JsonConvert.DeserializeObject<List<Aviso>>(servidor.PedidoServidor("http://myesae.x10host.com/api/avisos").ReadLine());
        }

        public List<Aviso> getAvisosById(int _id)
        {
            List<Aviso> temp = new List<Aviso>();
            foreach(Aviso aviso in ListaAvisos)
            {
                if (aviso.id == _id)
                    temp.Add(aviso);
            }
            return temp;
        }
    }
}
