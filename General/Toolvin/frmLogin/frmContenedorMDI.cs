using Categorias_Clientes;
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
    public partial class frmContenedorMDI : Form
    {
        public frmContenedorMDI()
        {
            InitializeComponent();
            abrirFormHijo(new frmVentas());
            btnVentas.Enabled = false;
        }

        public void asigna(string id)
        {
            lblUsuario.Text = "Le atiende: " + id;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin a = new frmLogin();
            a.ShowDialog();
        }

        public void abrirFormHijo(object formhijo) {
            if (this.MDI.Controls.Count > 0)
            {
                this.MDI.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MDI.Controls.Add(fh);
            this.MDI.Tag = fh;
            fh.Show();                               
        }

        private void btnCajeros_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmCrearUsuario());
            //btnProductos.Enabled = true;
            //btnClientes.Enabled = true;
            //btnProveedores.Enabled = true;
            //btnCajeros.Enabled = false;
            //btnOrdenes.Enabled = true;
            btnVentas.Enabled = true;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmTodosLosProductos());
            //btnProductos.Enabled = false;
            //btnClientes.Enabled = true;
            //btnProveedores.Enabled = true;
            //btnCajeros.Enabled = true;
            //btnOrdenes.Enabled = true;
            btnVentas.Enabled = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmClientes());
            //btnProductos.Enabled = true;
            //btnClientes.Enabled = false;
            //btnProveedores.Enabled = true;
            //btnCajeros.Enabled = true;
            //btnOrdenes.Enabled = true;
            btnVentas.Enabled = true;
        }


        private void frmContenedorMDI_Load(object sender, EventArgs e)
        {
            abrirFormHijo(new frmVentas());
            frmLogin frm = new frmLogin();           
        }


        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmVentas());
            //btnProductos.Enabled = true;
            //btnClientes.Enabled = true;
            //btnProveedores.Enabled = true;
            //btnCajeros.Enabled = true;
            //btnOrdenes.Enabled = true;
            btnVentas.Enabled = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmContenedorMDI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) { 
                btnVentas.PerformClick();
            }else if (e.KeyCode == Keys.F2)
            {
                btnProductos.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnClientes.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnProveedores.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnCajeros.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnOrdenes.PerformClick();
            }
        }

        public void activa(int id)
        {

            /// Cargar el usuario
            if (id != 0)
            {
                try
                {
                    Usuario objUsuario = new DAOUsuario().ObtenerUno(id);

                    /// Activar o desactivar botón de productos según permisos
                    if (objUsuario.AgregarProducto == false && objUsuario.EliminarProducto == false && objUsuario.EditarProducto == false)
                        btnProductos.Enabled = false;
                    else
                        btnProductos.Enabled = true;

                    ///Permiso área de Clientes
                    if (objUsuario.AgregarClientes == false && objUsuario.EditarClientes == false && objUsuario.EliminarClientes == false)
                        btnClientes.Enabled = false;
                    else
                        btnClientes.Enabled = true;

                    ///Permiso área de Usuarios
                    if (objUsuario.AgregarUsuarios == false && objUsuario.EditarUsuarios == false && objUsuario.EliminarUsuarios == false)
                        btnCajeros.Enabled = false;
                    else
                        btnCajeros.Enabled = true;
                    ///Permiso proveedores
                    if (objUsuario.AgregarProveedores == false && objUsuario.EditarProveedores == false && objUsuario.EliminarProveedores  == false)
                        btnProveedores.Enabled = false;
                    else
                        btnProveedores.Enabled = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
            }

        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmListaOrdenes());
            btnProductos.Enabled = true;
            btnClientes.Enabled = true;
            btnProveedores.Enabled = true;
            btnCajeros.Enabled = true;
            btnOrdenes.Enabled = false;
            btnVentas.Enabled = true;

        }
        public int a = Program.IdCodigo;
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmProveedores());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new DAOUsuario().ObtenerUno(a);
            btnCategorias.Enabled = objUsuario.AgregarCategorias;
            abrirFormHijo(new frmCategorias());
        }
    }
}
