using Datos;
using Modelos;
using Northwind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorias_Clientes
{
    public partial class frmListaOrdenes : Form
    {
        public frmListaOrdenes()
        {
            InitializeComponent();
            this.dgvOrdenes.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvOrdenes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvOrdenes.DataSource=new DAOOrden().ObtenerTodas();
            dgvOrdenes.Columns["IdCliente"].HeaderText="Id Cliente";
            dgvOrdenes.Columns["IdUsuario"].HeaderText="Id Usuario";
            dgvOrdenes.Columns["Fecha"].HeaderText="Fecha y Hora";
            dgvOrdenes.Columns["Activo"].Visible= false;
            dgvOrdenes.Columns["Usuario"].Visible= false;
            dgvOrdenes.Columns["Cliente"].Visible= false;
            foreach (DataGridViewColumn columna in dgvOrdenes.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            dialogo.FileName = "Registros de Ventas.xlsx";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                new ExportarXLS().CreateExcelFile(dgvOrdenes, dialogo.FileName);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtInicio.Text.Equals("") || txtFin.Text.Equals(""))
            {
                MessageBox.Show("Falta inidcar rango de fechas", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (rdbClientes.Checked)
                    {
                        dgvOrdenes.DataSource= new DAOOrden().FiltrarPorClientes
                        (txtInicio.Text.Trim(), txtFin.Text.Trim());
                    }
                    else if(rdbDetallado.Checked)
                    {
                        dgvOrdenes.DataSource= new DAOOrden().BuscarPorFecha
                        (txtInicio.Text.Trim(), txtFin.Text.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formato de fechas incorrecto", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        string mes;
 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListaOrdenes_Load(object sender, EventArgs e)
        {

        }
    }
}
