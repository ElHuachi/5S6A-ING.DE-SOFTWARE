using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;

namespace Datos
{
    public class DAOUsuario
    {
        /// <summary>
        /// Busca alguna coincidencia de los parámetros con los campos usuario y contraseña de la tabla "Usuarios"
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="password">Contraseña correspondiente al usuario</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Usuario IniciarSesion(String usuario, String password)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT IdUsuario,Nombre,Usuario FROM Usuarios WHERE Usuario='" + usuario + "' AND Contrasenia=sha2('" + password + "',256)");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Usuario objUsuario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    if (resultado.Rows.Count > 0)
                    {
                        objUsuario = new Usuario(

                            resultado.Rows[0]["Usuario"].ToString(),
                            usuario,
                            resultado.Rows[0]["Nombre"].ToString(),
                            Convert.ToInt32(resultado.Rows[0]["IdUsuario"])
                        );
                    }
                    return objUsuario;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Obtener todos los registros activos de la tabla "Usuarios" por medio de un comando SQL
        /// </summary>
        /// <returns>Lista de usuarios con todos los resultados de la ejecución de la consulta</returns>
        /// <exception cref="Exception"></exception>
        public List<Usuario> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @"select u.IdUsuario,u.Nombre,u.Usuario,u.contrasenia, peve.Registrar_Entradas_De_Dinero, peve.Registrar_Salidas_De_Dinero,
peve.Cancelar_compras,peve.Eliminar_Articulos,peve.Generar_facturas, pepro.Agregar_Proveedores, pepro.Editar_Proveedores,
pepro.Eliminar_Proveedores,pepro.Generar_Facturas, peprodu.Agregar_Productos,peprodu.Editar_Productos,peprodu.Eliminar_Productos,
peprodu.Crear_Categorias, pecli.Agregar_Clientes,pecli.Editar_Clientes,pecli.Eliminar_Clientes, pecaj.Agregar_Usuarios, pecaj.Editar_Usuarios,
pecaj.Eliminar_Usuarios from Usuarios u
inner join  PermisoVentas peve on u.IdUsuario = peve.IdUsuario
inner join PermisoProveedores pepro on u.IdUsuario = pepro.IdUsuario
inner join PermisoProductos peprodu on u.IdUsuario = peprodu.IdUsuario
inner join PermisoClientes pecli on u.IdUsuario = pecli.IdUsuario
inner join Permisocajeros pecaj on u.IdUsuario = pecaj.IdUsuario;");
                            
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Usuario> lista = new List<Usuario>();
                    Usuario objUsuario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objUsuario = new Usuario();

                        objUsuario.Id = Convert.ToInt32(fila["IdUsuario"]);
                        objUsuario.Nombre = fila["Nombre"].ToString();
                        objUsuario.Nombre_Usuario = fila["Usuario"].ToString();
                        objUsuario.password=fila["Contrasenia"].ToString();
                        objUsuario.EntradasDinero = Convert.ToBoolean(fila["Registrar_Entradas_De_Dinero"]);
                        objUsuario.SalidasDinero = Convert.ToBoolean(fila["Registrar_Salidas_De_Dinero"]);
                        objUsuario.CancelarCompras = Convert.ToBoolean(fila["Cancelar_compras"]);
                        objUsuario.EliminarArticulos = Convert.ToBoolean(fila["Eliminar_Articulos"]);
                        objUsuario.GenerarFacturasVentas = Convert.ToBoolean(fila["Generar_facturas"]);
                        objUsuario.AgregarProveedores = Convert.ToBoolean(fila["Agregar_Proveedores"]);
                        objUsuario.EditarProveedores = Convert.ToBoolean(fila["Editar_Proveedores"]);
                        objUsuario.EliminarProveedores = Convert.ToBoolean(fila["Eliminar_Proveedores"]);
                        objUsuario.GenerarFacturasProveedores = Convert.ToBoolean(fila["Generar_Facturas"]);
                        objUsuario.AgregarProducto = Convert.ToBoolean(fila["Agregar_Productos"]);
                        objUsuario.EditarProducto = Convert.ToBoolean(fila["Editar_Productos"]);
                        objUsuario.EliminarProducto = Convert.ToBoolean(fila["Eliminar_Productos"]);
                        objUsuario.AgregarCategorias = Convert.ToBoolean(fila["Crear_Categorias"]);
                        objUsuario.AgregarClientes = Convert.ToBoolean(fila["Agregar_Clientes"]);
                        objUsuario.EditarClientes = Convert.ToBoolean(fila["Editar_Clientes"]);
                        objUsuario.EliminarClientes = Convert.ToBoolean(fila["Eliminar_Clientes"]);
                        objUsuario.AgregarUsuarios = Convert.ToBoolean(fila["Agregar_Usuarios"]);
                        objUsuario.EditarUsuarios = Convert.ToBoolean(fila["Editar_Usuarios"]);
                        objUsuario.EliminarUsuarios = Convert.ToBoolean(fila["Eliminar_Usuarios"]);

