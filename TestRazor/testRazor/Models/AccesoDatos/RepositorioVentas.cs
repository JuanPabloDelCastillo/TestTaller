using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.Models.AccesoDatos
{
    public class RepositorioVentas
    {
        TallerDB tallerDb = new TallerDB();

        public void Guardar(Venta venta)
        {
            tallerDb.Venta.Add(venta);
            tallerDb.SaveChanges();
        }

        public List<Venta> Listar()
        {
            return tallerDb.Venta.ToList();
        }
    }
}