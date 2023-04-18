using Modelos;
using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
        public class DAOVenta
    {
        public List<Venta> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT *
                            FROM registrarventa");

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Venta> Lista = new List<Venta>();
                    Venta objVenta = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objVenta = new Venta();
                        objVenta.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objVenta.CodigoBarras = Convert.ToInt32(fila["Codigo"]);
                        objVenta.Descripcion = fila["Descripcion"].ToString();
                        objVenta.IdUsuario = Convert.ToInt32(fila["Idusuario"]);
                        objVenta.fecha = Convert.ToString(fila["fecha"]);
                        objVenta.Precio = Convert.ToInt32(fila["Precio"]);
                        objVenta.Cantidad = Convert.ToInt32(fila["Cantidad"]);

                        Lista.Add(objVenta);
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

        public Venta ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password       
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT *
                            FROM registrarventa WHERE Idproductos=@id");
                    comando.Parameters.AddWithValue("@id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Venta objVenta = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objVenta = new Venta();
                        objVenta.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objVenta.CodigoBarras = Convert.ToInt32(fila["Codigo"]);
                        objVenta.Descripcion = fila["Descripcion"].ToString();
                        objVenta.IdUsuario = Convert.ToInt32(fila["Idusuario"]);
                        objVenta.fecha = Convert.ToString(fila["fecha"]);
                        objVenta.Precio = Convert.ToInt32(fila["Precio"]);
                        objVenta.Cantidad = Convert.ToInt32(fila["Cantidad"]);

                    }

                    return objVenta;
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
                        @"DELETE FROM registrarventa
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

        public bool editar(Venta venta)
        {

            try
            {

                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                         "INSERT INTO registrarventa(codigo, idUsuario, idproducto, descripcion,fecha,precio, cantidad)" +
                         "values(?,?,?,?,?,?,?)");

                    comando.Parameters.AddWithValue("@codigo", venta.CodigoBarras);
                    comando.Parameters.AddWithValue("@idUsuario", venta.IdUsuario);
                    comando.Parameters.AddWithValue("@idproducto", venta.IdProductos);
                    comando.Parameters.AddWithValue("@descripcion", venta.Descripcion);
                    comando.Parameters.AddWithValue("@fecha", venta.fecha);
                    comando.Parameters.AddWithValue("@precio", venta.Precio);
                    comando.Parameters.AddWithValue("@cantidad", venta.Cantidad);

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

        public int agregar(Venta venta)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        "INSERT INTO registrarventa(codigo, idUsuario, idproducto, descripcion,fecha,precio, cantidad)" +
                        "values(?,?,?,?,?,?,?)");

                    comando.Parameters.AddWithValue("@codigo", venta.CodigoBarras);
                    comando.Parameters.AddWithValue("@idUsuario", venta.IdUsuario);
                    comando.Parameters.AddWithValue("@idproducto", venta.IdProductos);
                    comando.Parameters.AddWithValue("@descripcion", venta.Descripcion);
                    comando.Parameters.AddWithValue("@fecha", venta.fecha);
                    comando.Parameters.AddWithValue("@precio", venta.Precio);
                    comando.Parameters.AddWithValue("@cantidad", venta.Cantidad);
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
