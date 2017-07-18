using MDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDP.AreaAlunos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Notas : ContentPage
	{
        public List<Nota> notaList { get; set; }

        public Notas ()
		{
			InitializeComponent ();

            notaList = new List<Nota>();

            var nota1 = new Nota() { disciplina = "Produção Video", nota = 18, avaliacao = "Aprovado" };
            var nota2 = new Nota() { disciplina = "Produção Audio", nota = 8, avaliacao = "Reprovado" };
            var nota3 = new Nota() { disciplina = "Programação", nota = 10, avaliacao = "Aprovado" };

            notaList.Add(nota1);
            notaList.Add(nota2);
            notaList.Add(nota3);

            exemplo.ItemsSource = notaList;

            exemplo.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
        }
	}
}