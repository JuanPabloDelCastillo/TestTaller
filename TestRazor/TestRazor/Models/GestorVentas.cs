using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.Models
{
    public class GestorVentas
    {
        public List<Cliente> ObtenerClientes()
        {
            var cliente1 = new Cliente { Nombre = "Juan Pablo", Apellido = "del Castillo" };
            var cliente2 = new Cliente { Nombre = "Juan", Apellido = "Perez" };
            var cliente3 = new Cliente { Nombre = "Enrique", Apellido = "Ortiz" };

            var listaClientes = new List<Cliente>();
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            return listaClientes;
        }
        public List<Producto> ObtenerProductos()
        {
            var arroz = new Producto { Nombre = "Arroz" };
            var fideos = new Producto { Nombre = "Fideos" };
            var harina = new Producto { Nombre = "Harina" };

            var listaProductos = new List<Producto>();
            listaProductos.Add(arroz);
            listaProductos.Add(fideos);
            listaProductos.Add(harina);

            return listaProductos;
        }
    }
}