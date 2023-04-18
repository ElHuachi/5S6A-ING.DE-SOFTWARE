using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Proveedores
    {
        //Generar los atributos
        public int id { get; set; }
        public string proveedor { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string descripcion { get; set; }
        public int activo { get; set; }

        //Crear un constructor vacio
        public Proveedores()
        {

        }
    }
}
