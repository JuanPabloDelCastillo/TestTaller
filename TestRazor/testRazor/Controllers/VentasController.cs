using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Models;

namespace TestRazor.Controllers
{
    public class VentasController : Controller
    {
        GestorVentas gestorVentas = new GestorVentas();

        public ActionResult Listar()
        {
            var ventas = gestorVentas.Listar();
            return View(ventas);
        }


        public ActionResult Alta()
        {
            return View();
        }

        public ActionResult Guardar(Venta venta)
        {
            gestorVentas.Guardar(venta);
            return RedirectToAction("Listar");
        }
    }

}