                        lista.Add(objUsuario);
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

        /// <summary>
        /// Obtener el registro de la tabla "Usuarios" del que el ID cocuerde con el parámetro recibido
        /// siempre y cuándo este activo,todo esto por medio de un comando SQL
        /// </summary>
        /// <param name="id">Id a buscar en la tabla "Usuarios"</param>
        /// <returns>Objeto de tipo Usuario en el que su Id coincide con elparámetro recibido</returns>
        /// <exception cref="Exception"></exception>
        public Usuario ObtenerUno(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT 
                        u.IdUsuario,u.Nombre,u.Usuario,u.contrasenia, peve.Registrar_Entradas_De_Dinero, peve.Registrar_Salidas_De_Dinero,
                        peve.Cancelar_compras,peve.Eliminar_Articulos,peve.Generar_facturas, pepro.Agregar_Proveedores, pepro.Editar_Proveedores,
                        pepro.Eliminar_Proveedores,pepro.Generar_Facturas, peprodu.Agregar_Productos,peprodu.Editar_Productos,peprodu.Eliminar_Productos,
                        peprodu.Crear_Categorias, pecli.Agregar_Clientes,pecli.Editar_Clientes,pecli.Eliminar_Clientes, pecaj.Agregar_Usuarios, pecaj.Editar_Usuarios,
                        pecaj.Eliminar_Usuarios from Usuarios u
                        inner join  PermisoVentas peve on u.IdUsuario = peve.IdUsuario
                        inner join PermisoProveedores pepro on u.IdUsuario = pepro.IdUsuario
                        inner join PermisoProductos peprodu on u.IdUsuario = peprodu.IdUsuario
                        inner join PermisoClientes pecli on u.IdUsuario = pecli.IdUsuario
                        inner join Permisocajeros pecaj on u.IdUsuario = pecaj.IdUsuario where u.idUsuario=@id;");

                    comando.Parameters.AddWithValue("@id", id);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);

