using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Inventario
    {
        public int IdProducto { get; set; }
        public int CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public double Entrada { get; set; }
        public double Salida { get; set; }
        public int Stock { get; set; }

        public Inventario() { }
    }
}
