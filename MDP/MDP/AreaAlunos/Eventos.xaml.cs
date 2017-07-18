using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MDP.Controllers;

namespace MDP.AreaAlunos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eventos : ContentPage
    {
        EventoController eventos;

        public Eventos()//EventoController _eventos
        {
            InitializeComponent();

            eventos = new EventoController();
            exemplo.ItemsSource = eventos.ListaEventos; //adiciona os objetos à listview

            exemplo.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}