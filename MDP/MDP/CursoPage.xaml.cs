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

            this.Children.Add(new Cursos.Mestrado());
            this.Children.Add(new Cursos.PosGraduacao());
        }
    }
}