using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetallesVenta
    {
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public double PrecioUnitario { get; set; }
        public double Cantidad { get; set; }
        public bool Activo { get; set; }

        public DetallesVenta() { }
    }
}
