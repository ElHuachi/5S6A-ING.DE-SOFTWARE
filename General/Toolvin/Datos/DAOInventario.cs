using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOInventario
    {
        public List<Inventario> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT *
                            FROM inventario");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Inventario> Lista = new List<Inventario>();
                    Inventario objInventario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objInventario = new Inventario();
                        objInventario.IdProducto = Convert.ToInt32(fila["Idproductos"]);
                        objInventario.CodigoBarras = Convert.ToInt32(fila["Codigo"]);
                        objInventario.Descripcion = fila["Descripcion"].ToString();
                        objInventario.Entrada = Convert.ToInt32(fila["Entrada"]);
                        objInventario.Salida = Convert.ToInt32(fila["Salida"]);
                        objInventario.Stock = Convert.ToInt32(fila["Stock"]);

                        Lista.Add(objInventario);
                    }

                    return Lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public Inventario ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password       
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT *
                            FROM inventario WHERE Idproductos=@id");
                    comando.Parameters.AddWithValue("@id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Inventario objInventario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objInventario = new Inventario();
                        objInventario.IdProducto = Convert.ToInt32(fila["Idproductos"]);
                        objInventario.CodigoBarras = Convert.ToInt32(fila["Codigo"]);
                        objInventario.Descripcion = fila["Descripcion"].ToString();
                        objInventario.Entrada = Convert.ToInt32(fila["Entrada"]);
                        objInventario.Salida = Convert.ToInt32(fila["Salida"]);
                        objInventario.Stock = Convert.ToInt32(fila["Stock"]);

                    }

                    return objInventario;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del usuario");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @"DELETE FROM inventario
                        WHERE IdProductos=@id");

                    comando.Parameters.AddWithValue("@id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
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
                if (ex.Number == 1452)
                {
                    throw new Exception("No se puede eliminar el usuario porque tiene otros procesos relacionados (ventas, es supervisor de al menos un empleado o aún está asignado a una zona)");
                }
                else
                {
                    throw new Exception("Error al intentar eliminar al usuario");
                }

            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool editar(Inventario inventario)
        {

            try
            {

                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                         "INSERT INTO registrarventa(codigo, idproducto,descripcion,entrada ,salida, stock)" +
                         "values(?,?,?,?,?,?)");

                    comando.Parameters.AddWithValue("@codigo", inventario.CodigoBarras);
                    comando.Parameters.AddWithValue("@idproducto", inventario.IdProducto);
                    comando.Parameters.AddWithValue("@descripcion", inventario.Descripcion);
                    comando.Parameters.AddWithValue("@entrada", inventario.Entrada);
                    comando.Parameters.AddWithValue("@salida", inventario.Salida);
                    comando.Parameters.AddWithValue("@stock", inventario.Stock);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

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
                    throw new Exception("No se pudo realizar la edición, el id de venta no es válido");
                }
                else if (ex.Number == 1062)
                {
                    throw new Exception("No se pudo realizar la edición, el id de usuario ya se encuentra en uso");
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

        public int agregar(Inventario inventario)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                         "INSERT INTO registrarventa(codigo, idproducto,descripcion,entrada ,salida, stock)" +
                         "values(?,?,?,?,?,?)");

                    comando.Parameters.AddWithValue("@codigo", inventario.CodigoBarras);
                    comando.Parameters.AddWithValue("@idproducto", inventario.IdProducto);
                    comando.Parameters.AddWithValue("@descripcion", inventario.Descripcion);
                    comando.Parameters.AddWithValue("@entrada", inventario.Entrada);
                    comando.Parameters.AddWithValue("@salida", inventario.Salida);
                    comando.Parameters.AddWithValue("@stock", inventario.Stock);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    int filasAgregadas = Convert.ToInt32(comando.ExecuteScalar());

                    return filasAgregadas;
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
                    throw new Exception("No se pudo realizar el registro, el id venta no es válido");
                }
                else if (ex.Number == 1062)
                {
                    throw new Exception("No se pudo realizar el registro, el id de usuario ya se encuentra en uso");
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
    }
}
