using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;
        public static MySqlTransaction transaccion;
        static string usuario = "root";
        static string password = "root";
        static string bd = "sistematienda";
        static string servidor = "localhost";
        static string puerto = "3306";

        /// <summary>
        /// Realizar conexión a base de datos local
        /// </summary>
        /// <returns>true: se conecto sin problemas, false: no se pudo conectar</returns>
        public static bool conectar()
        {
            try
            {
                conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor + ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Terminar la conexión estblecida
        /// </summary>
        public static void desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception)
            { 
            
            }
        }
    }
}
