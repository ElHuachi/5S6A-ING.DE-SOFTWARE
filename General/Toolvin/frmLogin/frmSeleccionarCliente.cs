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
    public partial class frmSeleccionarCliente : Form
    {
        public Cliente ClienteSeleccionado { get; set; }
        public int IdClienteSeleccionado { get; set; }
        public String NombreClienteSeleccionado { get; set; }
        public frmSeleccionarCliente()
        {
            InitializeComponent();
            this.dgvClientes.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvClientes.DataSource = new DAOClientes().ObtenerTodos();
            //dgvClientes.Columns["Id"].Visible=false;
            dgvClientes.Columns["Direccion"].Visible = false;
            dgvClientes.Columns["Colonia"].Visible = false;
            dgvClientes.Columns["Municipio"].Visible = false;
            dgvClientes.Columns["Estado"].Visible = false;
            dgvClientes.Columns["CP"].Visible = false;
            dgvClientes.Columns["Telefono"].Visible = false;
            dgvClientes.Columns["Activo"].Visible = false;
            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                int seleccion = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
                ClienteSeleccionado = new DAOClientes().ObtenerUno(seleccion);
                IdClienteSeleccionado = ClienteSeleccionado.Id;
                NombreClienteSeleccionado = ClienteSeleccionado.Nombre;
                this.Close();
            }
        }

        private void frmSeleccionarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NombreClienteSeleccionado == null)
            {
                e.Cancel = true;
                MessageBox.Show("Seleccione el cliente para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
