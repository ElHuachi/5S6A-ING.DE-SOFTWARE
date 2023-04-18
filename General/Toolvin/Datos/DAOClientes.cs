using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
    public class DAOClientes
    {
        /// <summary>
        /// Obtener todos los registros activos de la tabla "Clientes" por medio de un comando SQL
        /// </summary>
        /// <returns>Lista de clientes con todos los resultados de la ejecución de la consulta</returns>
        /// <exception cref="Exception"></exception>
        public List<Cliente> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * from Clientes WHERE Activo=true OR Activo=1;");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Cliente> lista = new List<Cliente>();
                    Cliente objCliente = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCliente = new Cliente();
                        objCliente.Id = Convert.ToInt32(fila["Id"]);
                        objCliente.Nombre = fila["Nombre"].ToString();
                        objCliente.Direccion = fila["Direccion"].ToString();
                        objCliente.Colonia = fila["Colonia"].ToString();
                        objCliente.Municipio = fila["Municipio"].ToString();
                        objCliente.Estado = fila["Estado"].ToString();
                        objCliente.CP = fila["CodigoPostal"].ToString();
                        objCliente.Telefono = fila["Telefono"].ToString();

                        lista.Add(objCliente);
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
                throw new Exception("No se pudo obtener la información de los clientes");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Obtener el registro de la tabla "Clientes" del que el ID cocuerde con el parámetro recibido
        /// siempre y cuándo este activo,todo esto por medio de un comando SQL
        /// </summary>
        /// <param name="id">Id a buscar en la tabla "Clientes"</param>
        /// <returns>Objeto de tipo Cliente en el que su Id coincide con elparámetro recibido</returns>
        /// <exception cref="Exception"></exception>
        public Cliente ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Clientes
                        WHERE Id=@Id");

                    comando.Parameters.AddWithValue("@Id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Cliente objCliente = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objCliente = new Cliente();
                        objCliente.Id = Convert.ToInt32(fila["Id"]);
                        objCliente.Nombre = fila["Nombre"].ToString();
                        objCliente.Direccion = fila["Direccion"].ToString();
                        objCliente.Colonia = fila["Colonia"].ToString();
                        objCliente.Municipio = fila["Municipio"].ToString();
                        objCliente.Estado = fila["Estado"].ToString();
                        objCliente.CP = fila["CodigoPostal"].ToString();
                        objCliente.Telefono = fila["Telefono"].ToString();
                    }

                    return objCliente;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del cliente");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Buscar coincidencias del parámetro recibido en la columna "Nombre" de la tabla "Clientes" 
        /// por medio de un comando SQL
        /// </summary>
        /// <param name="cadena">Cadena de texto para buscar coincidencias</param>
        /// <returns>Lista de objetos de tipo Cliente que coinciden con la búsqueda</returns>
        /// <exception cref="Exception"></exception>
        public List<Cliente> buscar(string cadena)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Clientes
                        WHERE Nombre LIKE @Cadena;");

                    comando.Parameters.AddWithValue("@Cadena", "%" + cadena + "%");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Cliente> lista = new List<Cliente>();
                    adapter.Fill(resultado);

                    Cliente objCliente = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objCliente = new Cliente();
                        objCliente.Id = Convert.ToInt32(fila["Id"]);
                        objCliente.Nombre = fila["Nombre"].ToString();
                        objCliente.Direccion = fila["Direccion"].ToString();
                        objCliente.Colonia = fila["Colonia"].ToString();
                        objCliente.Municipio = fila["Municipio"].ToString();
                        objCliente.Estado = fila["Estado"].ToString();
                        objCliente.CP = fila["CodigoPostal"].ToString();
                        objCliente.Telefono = fila["Telefono"].ToString();

                        lista.Add(objCliente);
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
                throw new Exception("No se pudo obtener la información del cliente");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Agregar un registro a la tabla "Clientes" por medio de un comando SQL
        /// </summary>
        /// <param name="cliente">Objeto de tipo Cliente que contiene toda la información a insertar</param>
        /// <returns>Número de filas agregadas a la tabla</returns>
        /// <exception cref="Exception"></exception>
        public int agregar(Cliente cliente)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"INSERT INTO Clientes(Nombre, Direccion, Colonia, Municipio, Estado, CodigoPostal, Telefono, Activo)
                        VALUES(@Nombre, @Direccion, @Colonia, @Municipio, @Estado, @CodigoPostal, @Telefono, true);");

                    comando.Parameters.AddWithValue("@id", cliente.Id);
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Colonia", cliente.Colonia);
                    comando.Parameters.AddWithValue("@Municipio", cliente.Municipio);
                    comando.Parameters.AddWithValue("@Estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@CodigoPostal", cliente.CP);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Activo", cliente.Activo);
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

        /// <summary>
        /// Editar un registro ya existente en la tabla "Clientes" por medio de un comando SQL
        /// </summary>
        /// <param name="cliente">Objeto de tipo "Cliente" a editar</param>
        /// <returns>true: se realizó la edició exitosamente, false: no se realizó la edición</returns>
        /// <exception cref="Exception"></exception>
        public bool editar(Cliente cliente)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"UPDATE Clientes
                            SET Nombre=@Nombre, 
                            Direccion=@Direccion,
                            Colonia=@Colonia,
                            Municipio=@Municipio,
                            Estado=@Estado,
                            CodigoPostal=@CodigoPostal,
                            Telefono=@Telefono
                            WHERE Id=@Id;");

                    comando.Parameters.AddWithValue("@Id", cliente.Id);
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Colonia", cliente.Colonia);
                    comando.Parameters.AddWithValue("@Municipio", cliente.Municipio);
                    comando.Parameters.AddWithValue("@Estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@CodigoPostal", cliente.CP);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Activo", cliente.Activo);

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
                if (ex.Number == 1452) //Llave foránea
                {
                    throw new Exception("No se pudo realizar la modificación, fallo en llenado de llaves foráneas");
                }
                else
                {
                    throw new Exception("No se pudo realizar la modificación");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Elimina un registro de la tabla "Usuarios" por medio de un comando SQL
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
                        @"DELETE FROM Clientes 
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
                    return borradoLogico(id);
                }
                else
                {
                    throw new Exception("Error al intentar eliminar el cliente");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }


        /// <summary>
        /// Cambiar el estado del registro con el id recibido como parámetro a inactivo ó 0
        /// </summary>
        /// <param name="id">Id del registro a desactivar</param>
        /// <returns>true: se realizó la edició exitosamente, false: no se realizó la edición</returns>
        /// <exception cref="Exception"></exception>
        public bool borradoLogico(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"update clientes set activo=false where id=@id;");
                    //call spBorradoLogicoCLIENTES(@id, @estado);
                    //select @estado;

                    //MySqlCommand comando = new MySqlCommand();


                    //comando.CommandText="spBorradoLogicoCLIENTES";
                    //comando.Connection = Conexion.conexion;
                    //comando.CommandType=System.Data.CommandType.StoredProcedure;
                    //comando.Parameters.AddWithValue("@_clave", id);
                    //int filasBorradas = comando.ExecuteNonQuery();

                    comando.Parameters.AddWithValue("@id", id);

                    comando.Connection = Conexion.conexion;

                    int filasBorradas = Convert.ToInt32(comando.ExecuteNonQuery());
                    return (filasBorradas > 0);
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al intentar eliminar el cliente.");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
