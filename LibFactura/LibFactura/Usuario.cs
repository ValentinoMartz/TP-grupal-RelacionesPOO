using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Usuario
    {
        public Usuario(int id) { 
            Id = id;
        }

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
    }
}
