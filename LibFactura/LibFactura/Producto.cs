using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set;}
        public Categoria Categoria { get; set; }
    }
}
