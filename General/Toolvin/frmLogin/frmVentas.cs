using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;
using Org.BouncyCastle.Asn1.X500;

namespace frmLogin
{
    public partial class frmVentas : Form
    {
        public int a = Program.IdCodigo;
        public frmVentas(String id) : this()
        {
            try
            {
                Productos productos = new DAOProductos().ObtenerUno(id);
                agregarPorCodigo(productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        public frmVentas()
        {
            InitializeComponent();
            cboProductos.DataSource = new DAOOrden().ObtenerActivos();
            cboProductos.DisplayMember = "Descripcion";
            Usuario objUsuario = new DAOUsuario().ObtenerUno(a);
            btnBorrarArt.Enabled = objUsuario.EliminarArticulos;
            dgvProductos.AutoGenerateColumns = false;
        }
        
        List<Productos> productosCompra = new List<Productos>();
        double subtotal;
        double iva;
        double total;

        int idcliente = 0;

        private void actualizar()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;
            //foreach (DataGridViewColumn columna in dgvProductos.Columns)
            //{
            //    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
            foreach (Productos producto in productosCompra)
            {
                subtotal += Math.Round(producto.PrecioVenta * producto.CantidadComprada, 2);
            }
            iva = Math.Round(subtotal * 0.16, 2);
            total = Math.Round(subtotal + iva, 2);
            lblSubtotal.Text = subtotal.ToString();
            lblIVA.Text = iva.ToString();
            lblTotal.Text = total.ToString();
            nudCantidad.Value = 1;
        }

        private void restar()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;
            //foreach (DataGridViewColumn columna in dgvProductos.Columns)
            //{
            //    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
            foreach (Productos producto in productosCompra)
            {
                subtotal = Math.Round(producto.PrecioVenta * producto.CantidadComprada, 2);
            }
            iva = Math.Round(subtotal * 0.16, 2);
            total = Math.Round(subtotal + iva, 2);
            lblSubtotal.Text = subtotal.ToString();
            lblIVA.Text = iva.ToString();
            lblTotal.Text = total.ToString();
            nudCantidad.Value = 1;
        }

        private void reiniciarCompra()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productosCompra;
            //foreach (DataGridViewColumn columna in dgvProductos.Columns)
            //{
            //    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
            foreach (Productos producto in productosCompra)
            {
                subtotal = Math.Round(producto.PrecioVenta * producto.CantidadComprada, 2);
            }
            subtotal = 0;
            iva = 0;
            total = 0;
            lblSubtotal.Text = subtotal.ToString();
            lblIVA.Text = iva.ToString();
            lblTotal.Text = total.ToString();
            nudCantidad.Value = 1;
        }


        public void btnVentas_Click(object sender, EventArgs e)
        {
            Productos objProducto = (Productos)cboProductos.SelectedItem;
            agregar(objProducto);
        }

        private void btnBorrarArt_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                subtotal = 0;
                total = 0;
                iva = 0;
                int fila = dgvProductos.CurrentRow.Index;
                productosCompra[fila].CantidadComprada = 0;
                productosCompra.RemoveAt(fila);
                restar();
            }
            else
            {
                MessageBox.Show("Selecciona un producto a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente frm = new frmSeleccionarCliente();
            frm.ShowDialog();
            lblCliente.Text = frm.NombreClienteSeleccionado.Trim();
            idcliente = frm.IdClienteSeleccionado;
        }


        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Equals("0"))
            {
                MessageBox.Show(this, "Agregue almenos un producto para completar su compra", "Error al guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            if (lblCliente.Text.Equals("Sin Seleccionar"))
            {
                MessageBox.Show(this, "Seleccione el cliente que realizara la compra", "Falta Cliente", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                return;
            }
            else
            {
                try
                {
                    Ventas objOrden = new Ventas();
                    objOrden.IdUsuario = 2; //Falta id Empleado
                    objOrden.IdCliente = idcliente;
                    objOrden.Fecha = DateTime.Now;
                    objOrden.Iva = Convert.ToDouble(lblIVA.Text.Trim());
                    objOrden.Subtotal = Convert.ToDouble(lblSubtotal.Text.Trim());
                    objOrden.Total = Convert.ToDouble(lblTotal.Text.Trim());

                    bool resultado = false;
                    //Agregar orden
                    if (objOrden.Total > 0)
                    {

                        int idGenerado = new DAOOrden().agregarDetalle(objOrden, productosCompra);
                        resultado = (idGenerado > 0);
                    }

                    if (resultado)
                    {
                        //Guardado = true;
                        MessageBox.Show("Orden almacenada correctamente", "Guardado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        foreach (Productos producto in productosCompra)
                        {
                            producto.CantidadComprada = 0;
                        }
                        productosCompra.Clear();
                        reiniciarCompra();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se ha encontrado un error al almacenar, verifique la información" +
                            " e inténtelo de nuevo más tarde", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Agregue almenos un producto para completar su compra", "Error al guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        public void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Productos p = new DAOProductos().BuscarCodigo(txtCodigo.Text);
                if (p != null)
                {

                    foreach (Productos p1 in cboProductos.Items)
                    {
                        if (p1.CodigoBarras == p.CodigoBarras)
                        {
                            p = p1;
                            break;
                        }

                    }
                    agregarPorCodigo(p);
                    txtCodigo.Text="";

                }
                else MessageBox.Show("No existe el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void agregarPorCodigo(Productos objProducto)
        {
            subtotal = 0;
            total = 0;
            iva = 0;

            //MessageBox.Show(objProducto.CantidadComprada+"");

            if (objProducto.CantidadComprada == 0)
            {
                productosCompra.Add(objProducto);
                objProducto.CantidadComprada +=(int)nudCantidad.Value;
            }
            else objProducto.CantidadComprada +=(int)nudCantidad.Value;
            actualizar();
            txtCodigo.Focus();
        }

        public void agregar(Productos objProducto)
        {
            subtotal = 0;
            total = 0;
            iva = 0;

            if (objProducto.CantidadComprada == 0)
            {
                objProducto.CantidadComprada = (int)nudCantidad.Value;
                productosCompra.Add(objProducto);
            }
            else
            {
                objProducto.CantidadComprada += (int)nudCantidad.Value;
            }
            actualizar();
            txtCodigo.Focus();
        }



        private void frmVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                btnBuscar.PerformClick();
            }
            else if (e.KeyCode == Keys.F11)
            {
                //btnMayoreo.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                //btnEntradas.PerformClick();
            }
            else if (e.KeyCode == Keys.F8)
            {
                //btnSalidas.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnBorrarArt.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                //btnVentas.PerformClick();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarArt fr = new frmBuscarArt();
            fr.ShowDialog();
            //agregar(fr.codigo);
            actualizar();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            Productos objproductos = new Productos();
            nudCantidad.Maximum = Convert.ToInt32(objproductos.Cantidad);
           
        }
    }
}
