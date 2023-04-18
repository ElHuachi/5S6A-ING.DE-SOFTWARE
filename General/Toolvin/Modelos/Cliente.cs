using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CP { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public Cliente() { }
        public Cliente(int id, string nombre, string direccion, string colonia, string municipio, string estado, string cP, string telefono, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Colonia = colonia;
            Municipio = municipio;
            Estado = estado;
            CP = cP;
            Telefono = telefono;
            Activo = activo;
        }
    }
}
