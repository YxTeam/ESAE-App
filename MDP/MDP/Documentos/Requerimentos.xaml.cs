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
using System.Diagnostics;

namespace MDP.Documentos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Requerimentos : ContentPage
	{
        DocumentoController documentos;

        public Requerimentos ()
		{
			InitializeComponent ();

            documentos = new DocumentoController();
            exemplo.ItemsSource = documentos.getCursosByType("Requerimentos");
        }
	}
}