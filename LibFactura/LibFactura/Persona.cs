using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public abstract class Persona

    {
        public Persona(string apellido, string nombre, int dni)
        {
            Apellido = apellido;
            Nombre = nombre;
            Dni = dni;

        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }

    }

}
