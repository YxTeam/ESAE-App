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
	public partial class Propinas : ContentPage
	{
        PropinaController propinas;

        public Propinas ()
		{
			InitializeComponent ();

            propinas = new PropinaController();
            exemplo.ItemsSource = propinas.ListaPropinas; //adiciona os objetos à listview

            exemplo.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
        }
	}
}