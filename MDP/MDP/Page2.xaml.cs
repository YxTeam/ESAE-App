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

namespace MDP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        AlunoController alunos;

        public Page2()
        {
            InitializeComponent();

            int login = Convert.ToInt32(NumAluno.Text);
            //exemplo.ItemsSource = alunos.getAlunoById(login);
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            int login = Convert.ToInt32(NumAluno.Text);
            Debug.WriteLine(login);
        }
    }
}