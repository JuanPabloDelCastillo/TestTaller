using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.ViewModel;
using TestRazor.Models;

namespace TestRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {



            var gestorVentas = new GestorVentas();
            var ventas = new Venta();
            ventas.Clientes = gestorVentas.ObtenerClientes();
            ventas.Productos = gestorVentas.ObtenerProductos();
            return View(ventas);
        }
    }
    
}