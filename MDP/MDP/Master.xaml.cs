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
    public partial class Master : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public Master()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(Page2)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "todo.png",
                TargetType = typeof(Page1)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(Page)
            });

            listView.ItemsSource = masterPageItems;

        }

        private void btnPage1_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Page1());
        }

        private void btnPage2_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Page2());
        }
    }
}