                    Usuario objUsuario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objUsuario = new Usuario();
                        objUsuario.Id = Convert.ToInt32(fila["IdUsuario"]);                        
                        objUsuario.Nombre_Usuario = fila["Usuario"].ToString();
                        objUsuario.Nombre = fila["Nombre"].ToString();
                        objUsuario.EntradasDinero = Convert.ToBoolean(fila["Registrar_Entradas_De_Dinero"]);
                        objUsuario.SalidasDinero = Convert.ToBoolean(fila["Registrar_Salidas_De_Dinero"]);
                        objUsuario.CancelarCompras = Convert.ToBoolean(fila["Cancelar_compras"]);
                        objUsuario.EliminarArticulos = Convert.ToBoolean(fila["Eliminar_Articulos"]);
                        objUsuario.GenerarFacturasVentas = Convert.ToBoolean(fila["Generar_facturas"]);
                        objUsuario.AgregarProveedores = Convert.ToBoolean(fila["Agregar_Proveedores"]);
                        objUsuario.EditarProveedores = Convert.ToBoolean(fila["Editar_Proveedores"]);
                        objUsuario.EliminarProveedores = Convert.ToBoolean(fila["Eliminar_Proveedores"]);
                        objUsuario.GenerarFacturasProveedores = Convert.ToBoolean(fila["Generar_Facturas"]);
                        objUsuario.AgregarProducto = Convert.ToBoolean(fila["Agregar_Productos"]);
                        objUsuario.EditarProducto = Convert.ToBoolean(fila["Editar_Productos"]);
                        objUsuario.EliminarProducto = Convert.ToBoolean(fila["Eliminar_Productos"]);
                        objUsuario.AgregarCategorias = Convert.ToBoolean(fila["Crear_Categorias"]);
                        objUsuario.AgregarClientes = Convert.ToBoolean(fila["Agregar_Clientes"]);
                        objUsuario.EditarClientes = Convert.ToBoolean(fila["Editar_Clientes"]);
                        objUsuario.EliminarClientes = Convert.ToBoolean(fila["Eliminar_Clientes"]);
                        objUsuario.AgregarUsuarios = Convert.ToBoolean(fila["Agregar_Usuarios"]);
                        objUsuario.EditarUsuarios = Convert.ToBoolean(fila["Editar_Usuarios"]);
                        objUsuario.EliminarUsuarios = Convert.ToBoolean(fila["Eliminar_Usuarios"]);
                    }

