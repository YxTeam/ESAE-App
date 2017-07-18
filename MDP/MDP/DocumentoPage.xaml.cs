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
    public partial class DocumentoPage : TabbedPage
    {
        public DocumentoPage ()
        {
            InitializeComponent();

            //this.Children.Add(new Documentos.Boletins());
            //this.Children.Add(new Documentos.Capas());
            //this.Children.Add(new Documentos.Criterios());
            //this.Children.Add(new Documentos.Entregas());
            //this.Children.Add(new Documentos.Estagios());
            //this.Children.Add(new Documentos.Requerimentos());
        }
    }
}