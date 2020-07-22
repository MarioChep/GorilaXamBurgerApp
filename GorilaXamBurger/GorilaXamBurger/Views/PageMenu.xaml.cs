using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GorilaXamBurger.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMenu : ContentPage
    {
        public PageMenu()
        {
            InitializeComponent();
        }
        private async void ReturnPageButtonClicked(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushModalAsync(new Home(), true);
        }
        private void IngresoProductoPageButtonClicked(object sender, EventArgs e)
        {
             //Navigation.PushAsync(new NavigationPage(new PageFormularioProducto()));
            Navigation.PushModalAsync(new PageFormularioProducto(),true);
        }
        private void ListaProductoPageButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageListaProductos(),true);
        }
    }
}