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
        public List<MasterPageItem> menuList { get; set; }

        public Master()
        {
            InitializeComponent();

            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "Item 1", Icon = "contacts.png", TargetType = typeof(Page) };
            var page2 = new MasterPageItem() { Title = "Item 2", Icon = "todo.png", TargetType = typeof(Page1) };
            var page3 = new MasterPageItem() { Title = "Item 3", Icon = "reminders.png", TargetType = typeof(Page2) };
            var page4 = new MasterPageItem() { Title = "Item 4", Icon = "contacts.png", TargetType = typeof(Page) };
            var page5 = new MasterPageItem() { Title = "Item 5", Icon = "todo.png", TargetType = typeof(Page1) };
            var page6 = new MasterPageItem() { Title = "Item 6", Icon = "reminders.png", TargetType = typeof(Page2) };
            var page7 = new MasterPageItem() { Title = "Item 7", Icon = "contacts.png", TargetType = typeof(Page) };
            var page8 = new MasterPageItem() { Title = "Item 8", Icon = "todo.png", TargetType = typeof(Page1) };
            var page9 = new MasterPageItem() { Title = "Item 9", Icon = "reminders.png", TargetType = typeof(Page2) };

            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);
            menuList.Add(page8);
            menuList.Add(page9);

            navigationDrawerList.ItemsSource = menuList;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            App.mdp.Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            //Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            App.mdp.IsPresented = false;
        }

    }
 
}