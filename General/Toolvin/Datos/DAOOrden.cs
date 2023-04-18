using Modelos;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOOrden
    {
        /// <summary>
        /// Obtener todos los registros activos de la tabla "Productos" por medio de un comando SQL
        /// </summary>
        /// <returns>Lista de productos con todos los resultados de la ejecución de la consulta</returns>
        /// <exception cref="Exception"></exception>
        public List<Productos> ObtenerActivos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"select * from productos where activo =1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Productos> lista = new List<Productos>();
                    Productos objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProducto = new Productos()
                        {
                            //IdProductos = Convert.ToInt32(fila["Idproductos"]),
                            Descripcion = fila["Descripcion"].ToString(),
                            CodigoBarras = fila["Codigo"].ToString(),
                            VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]),
                            VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]),
                            VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]),
                            PrecioVenta = Convert.ToDouble(fila["PrecioVenta"]),
                            PrecioCosto = Convert.ToDouble(fila["PrecioCosto"]),
                            Ganancia = Convert.ToInt32(fila["Ganancia"]),
                            categorias = Convert.ToInt32(fila["Categoria"])
                        };
                        lista.Add(objProducto);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Obtener todos los registros activos de la tabla "Ventas" por medio de un comando SQL
        /// </summary>
        /// <returns>Lista de ventas con todos los resultados de la ejecución de la consulta</returns>
        /// <exception cref="Exception"></exception>
        public List<Ventas> ObtenerTodas()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Ventas 
                        WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Ventas> lista = new List<Ventas>();
                    Ventas objOrden = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objOrden = new Ventas()
                        {
                            IdCliente = Convert.ToInt32(fila["IdCliente"]),
                            IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                            Fecha = (DateTime)fila["Fecha"],
                            Iva = Convert.ToDouble(fila["Iva"]),
                            Subtotal = Convert.ToDouble(fila["Sutotal"]),
                            Total = Convert.ToDouble(fila["Total"]),
                            Activo = Convert.ToBoolean(fila["Activo"])
                        };
                        lista.Add(objOrden);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Obtener todos los registros activos de la tabla "Detalles_Venta" por medio de un comando SQL
        /// </summary>
        /// <returns>Lista de detalles de venta con todos los resultados de la ejecución de la consulta</returns>
        /// <exception cref="Exception"></exception>
        public List<DetallesVenta> ObtenerDetalles()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Detalles_Venta 
                        WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<DetallesVenta> lista = new List<DetallesVenta>();
                    DetallesVenta objDetalle = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objDetalle = new DetallesVenta()
                        {
                            IdOrden = Convert.ToInt32(fila["IdOrden"]),
                            IdProducto = Convert.ToInt32(fila["IdProducto"]),
                            PrecioUnitario = Convert.ToDouble(fila["PrecioUnitario"]),
                            Cantidad = Convert.ToDouble(fila["Cantidad"]),
                            Activo = Convert.ToBoolean(fila["Activo"])
                        };
                        lista.Add(objDetalle);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Agregar un registro a la tabla "Ventas" y agregar tantos registros como objetos de tipo producto
        /// contenidos en el parámetro lista a la tabla "Detalles_Venta"
        /// por medio de una transacción
        /// </summary>
        /// <param name="orden">Objeto de tipo ventas con la información a aceptar</param>
        /// <param name="lista">Lista de objetos de tipo Producto a insertar</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int agregarDetalle(Ventas orden, List<Productos> lista)
        {
            
            try
            {
                if (Conexion.conectar())
                {
                    //Iniciar una transacción
                    Conexion.transaccion = Conexion.conexion.BeginTransaction();
                    try
                    {

                        MySqlCommand agregarOrden = new MySqlCommand();
                        agregarOrden.Connection = Conexion.conexion;
                        agregarOrden.CommandText =
                            @"INSERT INTO Ventas(idCliente, idUsuario, Fecha, Iva, Sutotal, Total, Activo)
                        VALUES(@idCliente,@idUsuario,@Fecha,@Iva,@Subtotal,@Total,1);
                        SELECT last_insert_id();";

                        agregarOrden.Parameters.AddWithValue("@idCliente", orden.IdCliente);
                        agregarOrden.Parameters.AddWithValue("@idUsuario", orden.IdUsuario);
                        agregarOrden.Parameters.AddWithValue("@Fecha", orden.Fecha);
                        agregarOrden.Parameters.AddWithValue("@Iva", orden.Iva);
                        agregarOrden.Parameters.AddWithValue("@Subtotal", orden.Subtotal);
                        agregarOrden.Parameters.AddWithValue("@Total", orden.Total);
                        //agregarOrden.Parameters.AddWithValue("@Activo", orden.Activo);

                        int ultimoId = Convert.ToInt32(agregarOrden.ExecuteScalar());

                        MySqlCommand agregarDetalle = new MySqlCommand();
                        agregarDetalle.Connection = Conexion.conexion;
                        agregarDetalle.CommandText =
                            @"INSERT INTO Detalles_Venta
                        VALUES(@idOrden,@codigo,@precioUnitario,@cantidad);";

                        foreach (Productos producto in lista)
                        {
                            agregarDetalle.Parameters.Clear();
                            agregarDetalle.Parameters.AddWithValue("@idOrden", ultimoId);
                            //agregarDetalle.Parameters.AddWithValue("@idProducto", producto.IdProductos);
                            agregarDetalle.Parameters.AddWithValue("@codigo", producto.CodigoBarras);
                            agregarDetalle.Parameters.AddWithValue("@precioUnitario", producto.PrecioVenta);
                            agregarDetalle.Parameters.AddWithValue("@cantidad", producto.CantidadComprada);
                            agregarDetalle.ExecuteNonQuery();
                        }

                        Conexion.transaccion.Commit();
                        return ultimoId;
                    }
                    catch {
                        Conexion.transaccion.Rollback();
                        return 0;
                    }                                        
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
                    Conexion.transaccion.Rollback();
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

        /// <summary>
        /// Obtener todos los registros activos de la tabla "Ventas" en los que el apartado de fecha
        /// coicida con los intervalos recibidos como parámetros por medio de un comando SQL
        /// </summary>
        /// <param name="inicio">Comienzo del intervalo de búsqueda de fecha</param>
        /// <param name="fin">Final del intervalo de búsqueda de fecha</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<OrdenPorCliente> FiltrarPorClientes(string inicio, string fin)
        {
            try
            {
                if (Conexion.conectar())
                {

                    MySqlCommand comando = new MySqlCommand(
                      @"select distinct c.id as idcliente, c.nombre as nombrecliente,
                        (select count(*) from ventas v where v.idcliente=c.id) as compras,
                        (select sum(v.total) from ventas v where v.idcliente=c.id)as monto
                        from clientes c join ventas v on v.idcliente=c.id
                        where v.fecha between @Inicio and @Fin;");

                    comando.Parameters.AddWithValue("@Inicio", inicio);
                    comando.Parameters.AddWithValue("@Fin", fin);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<OrdenPorCliente> lista = new List<OrdenPorCliente>();
                    OrdenPorCliente objOrden = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objOrden = new OrdenPorCliente()
                        {
                            IdCliente = Convert.ToInt32(fila["IdCliente"]),
                            NombreCliete = fila["NombreCliente"].ToString(),
                            Compras= Convert.ToInt32(fila["Compras"]),
                            Monto = Convert.ToDouble(fila["Monto"]),
                            //Cliente = fila["Cliente"].ToString(),
                            //Empleado = fila["Empleado"].ToString()
                        };
                        lista.Add(objOrden);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Obtener todos los registros activos de la tabla "Ventas" en los que el apartado de fecha
        /// coicida con los intervalos recibidos como parámetros por medio de un comando SQL
        /// </summary>
        /// <param name="inicio">Comienzo del intervalo de búsqueda de fecha</param>
        /// <param name="fin">Final del intervalo de búsqueda de fecha</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Ventas> BuscarPorFecha(string inicio, string fin)
        {
            try
            {
                if (Conexion.conectar())
                {

                    MySqlCommand comando = new MySqlCommand(
                      @"select distinct c.id as idcliente, c.nombre as nombrecliente,
                        (select count(*) from ventas v where v.idcliente=c.id) as compras,
                        (select sum(v.total) from ventas v where v.idcliente=c.id)as monto
                        from clientes c join ventas v on v.idcliente=c.id
                        where v.fecha between @Inicio and @Fin;");

                    comando.Parameters.AddWithValue("@Inicio", inicio);
                    comando.Parameters.AddWithValue("@Fin", fin);

                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Ventas> lista = new List<Ventas>();
                    Ventas objOrden = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objOrden = new Ventas()
                        {
                            IdCliente = Convert.ToInt32(fila["IdCliente"]),
                            IdUsuario = Convert.ToInt32(fila["idUsuario"]),
                            Fecha= (DateTime)fila["Fecha"],
                            Iva = Convert.ToDouble(fila["Iva"]),
                            Subtotal = Convert.ToDouble(fila["Sutotal"]),
                            Total = Convert.ToDouble(fila["Total"]),
                            Cliente = fila["Cliente"].ToString(),
                            Usuario = fila["Usuario"].ToString()
                        };
                        lista.Add(objOrden);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las ordenes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
