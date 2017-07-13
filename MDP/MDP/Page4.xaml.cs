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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void btnhorario_Clicked(object sender, EventArgs e)
        {
            //App.mdp.Detail.Navigation.PushAsync(new AreaAlunos.Horario());
        }
    }
}