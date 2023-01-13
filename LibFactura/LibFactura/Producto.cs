using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Producto
    {
        public Producto() { }
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Categoria Categoria { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }



        Producto producto1 = new Producto("PC", 199000);

        Producto producto2 = new Producto("Copa del mundo", 40000);

    }

}
