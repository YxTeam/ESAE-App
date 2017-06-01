using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDP
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Master = new Master();
            Detail = new NavigationPage(new Detail()) { 
                BarBackgroundColor = Color.FromHex("#006660"),
                BarTextColor = Color.White

            };

            App.mdp = this;
        }
    }
}
