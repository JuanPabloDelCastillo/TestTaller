using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Models.AccesoDatos;

namespace TestRazor.Models
{
    public class GestorVentas
    {
        RepositorioVentas repo = new RepositorioVentas();

        public void Guardar(Venta venta)
        {
            repo.Guardar(venta);
        }

        public List<Venta> Listar()
        {
            return repo.Listar();
        }
    }
}