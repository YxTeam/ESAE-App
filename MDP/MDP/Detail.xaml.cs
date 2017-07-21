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
    public partial class Detail : ContentPage
    {

        public Detail()
        {
            InitializeComponent();
        }

        private void btnCursos_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new CursoPage());
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new LoginPage());
        }

        private void btnContact_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new ContactosPage());
        }
    }
}