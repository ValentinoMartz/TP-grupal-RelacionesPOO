using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class DetalleFactura
    {
        public DetalleFactura(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
    }



}
