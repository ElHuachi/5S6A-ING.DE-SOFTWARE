using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class frmpantallaRegistraUsuario : Form
    {
        public bool Guardado { get; set; }

        private int IdUsuario;

        public int a = Program.IdCodigo;
        public frmpantallaRegistraUsuario(int id) : this()
        {
            IdUsuario = id;
            //Cargar el usuario de la BD
            try
            {
                Usuario obj = new DAOUsuario().ObtenerUno(a);
                Usuario objUsuario = new DAOUsuario().ObtenerUno(id);
                txtNombreCompleto.Text = objUsuario.Nombre;
                txtUsuario.Text = objUsuario.Nombre_Usuario;


                if (obj.EliminarUsuarios && obj.EditarUsuarios && obj.AgregarUsuarios)
                    txtContrasenia.Text = objUsuario.password;
                else
                {
                    txtContrasenia.Visible = false;
                    lblpass.Visible = false;
                }


                chkEntradasDinero.Checked = objUsuario.EntradasDinero;
                chkSalidasDinero.Checked = objUsuario.SalidasDinero;
                chkCancelarCompras.Checked = objUsuario.CancelarCompras;
                chkEliminaCompras.Checked = objUsuario.EliminarArticulos;
                chkGeneraFacturas.Checked = objUsuario.GenerarFacturasVentas;

                chkAgregaProveedores.Checked = objUsuario.AgregarProveedores;
                chkModificaProveedores.Checked = objUsuario.EditarProveedores;
                chkEliminaProveedores.Checked = objUsuario.EliminarProveedores;
                chkFacturasProveedores.Checked = objUsuario.GenerarFacturasProveedores;

                chkAgregaProductos.Checked = objUsuario.AgregarProducto;
                chkModificaProductos.Checked = objUsuario.EditarProducto;
                chkEliminaProductos.Checked = objUsuario.EliminarProducto;
                chkCreaCategorias.Checked = objUsuario.AgregarCategorias;

                chkAgregaClientes.Checked = objUsuario.AgregarClientes;
                chkEliminaClientes.Checked = objUsuario.EliminarClientes;
                chkModificaClientes.Checked = objUsuario.EditarClientes;

                chkAgregaUsuarios.Checked = objUsuario.AgregarUsuarios;
                chkModificaUsuarios.Checked = objUsuario.EditarUsuarios;
                chkEliminaUsuarios.Checked = objUsuario.EliminarUsuarios;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            } 
        }

        public frmpantallaRegistraUsuario()
        {
            InitializeComponent();
            Desactivarpermisos();
            ActivarPermisosVentas();
           //abrirFormHijo(new frmPermisosVentas());
        }

        public void Desactivarpermisos()
        {
            btnPermisoCajeros.Enabled = false;
            btnPermisoClientes.Enabled = false;
            btnPermisoProductos.Enabled = false;
            btnPermisoProductos.Enabled = false;
            btnPermisoVentas.Enabled = false;
            btnPermisoProveedores.Enabled = false;
            MDIPermisos.Enabled = false;
        }

        public void Activarpermisos()
        {
            btnPermisoCajeros.Enabled = true;
            btnPermisoClientes.Enabled = true;
            btnPermisoProductos.Enabled = true;
            btnPermisoProductos.Enabled = true;
            btnPermisoVentas.Enabled = true;
            btnPermisoProveedores.Enabled = true;
            MDIPermisos.Enabled = true;
        }
        
        public void ActivarPermisosVentas() {
            chkEntradasDinero.Visible = true;
            chkSalidasDinero.Visible = true;
            chkCancelarCompras.Visible = true;
            chkEliminaCompras.Visible = true;
            chkGeneraFacturas.Visible = true;
        }

        public void DesactivarPermisosVentas()
        {
            chkEntradasDinero.Visible=false;
            chkSalidasDinero.Visible = false;
            chkCancelarCompras.Visible = false;
            chkEliminaCompras.Visible = false;
            chkGeneraFacturas.Visible = false;
        }

        public void ActivarPermisosProveedores()
        {
            chkAgregaProveedores.Visible = true;
            chkModificaProveedores.Visible = true;
            chkEliminaProveedores.Visible = true;
            chkFacturasProveedores.Visible = true;

        }

        public void DesactivarPermisosProveedores()
        {
            chkAgregaProveedores.Visible = false;
            chkModificaProveedores.Visible = false;
            chkEliminaProveedores.Visible = false;
            chkFacturasProveedores.Visible = false;

        }

        public void ActivarPermisosProductos()
        {
            chkAgregaProductos.Visible = true;
            chkModificaProductos.Visible = true;
            chkEliminaProductos.Visible = true;
            chkCreaCategorias.Visible = true;

        }

        public void DesactivarPermisosProductos()
        {
            chkAgregaProductos.Visible = false;
            chkModificaProductos.Visible = false;
            chkEliminaProductos.Visible = false;
            chkCreaCategorias.Visible = false;
        }

        public void ActivarPermisosClientes()
        {
            chkAgregaClientes.Visible = true;
            chkModificaClientes.Visible = true;
            chkEliminaClientes.Visible = true;
        }

        public void DesactivarPermisosClientes()
        {
            chkAgregaClientes.Visible = false;
            chkModificaClientes.Visible = false;
            chkEliminaClientes.Visible = false;
        }
        
        public void ActivarPermisosCajeros()
        {
            chkAgregaUsuarios.Visible = true;
            chkModificaUsuarios.Visible = true;
            chkEliminaUsuarios.Visible = true;
        }

        public void DesactivarPermisosCajeros()
        {
            chkAgregaUsuarios.Visible = false;
            chkModificaUsuarios.Visible = false;
            chkEliminaUsuarios.Visible = false;
        }

        private void btnPermisoVentas_Click(object sender, EventArgs e)
        {
            ActivarPermisosVentas();
            DesactivarPermisosProveedores();
            DesactivarPermisosProductos();
            DesactivarPermisosClientes();
            DesactivarPermisosCajeros();
        }

        private void btnPermisoProductos_Click(object sender, EventArgs e)
        {
            DesactivarPermisosVentas();
            DesactivarPermisosProveedores();
            ActivarPermisosProductos();
            DesactivarPermisosClientes();
            DesactivarPermisosCajeros();
        }

        private void btnPermisoClientes_Click(object sender, EventArgs e)
        {
            DesactivarPermisosVentas();
            DesactivarPermisosProveedores();
            DesactivarPermisosProductos();
            ActivarPermisosClientes();
            DesactivarPermisosCajeros();
        }

        private void btnPermisoProveedores_Click(object sender, EventArgs e)
        {
            DesactivarPermisosVentas();
            ActivarPermisosProveedores();
            DesactivarPermisosProductos();
            DesactivarPermisosClientes();
            DesactivarPermisosCajeros();
        }

        private void btnPermisoCajeros_Click(object sender, EventArgs e)
        {
            DesactivarPermisosVentas();
            DesactivarPermisosProveedores();
            DesactivarPermisosProductos();
            DesactivarPermisosClientes();
            ActivarPermisosCajeros();
        }

        private void chkAdminstra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdminstra.Checked == true)
            {
                Activarpermisos();
            }
            else
            {
                Desactivarpermisos();
            }
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (ptbNombre.Visible==true && ptbUsuario.Visible==true)
            {
                try
                {
                    Usuario objUsuario = new Usuario();
                    objUsuario.Nombre = txtNombreCompleto.Text.Trim();
                    objUsuario.Nombre_Usuario = txtUsuario.Text.Trim();
                    objUsuario.password = txtContrasenia.Text.Trim();

                    objUsuario.EntradasDinero = chkEntradasDinero.Checked;
                    objUsuario.SalidasDinero = chkSalidasDinero.Checked;
                    objUsuario.CancelarCompras = chkCancelarCompras.Checked;
                    objUsuario.EliminarArticulos = chkEliminaCompras.Checked;
                    objUsuario.GenerarFacturasVentas = chkGeneraFacturas.Checked;

                    objUsuario.AgregarProveedores = chkAgregaProveedores.Checked;
                    objUsuario.EditarProveedores = chkModificaProveedores.Checked;
                    objUsuario.EliminarProveedores = chkEliminaProveedores.Checked;
                    objUsuario.GenerarFacturasProveedores = chkFacturasProveedores.Checked;

                    objUsuario.AgregarProducto = chkAgregaProductos.Checked;
                    objUsuario.EditarProducto = chkModificaProductos.Checked;
                    objUsuario.EliminarProducto = chkEliminaProductos.Checked;
                    objUsuario.AgregarCategorias = chkCreaCategorias.Checked;

                    objUsuario.AgregarClientes = chkAgregaClientes.Checked;
                    objUsuario.EliminarClientes = chkEliminaClientes.Checked;
                    objUsuario.EditarClientes = chkModificaClientes.Checked;

                    objUsuario.AgregarUsuarios = chkAgregaUsuarios.Checked;
                    objUsuario.EditarUsuarios = chkModificaUsuarios.Checked;
                    objUsuario.EliminarUsuarios = chkEliminaUsuarios.Checked;



                    bool resultado = false;

                    //Agregar empleado
                    if (IdUsuario == 0)
                    {
                        if (ptbContrasenia.Visible == true)
                        {
                            int idGenerado = new DAOUsuario().agregar(objUsuario); //0
                            resultado = (idGenerado > 0);
                        }
                        else {
                            MessageBox.Show("Datos incompletos o inválidos " +
                            "\nPosiciona el cursor sobre las cajas de texto para obtener más información ",
                            "Error", MessageBoxButtons.OK
                            , MessageBoxIcon.Warning);
                        }
                        
                    }
                    else
                    {//Modificar el usuario

                        objUsuario.Id = IdUsuario;

                        resultado = new DAOUsuario().editar(objUsuario);
                    }

                    if (resultado)
                    {
                        Guardado = true;
                        MessageBox.Show("Usuario almacenado correctamente");

                        frmCrearUsuario frm = (frmCrearUsuario)this.Parent.Parent;
                        frm.cargarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Se ha encontrado un error al almacenar, verifique la información e inténtelo de nuevo más tarde");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos o inválidos " +
                    "\nPosiciona el cursor sobre las cajas de texto para obtener más información ",
                    "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length<=20 && txtUsuario.Text.Trim().Length>0)
            {
                ptbUsuario.Visible=true;
            }
            else
            {
                ptbUsuario.Visible=false;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasenia.Text.Trim().Length<=20 && txtContrasenia.Text.Trim().Length>0)
            {
                ptbContrasenia.Visible=true;
            }
            else
            {
                ptbContrasenia.Visible=false;
            }
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text.Trim().Length<=20 && txtNombreCompleto.Text.Trim().Length>0)
            {
                ptbNombre.Visible=true;
            }
            else
            {
                ptbNombre.Visible=false;
            }
        }
    }
}
