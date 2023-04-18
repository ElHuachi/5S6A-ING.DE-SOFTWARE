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
    public partial class frmClientes : Form
    {
        public bool Borrado { get; set; }
        public int a = Program.IdCodigo;
        public frmClientes()
        {
            InitializeComponent();
            //this.dgvClientes.DefaultCellStyle.Font = new Font("Tahoma", 10);
            //this.dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            cargarTabla();
            Usuario objUsuario = new DAOUsuario().ObtenerUno(a);
            btnNuevoCliente.Enabled = objUsuario.AgregarClientes;
            btnModificarCliente.Enabled = objUsuario.EditarClientes;
            btnEliminarCliente.Enabled = objUsuario.EliminarClientes;

        }

        private void cargarTabla()
        {
            dgvClientes.DataSource = new DAOClientes().ObtenerTodos();
            dgvClientes.Columns["Id"].Visible=false;
            dgvClientes.Columns["Direccion"].HeaderText = "Dirección";
            dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
            dgvClientes.Columns["CP"].HeaderText = "Código Postal";
            dgvClientes.Columns["Activo"].Visible = false;
            //foreach (DataGridViewColumn columna in dgvClientes.Columns)
            //{
            //    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                dgvClientes.DataSource = new DAOClientes().ObtenerTodos();
            }
            else
            {
                dgvClientes.DataSource = new DAOClientes().buscar(txtBuscar.Text.Trim());
            }
        }

        public void abrirFormHijo(object formhijo)
        {
            if (this.MDIClientes.Controls.Count > 0)
            {
                this.MDIClientes.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MDIClientes.Controls.Add(fh);
            this.MDIClientes.Tag = fh;
            fh.Show();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            frmAgregarClientes frm = new frmAgregarClientes();
            abrirFormHijo(new frmAgregarClientes());
            if (frm.Guardado)
            {
                //Actualizar la lista
                cargarTabla();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {                                
                int idCliente = int.Parse(dgvClientes.SelectedRows[0].Cells["Id"].Value.ToString());
                frmAgregarClientes cliente = new frmAgregarClientes(idCliente);
                abrirFormHijo(cliente);
                if (cliente.Guardado == true)
                {
                    //Actualizar la lista
                    cargarTabla();
                }
            }
            else
            {
                MessageBox.Show("Selecciona el registro a editar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar al cliente " +
                    dgvClientes.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int seleccion = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
                        //bool elimino = new DAOCategoria().eliminar(seleccion);
                        if (new DAOClientes().borradoLogico(seleccion))
                        {
                            Borrado = true;
                            MessageBox.Show("Cliente eliminado correctamente", "Eliminado",
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
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent;
            frm.abrirFormHijo(new frmClientes());
        }
    }
}
