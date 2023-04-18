using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Categoria
    {
        public Categoria() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public int Activo { get; set; }

        //public Categoria(int id, string nombre, string descripcion, bool activo)
        //{
        //    Id=id;
        //    Nombre=nombre;
        //    Descripcion=descripcion;
        //    Activo=activo;
        //}
    }
}
