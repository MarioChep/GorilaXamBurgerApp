using System;
using System.Collections.Generic;
using System.Text;
using GorilaXamBurger.Services;
using Refit;

namespace GorilaXamBurger.ViewModels
{
    public class ProductoViewModels
    {
        public ProductoViewModels()
        {
            GetResponse();
        }

        async void GetResponse()
        {
            var apiResponse = RestService.For<IProductoApi>("http://gorilaapi.azurewebsites.net");
            var response = await apiResponse.GetProductos();
        }

    }
}
