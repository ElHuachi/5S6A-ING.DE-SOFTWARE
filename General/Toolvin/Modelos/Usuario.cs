using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Nombre_Usuario { get; set; }
        public String password { get; set; }
        public bool EntradasDinero { get; set; }        
        public bool SalidasDinero { get; set; }
        public bool CancelarCompras { get; set; }
        public bool EliminarArticulos { get; set; }
        public bool GenerarFacturasVentas { get; set; }
        public bool AgregarProveedores { get; set; }
        public bool EditarProveedores { get; set; }
        public bool EliminarProveedores { get; set; }
        public bool GenerarFacturasProveedores { get; set; }
        public bool AgregarProducto { get; set; }
        public bool EditarProducto { get; set; }
        public bool EliminarProducto { get; set; }
        public bool AgregarCategorias { get; set; }
        public bool AgregarClientes { get; set; }
        public bool EditarClientes { get; set; }
        public bool EliminarClientes { get; set; }
        public bool AgregarUsuarios { get; set; }
        public bool EditarUsuarios { get; set; }
        public bool EliminarUsuarios { get; set; }

        public Usuario() { }
        public Usuario(string usuario, string nombreUsuario, string contrasenia, int id)
        {
            Nombre = usuario;
            Nombre_Usuario = nombreUsuario;
            password = contrasenia;
            Id = id;
        }
    }
}
