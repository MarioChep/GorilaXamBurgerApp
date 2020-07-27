using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GorilaXamBurger.Models;

namespace GorilaXamBurger.Services
{
    public interface IProductoApi
    {
        [Get("/api/v1/GorilaXamDemoApi/Productos/")]
        Task<List<Producto>> GetProductos();

    }
}
