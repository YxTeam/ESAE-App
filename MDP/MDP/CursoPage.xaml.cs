using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursoPage : TabbedPage
    {
        public CursoPage()
        {
            InitializeComponent();

            this.Children.Add(new Cursos.Mestrado()); //adiciona a página à tabpage
            this.Children.Add(new Cursos.PosGraduacao()); //adiciona a página à tabpage
            this.Children.Add(new Cursos.Outro()); //adiciona a página à tabpage
        }
    }
}