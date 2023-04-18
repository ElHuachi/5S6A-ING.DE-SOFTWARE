using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class OrdenPorCliente
    {
        public int IdCliente { get; set; }
        public string NombreCliete { get; set; }
        public int Compras { get; set; }
        public double Monto { get; set; }

        public OrdenPorCliente() { }
    }
}
