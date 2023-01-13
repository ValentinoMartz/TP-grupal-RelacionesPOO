using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Categoria
    {
        public Categoria() { }  
        public Categoria(string nombre)
        {
            Nombre = nombre;
            
        }
        public string  Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
