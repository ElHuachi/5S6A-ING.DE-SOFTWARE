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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class frmTodosLosProductos : Form
    {
        public bool Borrado { get; set; }
        public int a = Program.IdCodigo;
        public frmTodosLosProductos()
        {
            InitializeComponent();
            cargarTabla();
            btnGeneral.Enabled = false;
            Usuario objUsuario = new DAOUsuario().ObtenerUno(a);
            btnNuevoProducto.Enabled = objUsuario.AgregarProducto;
            btnModificarProductos.Enabled=objUsuario.EditarProducto;
            btnEliminarProductoLogico.Enabled = objUsuario.EliminarProducto;
            //btnEliminarProducto.Visible = false;
            //btnEliminarProducto.Enabled = objUsuario.EliminarProducto;
            



        }

        public void abrirFormHijo(object formhijo)
        {
            if (this.MDIProductos.Controls.Count > 0)
            {
                this.MDIProductos.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MDIProductos.Controls.Add(fh);
            this.MDIProductos.Tag = fh;
            fh.Show();
        }

        public void cargarTabla()
        {
            dgvDatos.DataSource = new DAOProductos().ObtenerTodos();
            dgvDatos.Columns["CodigoBarras"].HeaderText = "Codigo de barras";
            dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvDatos.Columns["VentaPorUnidad"].HeaderText = "Venta por unidad";
            dgvDatos.Columns["VentaAGranel"].HeaderText = "Venta a granel";
            dgvDatos.Columns["VentaporPaquete"].HeaderText = "Venta por paquete";
            dgvDatos.Columns["PrecioCosto"].HeaderText = "Precio costo";
            dgvDatos.Columns["Ganancia"].HeaderText = "Ganancia";
            dgvDatos.Columns["PrecioVenta"].HeaderText = "Precio de venta";
            dgvDatos.Columns["Cantidad"].HeaderText = "Cantidad en existencia";
            dgvDatos.Columns["categorias"].Visible = false;
            dgvDatos.Columns["IdProductos"].Visible =false;
            dgvDatos.Columns["CantidadComprada"].Visible =false;
            dgvDatos.Columns["TotalCompra"].Visible =false;
            dgvDatos.Columns["NombreCategoria"].HeaderText="Categoría";
            dgvDatos.Columns["Activo"].HeaderText = "Activo";
        }


        public void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                dgvDatos.DataSource = new DAOProductos().ObtenerTodos();
            }
            else
            {
                dgvDatos.DataSource = new DAOProductos().buscar(txtBuscar.Text.Trim());
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {            
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent;
            frm.abrirFormHijo(new frmTodosLosProductos());
        }

        public void btnModificarProductos_Click(object sender, EventArgs e)
        {
            String idProducto =dgvDatos.SelectedRows[0].Cells["CodigoBarras"].Value.ToString();
            frmNuevoProducto frm = new frmNuevoProducto(idProducto);
            abrirFormHijo(frm);
            if (frm.Guardado)
            {
                cargarTabla();
            }
            btnGeneral.Enabled = true;
            btnNuevoProducto.Enabled = true;
            btnModificarProductos.Enabled = false;
            btnEliminarProductoLogico.Enabled = true;
        }

        public void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar el producto " + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string seleccion = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
                        if (new DAOProductos().eliminar(seleccion))
                        {
                            Borrado = true;
                            MessageBox.Show("Producto eliminado correctamente", "Eliminado",
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
            btnNuevoProducto.Enabled = true;
            btnModificarProductos.Enabled = true;
            //btnEliminarProducto.Enabled = false;
        }

        public void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmNuevoProducto frm = new frmNuevoProducto();
            abrirFormHijo(new frmNuevoProducto());
            if (frm.Guardado)
            {
                //Actualizar la lista
                cargarTabla();
            }
            btnGeneral.Enabled = true;
            btnNuevoProducto.Enabled = false;
            btnModificarProductos.Enabled = true;
            btnEliminarProductoLogico.Enabled = true;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            dialogo.FileName = "Productos_Sistema_Tienda.xlsx";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                new ExportarXLS().CreateExcelFile(dgvDatos, dialogo.FileName);
            }
        }

        private void frmTodosLosProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar el producto " + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string seleccion = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
                        if (new DAOProductos().eliminar(seleccion))
                        {
                            Borrado = true;
                            MessageBox.Show("Producto eliminado correctamente", "Eliminado",
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
            btnNuevoProducto.Enabled = true;
            btnModificarProductos.Enabled = true;
            
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if(cbActivos.Checked == true)
            {
                dgvDatos.DataSource = new DAOProductos().ObtenerInactivos();
                btnGeneral.Enabled = true;
            }
            else
            {
                dgvDatos.DataSource = new DAOProductos().ObtenerTodos();
                btnGeneral.Enabled = true;
            }
        }


    }
}




