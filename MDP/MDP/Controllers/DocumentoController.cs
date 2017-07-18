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
    public class DocumentoController
    {
        private WS servidor; //ligação ao servidor
        public List<Documento> ListaDocumentos; //lista de objetos do model

        public DocumentoController()
        {
            servidor = new WS();
            ListaDocumentos = JsonConvert.DeserializeObject<List<Documento>>(servidor.PedidoServidor("http://myesae.x10host.com/api/documentos").ReadLine());
        }

        public List<Documento> getCursosByType(string _categoria)
        {
            List<Documento> temp = new List<Documento>();
            foreach (Documento documento in ListaDocumentos)
            {
                if (documento.categoria == _categoria)
                    temp.Add(documento);
            }
            return temp;
        }
    }
}
