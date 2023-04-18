using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace Datos
{
    public class DAOProveedores
    {
        public List<Proveedores> ObtenerTodos()
        {
            try
            {
                //Verificar si fue posible conectarse con la base de datos
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT id, proveedor, correo, telefono, direccion, descripcion, activo FROM Proveedores where activo>0"
                    );
                    //Hacer la conexion
                    comando.Connection = Conexion.conexion;
                    //llenamos una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Proveedores> lista = new List<Proveedores>();
                    Proveedores objProvedores = null;
                    //Obtener los datos de la consulta
                    foreach (DataRow fila in resultado.Rows)
                    {
                        //Crear un objeto de proveedores
                        objProvedores = new Proveedores(); ;
                        objProvedores.id = Convert.ToInt32(fila["id"]);
                        objProvedores.proveedor = fila["proveedor"].ToString();
                        objProvedores.correo = fila["correo"].ToString();
                        objProvedores.telefono = fila["telefono"].ToString();
                        objProvedores.direccion = fila["direccion"].ToString();
                        objProvedores.descripcion = fila["descripcion"].ToString();
                        objProvedores.activo = Convert.ToInt32(fila["activo"]);
                        //Añadir a la lista un objeto con cada uno de los parametros obtenidos
                        lista.Add(objProvedores);
                    }

                    //Retornar la lista
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException)
            {
                throw new Exception("No se pudo obtener la información de los Proveedores");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public Proveedores ObtenerUno(int id)
        {
            try
            {
                //Verificar si fue posible conectarse con la base de datos
                if (Conexion.conectar())
                {
                    //Comando para seleccionar el proveedor que cuenta con el id ingresado
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT *  FROM Proveedores where id=@id;"
                    );

                    comando.Parameters.AddWithValue("@id", id);
                    //Hacer la conexion
                    comando.Connection = Conexion.conexion;

                    //llenamos una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Proveedores> lista = new List<Proveedores>();
                    Proveedores objProvedores = null;

                    //Obtener los datos de la consulta
                    foreach (DataRow fila in resultado.Rows)
                    {
                        //Crear un objeto de proveedores
                        objProvedores = new Proveedores();

                        //Pasar todos los valores ingresados por el usuario de c# a mysql
                        objProvedores.id = Convert.ToInt32(fila["id"]);
                        objProvedores.proveedor = fila["proveedor"].ToString();
                        objProvedores.correo = fila["correo"].ToString();
                        objProvedores.telefono = fila["telefono"].ToString();
                        objProvedores.direccion = fila["direccion"].ToString();
                        objProvedores.descripcion = fila["descripcion"].ToString();
                        objProvedores.activo = Convert.ToInt32(fila["activo"]);
                    }

                    //Retornar la lista
                    return objProvedores;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException)
            {
                throw new Exception("No se pudo obtener la información de los Proveedores");
            }
            finally
            {
                Conexion.desconectar();
            }
        }



        public List<Proveedores> buscar(string cadena)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM proveedores
                        WHERE proveedor LIKE @Cadena;");

                    //Comando para buscar que datos de la columna corresponde al texto ingresado
                    comando.Parameters.AddWithValue("@Cadena", "%" + cadena + "%");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //llenar tabla con los resultados de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Proveedores> lista = new List<Proveedores>();
                    adapter.Fill(resultado);

                    //Crear un objeto de tipo proveedores para pasarle parametros
                    Proveedores objProveedores = new Proveedores();

                    //hacer lectura de cada una una de las columnas de la tabla
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProveedores.id = Convert.ToInt32(fila["id"]);
                        objProveedores.proveedor = fila["proveedor"].ToString();
                        objProveedores.correo = fila["correo"].ToString();
                        objProveedores.telefono = fila["telefono"].ToString();
                        objProveedores.direccion = fila["direccion"].ToString();
                        objProveedores.descripcion = fila["descripcion"].ToString();
                        objProveedores.activo = Convert.ToInt32(fila["activo"]);
                        lista.Add(objProveedores);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException)
            {
                throw new Exception("No se pudo obtener la información del cliente");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public int agregar(Proveedores proveedor)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO proveedores(proveedor, correo, telefono, direccion, descripcion, activo)
                        VALUES(@proveedor, @correo, @telefono, @direccion, @descripcion,1);");

                    comando.Parameters.AddWithValue("@proveedor", proveedor.proveedor);
                    comando.Parameters.AddWithValue("@correo", proveedor.correo);
                    comando.Parameters.AddWithValue("@telefono", proveedor.telefono);
                    comando.Parameters.AddWithValue("@direccion", proveedor.direccion);
                    comando.Parameters.AddWithValue("@descripcion", proveedor.descripcion);

                    comando.Connection = Conexion.conexion;

                    int filasAgregadas = comando.ExecuteNonQuery();

                    return filasAgregadas;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar el registro, fallo en llenado de llaves foráneas");
                }
                else
                {
                    throw new Exception("No se pudo realizar el registro");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }
        public bool eliminar(string id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"DELETE FROM proveedores 
                            WHERE id=@id ");

                    comando.Parameters.AddWithValue("@id", id);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = comando.ExecuteNonQuery();

                    return (filasBorradas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    return true;
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE proveedores
                            SET id=@id, 
                             activo=0
                            WHERE id=@id");


                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@activo", 0);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    int filasEditadas = comando.ExecuteNonQuery();

                    return (filasEditadas > 0);
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool editar(Proveedores proveedor)
        {

            try
            {

                if (Conexion.conectar())
                {

                    MySqlCommand comando = new MySqlCommand(
                        @" UPDATE Proveedores p SET u.proveedor = @Nombre, u.correo= @Correo, u.telefono = @telefono, u.descripcion = @des, , u.direccion = @direccion WHERE u.ID=@id;"); ;
                    comando.Parameters.AddWithValue("@Nombre", proveedor.proveedor);
                    comando.Parameters.AddWithValue("@Correo", proveedor.correo);
                    comando.Parameters.AddWithValue("@telefono", proveedor.telefono);
                    comando.Parameters.AddWithValue("@des", proveedor.descripcion);
                    comando.Parameters.AddWithValue("@direccion", proveedor.direccion);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Ejecutar un comando
                    int filasEditadas = comando.ExecuteNonQuery();

                    return (filasEditadas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452)
                {
                    throw new Exception("No se pudo realizar la edición, el jefe no es válido");
                }
                else if (ex.Number == 1062)
                {
                    throw new Exception("No se pudo realizar la edición, el nombre de usuario ya se encuentra en uso");
                }
                else
                {
                    throw new Exception("No se pudo realizar la edición");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool borradoLogico(String id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Proveedores 
                        SET activo=0
                        WHERE id=@id;");
                    comando.Parameters.AddWithValue("@id", id);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = comando.ExecuteNonQuery();

                    return (filasBorradas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al intentar eliminar el proveedor.");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Proveedores> ObtenerTodosDesactivos()
        {
            try
            {
                //Verificar si fue posible conectarse con la base de datos
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT id, proveedor, correo, telefono, direccion, descripcion, activo FROM Proveedores where activo=0"
                    );
                    //Hacer la conexion
                    comando.Connection = Conexion.conexion;
                    //llenamos una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Proveedores> lista = new List<Proveedores>();
                    Proveedores objProvedores = null;
                    //Obtener los datos de la consulta
                    foreach (DataRow fila in resultado.Rows)
                    {
                        //Crear un objeto de proveedores
                        objProvedores = new Proveedores(); ;
                        objProvedores.id = Convert.ToInt32(fila["id"]);
                        objProvedores.proveedor = fila["proveedor"].ToString();
                        objProvedores.correo = fila["correo"].ToString();
                        objProvedores.telefono = fila["telefono"].ToString();
                        objProvedores.direccion = fila["direccion"].ToString();
                        objProvedores.descripcion = fila["descripcion"].ToString();
                        objProvedores.activo = Convert.ToInt32(fila["activo"]);
                        //Añadir a la lista un objeto con cada uno de los parametros obtenidos
                        lista.Add(objProvedores);
                    }

                    //Retornar la lista
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException)
            {
                throw new Exception("No se pudo obtener la información de los Proveedores");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool activarProveedor(String id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Proveedores 
                        SET activo=1
                        WHERE id=@id;");
                    comando.Parameters.AddWithValue("@id", id);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = comando.ExecuteNonQuery();

                    return (filasBorradas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al intentar activar el proveedor.");
            }
            finally
            {
                Conexion.desconectar();
            }

        }
    }
}
