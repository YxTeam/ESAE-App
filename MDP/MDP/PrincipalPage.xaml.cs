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
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        private void btnHorario_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new AreaAlunos.Horario());
        }

        private void btnAviso_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new AreaAlunos.Avisos());
        }

        private void btnEvento_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new AreaAlunos.Eventos());
        }
    }
}