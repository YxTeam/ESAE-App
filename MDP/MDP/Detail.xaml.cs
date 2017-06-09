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

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new Page2());
        }

        private void btnContact_Clicked(object sender, EventArgs e)
        {
            App.mdp.Detail.Navigation.PushAsync(new Page3());
        }
    }
}