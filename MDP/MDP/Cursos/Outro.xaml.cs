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

namespace MDP.Cursos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Outro : ContentPage
    {
        CursoController cursos;

        public Outro()
        {
            InitializeComponent();

            cursos = new CursoController();
            exemplo.ItemsSource = cursos.getCursosByType("Outro"); //adiciona os objetos à listview em que o tipo é Outro

            exemplo.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null; //faz com que a lista não possa ser selecionada
            };
        }
    }
}