﻿using Newtonsoft.Json;
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
	public partial class Avisos : ContentPage
	{
        AvisoController avisos;

        public Avisos()//AvisoController _avisos
        {
			InitializeComponent ();

            avisos = new AvisoController();
            exemplo.ItemsSource = avisos.ListaAvisos; //adiciona os objetos à listview

            exemplo.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null; //faz com que a lista não possa ser selecionada
            };
        }
	}
}