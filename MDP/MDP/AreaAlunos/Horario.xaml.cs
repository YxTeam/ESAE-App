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
using System.Diagnostics;

namespace MDP.AreaAlunos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horario : ContentPage
    {
        HorarioController horarios;

        public Horario()//HorarioController _horarios
        {
            InitializeComponent();

            horarios = new HorarioController();
            exemplo.ItemsSource = horarios.ListaHorarios; //adiciona os objetos à listview
        }
    }
}