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
    public partial class frmCrearUsuario : Form
    {
        public int a = Program.IdCodigo;
        public bool Borrado { get; set; }
        public frmCrearUsuario()
        {
            InitializeComponent();
        
            cargarTabla();
            Usuario objUsuario = new DAOUsuario().ObtenerUno(a);
            btnNuevoCajero.Enabled = objUsuario.AgregarUsuarios;
            btnEliminarCajero.Enabled=objUsuario.EliminarUsuarios;
            if (objUsuario.EditarUsuarios!=true) {
                dgvDatos.Enabled = false;
            }
        }
        
        private void abrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        public void cargarTabla()
        {
            dgvDatos.DataSource = new DAOUsuario().ObtenerTodos();
            dgvDatos.Columns["Id"].Visible = false;
            dgvDatos.Columns["Nombre"].HeaderText = "Nombre";
            dgvDatos.Columns["Nombre_Usuario"].HeaderText = "Nombre de usuario";
            dgvDatos.Columns["Password"].Visible = false;
            dgvDatos.Columns["EntradasDinero"].Visible = false;
            dgvDatos.Columns["SalidasDinero"].Visible = false;
            dgvDatos.Columns["CancelarCompras"].Visible = false;
            dgvDatos.Columns["EliminarArticulos"].Visible = false;
            dgvDatos.Columns["GenerarFacturasVentas"].Visible = false;
            dgvDatos.Columns["AgregarProveedores"].Visible = false;
            dgvDatos.Columns["EditarProveedores"].Visible = false;
            dgvDatos.Columns["EliminarProveedores"].Visible = false;
            dgvDatos.Columns["GenerarFacturasProveedores"].Visible = false;
            dgvDatos.Columns["AgregarProducto"].Visible = false;
            dgvDatos.Columns["EditarProducto"].Visible = false;
            dgvDatos.Columns["EliminarProducto"].Visible = false;
            dgvDatos.Columns["AgregarCategorias"].Visible = false;
            dgvDatos.Columns["AgregarClientes"].Visible = false;
            dgvDatos.Columns["EditarClientes"].Visible = false;
            dgvDatos.Columns["EliminarClientes"].Visible = false;
            dgvDatos.Columns["AgregarUsuarios"].Visible = false;
            dgvDatos.Columns["EliminarUsuarios"].Visible = false;
            dgvDatos.Columns["EditarUsuarios"].Visible = false;
        }

        public void btnNuevoCajero_Click(object sender, EventArgs e)
        {            
            frmpantallaRegistraUsuario frm = new frmpantallaRegistraUsuario();
            abrirFormHijo(new frmpantallaRegistraUsuario());            

            if (frm.Guardado)
            {
                //Actualizar la lista
                cargarTabla();
            }
        }        

        private void dgvDatos_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(dgvDatos.SelectedRows[0].Cells["ID"].Value.ToString());
            frmpantallaRegistraUsuario frm = new frmpantallaRegistraUsuario(idEmpleado);
            abrirFormHijo(frm);
            if (frm.Guardado)
            {
                cargarTabla();
            }
        }

        private void btnEliminarCajero_Click(object sender, EventArgs e)
        {
            //if (dgvDatos.SelectedRows[0].Cells["Nombre de usuario"].Value.ToString().Equals("admin"))
            //{
            //    MessageBox.Show("No se puede eliminar esté usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
                if (dgvDatos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona el usuario a eliminar", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de eliminar el usuario " +
                        dgvDatos.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirmación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int seleccion = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
                            if (new DAOUsuario().eliminar(seleccion))
                            {
                                Borrado = true;
                                MessageBox.Show("Usuario eliminado correctamente", "Eliminado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                cargarTabla();
            //}
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                dgvDatos.DataSource = new DAOUsuario().ObtenerTodos();
            }
            else
            {
                dgvDatos.DataSource = new DAOUsuario().buscar(txtBuscar.Text.Trim());

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent;
            frm.abrirFormHijo(new frmCrearUsuario());
        }
    }
}
