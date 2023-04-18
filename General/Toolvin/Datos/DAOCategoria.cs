using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
    public class DAOCategoria
    {
        /// <summary>
        /// Obtener todos los registros activos de la tabla "Categorías" por medio de un comando SQL
        /// </summary>
        /// <returns>Lista de categorías con todos los resultados de la ejecución de la consulta</returns>
        /// <exception cref="Exception"></exception>
        public List<Categoria> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"SELECT * from Categorias WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Categoria> lista = new List<Categoria>();
                    Categoria objCategoria = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCategoria = new Categoria();
                        objCategoria.Id = Convert.ToInt32(fila["Id"]);
                        objCategoria.Nombre = fila["Nombre"].ToString();
                        objCategoria.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(objCategoria);
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
                throw new Exception("No se pudo obtener la información de las categorías");
            }
            finally
            {
                Conexion.desconectar();
            }
        }


        /// <summary>
        /// Obtener el registro de la tabla "Categorías" del que el ID cocuerde con el parámetro recibido
        /// siempre y cuándo este activo,todo esto por medio de un comando SQL
        /// </summary>
        /// <param name="id">Id a buscar en la tabla "Categorías"</param>
        /// <returns>Objeto de tipo Categoría en el que su Id coincide con elparámetro recibido</returns>
        /// <exception cref="Exception"></exception>
        public Categoria ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Categorias
                        WHERE Id=@Id");

                    comando.Parameters.AddWithValue("@Id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Categoria objCategoria = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objCategoria = new Categoria();
                        objCategoria.Id = Convert.ToInt32(fila["Id"]);
                        objCategoria.Nombre = fila["Nombre"].ToString();
                        objCategoria.Descripcion = fila["Descripcion"].ToString();
                    }

                    return objCategoria;
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
        /// Buscar coincidencias del parámetro recibido en la columna "Nombre" de la tabla "Categorias" 
        /// por medio de un comando SQL
        /// </summary>
        /// <param name="cadena">Cadena de texto para buscar coincidencias</param>
        /// <returns>Lista de objetos de tipo Categoria que coinciden con la búsqueda</returns>
        /// <exception cref="Exception"></exception>
        public List<Categoria> buscar(string cadena)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Categorias
                        WHERE Nombre LIKE @Cadena;");

                    comando.Parameters.AddWithValue("@Cadena", "%" + cadena + "%");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Categoria> lista = new List<Categoria>();
                    adapter.Fill(resultado);

                    Categoria objCategoria = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCategoria = new Categoria();
                        objCategoria.Id = Convert.ToInt32(fila["Id"]);
                        objCategoria.Nombre = fila["Nombre"].ToString();
                        objCategoria.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(objCategoria);
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
        /// Agregar un registro a la tabla "Categorías" por medio de un comando SQL
        /// </summary>
        /// <param name="categoria">Objeto de tipo Categoría que contiene toda la información a insertar</param>
        /// <returns>Número de filas agregadas a la tabla</returns>
        /// <exception cref="Exception"></exception>
        public int agregar(Categoria categoria)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO Categorias(Nombre, Descripcion, Activo)
                        VALUES(@Nombre,@Descripcion, 1);");

                    comando.Parameters.AddWithValue("@id", categoria.Id);
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    //comando.Parameters.AddWithValue("@Activo", categoria.Activo);

                    //Se establece la conexión con la que se ejecutará la consulta
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
                if (ex.Number == 1062) //Unique
                {
                    throw new Exception("No se pudo realizar el registro, el nombre de categoría ya se encuentra en uso");
                }
                else if (ex.Number == 1452) //Llave foránea
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


        /// <summary>
        /// Editar un registro ya existente en la tabla "Categorías" por medio de un comando SQL
        /// </summary>
        /// <param name="categoria">Objeto de tipo "Categoría" a editar</param>
        /// <returns>true: se realizó la edició exitosamente, false: no se realizó la edición</returns>
        /// <exception cref="Exception"></exception>
        public bool editar(Categoria categoria)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Categorias
                            SET Nombre=@Nombre, 
                            Descripcion=@Descripcion, activo=@activo
                            WHERE Id=@Id");

                    comando.Parameters.AddWithValue("@Id", categoria.Id);
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    comando.Parameters.AddWithValue("@Activo", categoria.Activo);

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
                if (ex.Number == 1062) //Unique
                {
                    throw new Exception("No se pudo realizar la modificación, el nombre de categoría ya se encuentra en uso");
                }
                else if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar la modificación, fallo en llenado de llaves foráneas");
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(
                       @"UPDATE Categorias
                            SET Nombre=@Nombre, 
                            Descripcion=@Descripcion, activo = 0
                            WHERE Id=@Id");

                    comando.Parameters.AddWithValue("@Id", categoria.Id);
                    comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    comando.Parameters.AddWithValue("@Activo", 0);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = comando.ExecuteNonQuery();

                    return (filasBorradas > 0);
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Elimina un registro de la tabla "Categorías" por medio de un comando SQL
        /// </summary>
        /// <param name="id">Id del registro a eliminar</param>
        /// <returns>true: se realizó la eliminación exitosamente, false: no se realizó la eliminación</returns>
        /// <exception cref="Exception"></exception>
        public bool eliminar(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"DELETE FROM Categorias 
                            WHERE Id=@id");

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
                    return borradoLógico(id);
                }
                else
                {
                    throw new Exception("Error al intentar eliminar la categoría");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        ///   hace una busqueda por el id de una categoria 
        /// </summary>
        /// <returns>
        ///   en la categoria que coincida se modificara la columna activo a un false 
        /// </returns>
        public bool borradoLógico(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Categorias
                            SET Activo=0
                            WHERE Id=@id");

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
                throw new Exception("Error al intentar eliminar la categoría.");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
        public List<Categoria> ObtenerInactivos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"SELECT * from Categorias WHERE Activo=0;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Categoria> lista = new List<Categoria>();
                    Categoria objCategoria = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCategoria = new Categoria();
                        objCategoria.Id = Convert.ToInt32(fila["Id"]);
                        objCategoria.Nombre = fila["Nombre"].ToString();
                        objCategoria.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(objCategoria);
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
                throw new Exception("No se pudo obtener la información de las categorías");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