                    return objUsuario;
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
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(

                        @"
                        DELETE FROM PermisoVentas pv
                        WHERE pv.IdUsuario=@id;
                        DELETE FROM PermisoProveedores pp
                        WHERE pp.IdUsuario=@id;
                        DELETE  FROM PermisoProductos ppr
                        WHERE ppr.IdUsuario=@id;
                        DELETE  FROM PermisoClientes pc
                        WHERE pc.IdUsuario=@id;
                        DELETE  FROM Permisocajeros pca
                        WHERE pca.IdUsuario=@id;
                        DELETE FROM Usuarios u
                        WHERE u.IdUsuario=@id;");

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

        /// <summary>
        /// Editar un registro ya existente en la tabla "Usuarios" por medio de un comando SQL
        /// </summary>
        /// <param name="usuario">Objeto de tipo "Usuario" a editar</param>
        /// <returns>true: se realizó la edició exitosamente, false: no se realizó la edición</returns>
        /// <exception cref="Exception"></exception>
        public bool editar(Usuario usuario)
        {
            
            try
            {
                
                if (Conexion.conectar())
                {
                    //Simulación de que el nombre de usuario es el firstname del usuario y  
                    //city es el password
                    MySqlCommand comando = new MySqlCommand(
                        @"
                        
                        UPDATE Usuarios u SET u.Nombre = @nombre, u.Usuario= @usuario, u.contrasenia = sha2(@pass,256) WHERE u.IdUsuario=@id;

                        UPDATE PermisoVentas peve set peve.Registrar_Entradas_De_Dinero=@entradasdinero, peve.Registrar_Salidas_De_Dinero = @salidasdinero, peve.Cancelar_compras = @cancelarcompras,
                        peve.Eliminar_Articulos = @eliminararticulos,peve.Generar_facturas = @generarfacturasventas WHERE peve.IdUsuario=@id;

                        UPDATE PermisoProveedores pepro SET pepro.Agregar_Proveedores = @agregarproveedores, pepro.Editar_Proveedores = @editarproveedores, pepro.Eliminar_Proveedores = @eliminarproveedores,
                        pepro.Generar_Facturas = @generarfacturasproveedores WHERE pepro.IdUsuario=@id;

                        UPDATE PermisoProductos peprodu SET peprodu.Agregar_Productos = @agregarproductos,peprodu.Editar_Productos = @editarproductos,peprodu.Eliminar_Productos = @eliminarproductos, 
                        peprodu.Crear_Categorias= @crearcategorias WHERE peprodu.IdUsuario=@id;

                        UPDATE PermisoClientes pecli SET pecli.Agregar_Clientes = @agregarclientes,pecli.Editar_Clientes = @editarclientes,pecli.Eliminar_Clientes = @eliminarclientes WHERE pecli.IdUsuario=@id;
	                    
                        UPDATE Permisocajeros pecaj SET pecaj.Agregar_Usuarios=@agregarusuarios, pecaj.Editar_Usuarios=@editarusuarios, pecaj.Eliminar_Usuarios=@eliminarusuarios WHERE pecaj.IdUsuario=@id;
                        ");

                        comando.Parameters.AddWithValue("@id", usuario.Id);
                        comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        comando.Parameters.AddWithValue("@usuario", usuario.Nombre_Usuario);
                        comando.Parameters.AddWithValue("@pass", usuario.password);

                        comando.Parameters.AddWithValue("@entradasdinero", usuario.EntradasDinero);
                        comando.Parameters.AddWithValue("@salidasdinero", usuario.SalidasDinero);
                        comando.Parameters.AddWithValue("@cancelarcompras", usuario.CancelarCompras);
                        comando.Parameters.AddWithValue("@eliminararticulos", usuario.EliminarArticulos);
                        comando.Parameters.AddWithValue("@generarfacturasventas", usuario.GenerarFacturasVentas);

                        comando.Parameters.AddWithValue("@agregarproveedores", usuario.AgregarProveedores);
                        comando.Parameters.AddWithValue("@editarproveedores", usuario.EditarProveedores);
                        comando.Parameters.AddWithValue("@eliminarproveedores", usuario.EliminarProveedores);
                        comando.Parameters.AddWithValue("@generarfacturasproveedores", usuario.GenerarFacturasProveedores);

                        comando.Parameters.AddWithValue("@agregarproductos", usuario.AgregarProducto);
                        comando.Parameters.AddWithValue("@editarproductos", usuario.EditarProducto);
                        comando.Parameters.AddWithValue("@eliminarproductos", usuario.EliminarProducto);
                        comando.Parameters.AddWithValue("@crearcategorias", usuario.AgregarCategorias);

                        comando.Parameters.AddWithValue("@agregarclientes", usuario.AgregarClientes);
                        comando.Parameters.AddWithValue("@editarclientes", usuario.EditarClientes);
                        comando.Parameters.AddWithValue("@eliminarclientes", usuario.EliminarClientes);
                        comando.Parameters.AddWithValue("@agregarusuarios", usuario.AgregarUsuarios);
                        comando.Parameters.AddWithValue("@editarusuarios", usuario.EditarUsuarios);
                        comando.Parameters.AddWithValue("@eliminarusuarios", usuario.EliminarUsuarios);
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

        /// <summary>
        /// Agregar un registro a la tabla "Usuario" por medio de un comando SQL
        /// </summary>
        /// <param name="usuario">Objeto de tipo Usuario que contiene toda la información a insertar</param>
        /// <returns>Número de filas agregadas a la tabla</returns>
        /// <exception cref="Exception"></exception>
        public int agregar(Usuario usuario)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                    @"              
                    
                    INSERT INTO usuarios(usuario,contrasenia,Nombre,Activo) 
                    VALUES (@usuario,sha2(@contrasenia,256),@nombre,1);
                                         
                    INSERT INTO permisoventas(IdUsuario, Registrar_Entradas_De_Dinero, Registrar_Salidas_De_Dinero, Cancelar_compras,
                    Eliminar_Articulos, Generar_facturas)VALUES
                    (last_insert_id(), @entradasdinero, @salidasdinero, @cancelarcompras, @eliminararticulos, @generarfacturasventas);

                    INSERT INTO permisoproveedores(IdUsuario, Agregar_Proveedores, Editar_Proveedores, Eliminar_Proveedores, Generar_Facturas)
                        VALUES(last_insert_id(), @agregarproveedores, @editarproveedores, @eliminarproveedores, @generarfacturasproveedores);

                    INSERT INTO permisoproductos(IdUsuario, Agregar_Productos, Editar_Productos, Eliminar_Productos, Crear_Categorias)
                        VALUES(last_insert_id(), @agregarproductos, @editarproductos, @eliminarproductos, @crearcategorias);

                    INSERT INTO permisoclientes(IdUsuario, Agregar_Clientes, Editar_Clientes, Eliminar_Clientes)
                        VALUES(last_insert_id(), @agregarclientes, @editarclientes, @eliminarclientes);

                    INSERT INTO permisocajeros(IdUsuario, Agregar_Usuarios, Editar_Usuarios, Eliminar_Usuarios)
                        VALUES(last_insert_id(), @agregarusuarios, @editarusuarios, @eliminarusuarios);
                    SELECT last_insert_id();");

                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@contrasenia", usuario.password);
                    comando.Parameters.AddWithValue("@usuario", usuario.Nombre_Usuario);
                    comando.Parameters.AddWithValue("last_insert_id()", usuario.Id);
                    comando.Parameters.AddWithValue("@entradasdinero", usuario.EntradasDinero);
                    comando.Parameters.AddWithValue("@salidasdinero", usuario.SalidasDinero);
                    comando.Parameters.AddWithValue("@cancelarcompras", usuario.CancelarCompras);
                    comando.Parameters.AddWithValue("@eliminararticulos", usuario.EliminarArticulos);
                    comando.Parameters.AddWithValue("@generarfacturasventas", usuario.GenerarFacturasVentas);

                    comando.Parameters.AddWithValue("@agregarproveedores", usuario.AgregarProveedores);
                    comando.Parameters.AddWithValue("@editarproveedores", usuario.EditarProveedores);
                    comando.Parameters.AddWithValue("@eliminarproveedores", usuario.EliminarProveedores);
                    comando.Parameters.AddWithValue("@generarfacturasproveedores", usuario.GenerarFacturasProveedores);

                    comando.Parameters.AddWithValue("@agregarproductos", usuario.AgregarProducto);
                    comando.Parameters.AddWithValue("@editarproductos", usuario.EditarProducto);
                    comando.Parameters.AddWithValue("@eliminarproductos", usuario.EliminarProducto);
                    comando.Parameters.AddWithValue("@crearcategorias", usuario.AgregarCategorias);
                    comando.Parameters.AddWithValue("@agregarclientes", usuario.AgregarClientes);
                    comando.Parameters.AddWithValue("@editarclientes", usuario.EditarClientes);
                    comando.Parameters.AddWithValue("@eliminarclientes", usuario.EliminarClientes);
                    comando.Parameters.AddWithValue("@agregarusuarios", usuario.AgregarUsuarios);
                    comando.Parameters.AddWithValue("@editarusuarios", usuario.EditarUsuarios);
                    comando.Parameters.AddWithValue("@eliminarusuarios", usuario.EliminarUsuarios);
                    


        
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
        /// Buscar coincidencias del parámetro recibido en la columna "Nombre" de la tabla "Usuarios" 
        /// por medio de un comando SQL
        /// </summary>
        /// <param name="cadena">Cadena de texto para buscar coincidencias</param>
        /// <returns>Lista de objetos de tipo Usuario que coinciden con la búsqueda</returns>
        /// <exception cref="Exception"></exception>
        public List<Usuario> buscar(string cadena)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        @"SELECT * FROM Usuarios WHERE Nombre LIKE @Cadena or Usuario LIKE @Usuario;");

                    comando.Parameters.AddWithValue("@Cadena", "%" + cadena + "%");
                    comando.Parameters.AddWithValue("@Usuario", "%" + cadena + "%");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    List<Usuario> lista = new List<Usuario>();
                    adapter.Fill(resultado);

                    Usuario objUsuario = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas

                    foreach (DataRow fila in resultado.Rows)
                    {
                        objUsuario = new Usuario();

                        //objProductos.IdProductos = Convert.ToInt32(fila["Idproductos"]);                        
                        objUsuario.Nombre_Usuario = fila["Usuario"].ToString();
                        objUsuario.password = fila["contrasenia"].ToString();
                        objUsuario.Nombre = fila["Nombre"].ToString();                        
                        lista.Add(objUsuario);
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

    }
}
