using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Ventas
    {
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }
        public string Cliente { get; set; }
        public string Usuario { get; set; }

        public Ventas() { }
    }
}
