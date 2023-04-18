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
    public partial class frmBuscarArt : Form
    {
        public Productos codigo { set; get; }
        public frmBuscarArt()
        {
            InitializeComponent();
            cargarTabla();
        }

        public void cargarTabla()
        {
            dgvDatos.DataSource = new DAOProductos().ObtenerTodos();
            dgvDatos.Columns["IdProductos"].Visible = false;
            dgvDatos.Columns["CantidadComprada"].Visible = false;
            dgvDatos.Columns["TotalCompra"].Visible = false;
            dgvDatos.Columns["CodigoBarras"].Visible = false;
            dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvDatos.Columns["VentaPorUnidad"].Visible = false;
            dgvDatos.Columns["VentaAGranel"].Visible = false;
            dgvDatos.Columns["VentaporPaquete"].Visible = false;
            dgvDatos.Columns["PrecioCosto"].Visible = false;
            dgvDatos.Columns["Ganancia"].Visible = false;
            dgvDatos.Columns["PrecioVenta"].HeaderText = "Precio de venta";
            dgvDatos.Columns["Cantidad"].HeaderText = "Inventario";
            dgvDatos.Columns["categorias"].Visible = false;
        }

        private void frmBuscarArt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                cargarTabla();
            }
            else
            {
                dgvDatos.DataSource = new DAOProductos().buscar(txtBuscar.Text.Trim());
            }
        
        }

        private void btnModificarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent.Parent;
            frm.abrirFormHijo(new frmTodosLosProductos());
            btnModificarProductos.PerformClick();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent;
            frm.abrirFormHijo(new frmTodosLosProductos());
            btnEliminarProducto.PerformClick();
        }
        

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {

                Productos p = new DAOProductos().BuscarCodigo(dgvDatos.SelectedRows[0].Cells["CodigoBarras"].Value.ToString());
                frmVentas frm = new frmVentas();
                //frm.agregarPorCodigo(p);
                frm.agregar(p);
                //codigo = p;                
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un registro", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

    }
}
