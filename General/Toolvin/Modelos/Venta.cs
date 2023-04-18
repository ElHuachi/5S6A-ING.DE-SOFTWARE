using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
        public class Venta
    {
        public int IdUsuario { get; set; }
        public int IdProductos { get; set; }
        public int CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string fecha { get; set; }
        public int Cantidad { get; set; }

        public Venta() { }
    }
}
