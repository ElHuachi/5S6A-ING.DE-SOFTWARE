using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Productos
    {
        public int IdProductos { get; set; }
        public string CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public bool VentaPorUnidad { get; set; }
        public bool VentaAGranel { get; set; }
        public bool VentaPorPaquete { get; set; }
        public double PrecioCosto { get; set; }
        public double Ganancia { get; set; }
        public double PrecioVenta { get; set; }
        public int categorias { get; set; }
        public double Cantidad { get; set; }
        public int CantidadComprada { get; set; }
        public double TotalCompra { get { return Math.Round(PrecioVenta*CantidadComprada, 2); } }
        public string NombreCategoria { get; set; }
        public int Activo { get; set; }

        public Productos() { }

    }
}
