using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Cliente:Persona
    {
        public Cliente(string apellido, string nombre, int dni, int nroCliente) : base(apellido, nombre, dni)
        {
            NroCliente = nroCliente;

        }
        public int NroCliente { get; set; }
    }
}
