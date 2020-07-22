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
    public partial class PageListaProductos : ContentPage
    {
        public PageListaProductos()
        {
            InitializeComponent();
        }

        //MenuReturnPageButtonClicked
        private async void MenuReturnPageButtonClicked(object sender, EventArgs e)
        {
            await App.GlobalNavigation.PushModalAsync(new PageMenu(), true);
        }
    }
}