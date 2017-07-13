using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            var page1 = new MasterPageItem() { Title = "Inicio", Icon = "ic_home.png", TargetType = typeof(Page4) };
            var page2 = new MasterPageItem() { Title = "Horários", Icon = "ic_date_black.png", TargetType = typeof(AreaAlunos.Horario) };
            var page3 = new MasterPageItem() { Title = "Avisos", Icon = "ic_info_black.png", TargetType = typeof(AreaAlunos.Avisos) };
            var page4 = new MasterPageItem() { Title = "Eventos", Icon = "ic_event_black.png", TargetType = typeof(AreaAlunos.Eventos) };
            var page5 = new MasterPageItem() { Title = "Avaliação", Icon = "ic_school.png", TargetType = typeof(Page3) };
            var page6 = new MasterPageItem() { Title = "Propinas", Icon = "ic_payment.png", TargetType = typeof(Page2) };
            var page7 = new MasterPageItem() { Title = "Documentos", Icon = "ic_description.png", TargetType = typeof(Page) };
            var page8 = new MasterPageItem() { Title = "Contactos", Icon = "ic_contacts_black.png", TargetType = typeof(Page3) };

            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);
            menuList.Add(page8);

            navigationDrawerList.ItemsSource = menuList;
        }

        public void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            
            App.mdp.Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            App.mdp.IsPresented = false;
        }

    }
 
}