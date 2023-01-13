using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Empleado : Persona
    {
        public Empleado(string apellido, string nombre, int dni, int legajo) : base(apellido, nombre, dni)
        {
            Legajo = legajo;

        }
        public int Legajo { get; set; }
        public List<Factura> Facturas { get; set; }
    }
}
