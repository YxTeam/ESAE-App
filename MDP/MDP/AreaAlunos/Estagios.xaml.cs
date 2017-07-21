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
    public partial class Estagios : ContentPage
    {
        EstagioController estagios;

        public Estagios()
        {
            InitializeComponent();

            estagios = new EstagioController();
            exemplo.ItemsSource = estagios.ListaEstagios; //adiciona os objetos à listview

            exemplo.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null; //faz com que a lista não possa ser selecionada
            };
        }
    }
}