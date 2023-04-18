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
    public class DAOProductos
    {
        /// <summary>
        /// Obtener todos los registros activos de la tabla "Productos" por medio de un comando SQL
        /// </summary>
        /// <returns>Lista de productos con todos los resultados de la ejecución de la consulta</returns>
        /// <exception cref="Exception"></exception>
        public List<Productos> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT p.*, c.nombre as NombreCategoria
                            FROM Productos p JOIN Categorias c ON c.id=p.categoria where p.activo=1;");

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
                        objProducto = new Productos();
                        //objProducto.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objProducto.CodigoBarras = fila["Codigo"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]);
                        objProducto.VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]);
                        objProducto.VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]);
                        objProducto.PrecioCosto = Convert.ToInt32(fila["PrecioCosto"]);
                        objProducto.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
                        objProducto.Ganancia = Convert.ToInt32(fila["Ganancia"]);
                        objProducto.categorias = Convert.ToInt32(fila["Categoria"]);
                        objProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                        objProducto.NombreCategoria = fila["NombreCategoria"].ToString();
                        objProducto.Activo = Convert.ToInt32(fila["Activo"]);

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
                throw new Exception("No se pudo obtener la información de los productos");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Obtener el registro de la tabla "Productos" del que el ID cocuerde con el parámetro recibido
        /// siempre y cuándo este activo,todo esto por medio de un comando SQL
        /// </summary>
        /// <param name="id">Id a buscar en la tabla "Productos"</param>
        /// <returns>Objeto de tipo Producto en el que su Id coincide con elparámetro recibido</returns>
        /// <exception cref="Exception"></exception>
        public Productos ObtenerUno(string id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password       
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT Codigo,Descripcion,VentaPorUnidad,VentaAGranel,VentaporPaquete, 
                            PrecioCosto,Ganancia,
                            PrecioVenta,Categoria, Cantidad
                            FROM Productos WHERE codigo=@id");
                    comando.Parameters.AddWithValue("@id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Productos objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objProducto = new Productos();
                        //objProducto.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objProducto.CodigoBarras = fila["Codigo"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]);
                        objProducto.VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]);
                        objProducto.VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]);
                        objProducto.PrecioCosto = Convert.ToInt32(fila["PrecioCosto"]);
                        objProducto.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
                        objProducto.categorias = Convert.ToInt32(fila["Categoria"]);
                        objProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);

                    }

                    return objProducto;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                Conexion.desconectar();
            }
        }


        /// <summary>
        /// Elimina un registro de la tabla "Productos" por medio de un comando SQL
        /// </summary>
        /// <param name="id">Id del registro a eliminar</param>
        /// <returns>true: se realizó la eliminación exitosamente, false: no se realizó la eliminación</returns>
        /// <exception cref="Exception"></exception>
        public bool eliminar(string id)
        { 
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @"DELETE FROM productos
                        WHERE codigo=@codigo");

                    comando.Parameters.AddWithValue("@codigo", id);
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
                if (ex.Number != 1451)
                {
                    throw new Exception("No se puede eliminar el producto)");
                }
                else
                {
                    

                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE productos
                            SET Codigo=@codigo, 
                             activo=0
                            WHERE Codigo=@codigo");


                    comando.Parameters.AddWithValue("@codigo", id);
                    comando.Parameters.AddWithValue("@activo",0);
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

        /// <summary>
        /// Editar un registro ya existente en la tabla "Productos" por medio de un comando SQL
        /// </summary>
        /// <param name="productos">Objeto de tipo "Producto" a editar</param>
        /// <returns>true: se realizó la edició exitosamente, false: no se realizó la edición</returns>
        /// <exception cref="Exception"></exception>
        public bool editar(Productos productos)
        {

            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE productos
                            SET Codigo=@codigo, 
                            Descripcion=@descripcion,VentaPorUnidad=@ventaporunidad,VentaAGranel=@ventaagranel,
                            VentaPorpaquete=@ventaporpaquete,PrecioCosto=@preciocosto,
                            Ganancia=@ganancia, PrecioVenta = @precioventa, Categoria=@categoria, Cantidad = @cantidad, activo=@activo
                            WHERE Codigo=@codigo");

                    comando.Parameters.AddWithValue("@codigo", productos.CodigoBarras);
                    comando.Parameters.AddWithValue("@descripcion", productos.Descripcion);
                    comando.Parameters.AddWithValue("@ventaporunidad", productos.VentaPorUnidad);
                    comando.Parameters.AddWithValue("@ventaagranel", productos.VentaAGranel);
                    comando.Parameters.AddWithValue("@ventaporpaquete", productos.VentaPorPaquete);
                    comando.Parameters.AddWithValue("@preciocosto", productos.PrecioCosto);
                    comando.Parameters.AddWithValue("@ganancia", productos.Ganancia);
                    comando.Parameters.AddWithValue("@precioventa", productos.PrecioVenta);
                    comando.Parameters.AddWithValue("@categoria", productos.categorias);
                    //comando.Parameters.AddWithValue("@id", productos.IdProductos);
                    comando.Parameters.AddWithValue("@cantidad", productos.Cantidad);
                    comando.Parameters.AddWithValue("@activo",productos.Activo);

                    //comando.Parameters.AddWithValue("@password", usuario.password);

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
                    throw new Exception("No se pudo realizar la edición, el jefe no es válido");
                }
                else if (ex.Number == 1062)
                {
                    throw new Exception("No se pudo realizar la edición, el nombre de producto ya se encuentra en uso");
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

        /// <summary>
        /// Agregar un registro a la tabla "Productos" por medio de un comando SQL
        /// </summary>
        /// <param name="productos">Objeto de tipo Producto que contiene toda la información a insertar</param>
        /// <returns>Número de filas agregadas a la tabla</returns>
        /// <exception cref="Exception"></exception>
        public int agregar(Productos productos)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO PRODUCTOS
                          VALUES(@codigo, @descripcion, @ventaporunidad, @ventaagranel, @ventaporpaquete,
                                @preciocosto, @ganacia, @precioventa, @activo, @cantidad, @categoria);");

                    comando.Parameters.AddWithValue("@codigo", productos.CodigoBarras);
                    comando.Parameters.AddWithValue("@descripcion", productos.Descripcion);
                    comando.Parameters.AddWithValue("@ventaporunidad", productos.VentaPorUnidad);
                    comando.Parameters.AddWithValue("@ventaagranel", productos.VentaAGranel);
                    comando.Parameters.AddWithValue("@ventaporpaquete", productos.VentaPorPaquete);
                    comando.Parameters.AddWithValue("@preciocosto", productos.PrecioCosto);
                    comando.Parameters.AddWithValue("@ganacia", productos.Ganancia);
                    comando.Parameters.AddWithValue("@precioventa", productos.PrecioVenta);
                    comando.Parameters.AddWithValue("@categoria", productos.categorias);
                    comando.Parameters.AddWithValue("@cantidad", productos.Cantidad);
                    comando.Parameters.AddWithValue("@activo",productos.Activo);
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
                    throw new Exception("No se pudo realizar el registro, el jefe no es válido");
                }
                else if (ex.Number == 1062)
                {
                    throw new Exception("No se pudo realizar el registro, el nombre de usuario ya se encuentra en uso");
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
        /// Buscar coincidencias del parámetro recibido en la columna "Descripción" de la tabla "Productos" 
        /// por medio de un comando SQL
        /// </summary>
        /// <param name="cadena">Cadena de texto para buscar coincidencias</param>
        /// <returns>Lista de objetos de tipo Producto que coinciden con la búsqueda</returns>
        /// <exception cref="Exception"></exception>
        public List<Productos> buscar(string cadena)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos WHERE Descripcion LIKE @Cadena or Codigo LIKE @Codigo;");

                    comando.Parameters.AddWithValue("@Cadena", "%" + cadena + "%");
                    comando.Parameters.AddWithValue("@Codigo", "%" + cadena + "%");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Productos> lista = new List<Productos>();
                    adapter.Fill(resultado);

                    Productos objProductos = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProductos = new Productos();

                        //objProductos.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objProductos.CodigoBarras = fila["Codigo"].ToString();
                        objProductos.Descripcion = fila["Descripcion"].ToString();
                        objProductos.VentaPorUnidad = Convert.ToBoolean(fila["VentaporUnidad"]);
                        objProductos.VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]);
                        objProductos.VentaPorPaquete = Convert.ToBoolean(fila["VentaporPaquete"]);
                        objProductos.PrecioCosto = Convert.ToInt32(fila["PrecioCosto"]);
                        objProductos.Ganancia = Convert.ToInt32(fila["Ganancia"]);
                        objProductos.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
                        objProductos.categorias = Convert.ToInt32(fila["Categoria"]);
                        objProductos.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                        lista.Add(objProductos);
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

                throw new Exception("No se pudo obtener la información de la categoría");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Buscar coincidencias del parámetro recibido en la columna "Codigo" de la tabla "Productos" 
        /// por medio de un comando SQL
        /// </summary>
        /// <param name="codigo">Cadena de texto para buscar coincidencias</param>
        /// <returns>Lista de objetos de tipo Producto que coinciden con la búsqueda</returns>
        /// <exception cref="Exception"></exception>
        public Productos BuscarCodigo(string codigo)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Productos
                        WHERE codigo=@codigo AND Activo=1;");

                    comando.Parameters.AddWithValue("@codigo", codigo);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);


                    Productos objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objProducto = new Productos();
                        objProducto.CodigoBarras = fila["Codigo"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]);
                        objProducto.VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]);
                        objProducto.VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]);
                        objProducto.PrecioCosto = Convert.ToInt32(fila["PrecioCosto"]);
                        objProducto.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
                        objProducto.categorias = Convert.ToInt32(fila["Categoria"]);
                        objProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                        ++objProducto.CantidadComprada;
                    }

                    return objProducto;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool borradoLogico(string id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Productos
                            SET Activo=0
                            WHERE codigo=@codigo;");

                    comando.Parameters.AddWithValue("@codigo", id);

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
                throw new Exception("Error al intentar eliminar el productos.");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
        public List<Productos> ObtenerInactivos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @" SELECT p.*, c.nombre as NombreCategoria
                            FROM Productos p JOIN Categorias c ON c.id=p.categoria where p.activo=0;");

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
                        objProducto = new Productos();
                        //objProducto.IdProductos = Convert.ToInt32(fila["Idproductos"]);
                        objProducto.CodigoBarras = fila["Codigo"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.VentaPorUnidad = Convert.ToBoolean(fila["VentaPorUnidad"]);
                        objProducto.VentaAGranel = Convert.ToBoolean(fila["VentaAGranel"]);
                        objProducto.VentaPorPaquete = Convert.ToBoolean(fila["VentaPorPaquete"]);
                        objProducto.PrecioCosto = Convert.ToInt32(fila["PrecioCosto"]);
                        objProducto.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
                        objProducto.Ganancia = Convert.ToInt32(fila["Ganancia"]);
                        objProducto.categorias = Convert.ToInt32(fila["Categoria"]);
                        objProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                        objProducto.NombreCategoria = fila["NombreCategoria"].ToString();
                        objProducto.Activo = Convert.ToInt32(fila["Activo"]);

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
                throw new Exception("No se pudo obtener la información de los usuarios");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
