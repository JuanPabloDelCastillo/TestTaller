using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Models;

namespace TestRazor.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult AltaCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(string nombre, string apellido)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            return View();
        }

    }
}