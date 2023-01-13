using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Factura
    {
        public Factura(int nrofactura)
        {
            Nrofactura = nrofactura;
        }
        public int Nrofactura { get; set; }
        public List<DetalleFactura> DetallesFacturas { get; set; }
        public Cliente Cliente { get; set; }
    }

}
