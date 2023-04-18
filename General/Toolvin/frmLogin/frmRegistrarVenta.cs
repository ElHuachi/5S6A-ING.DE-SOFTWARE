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

namespace frmLogin
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();

        }
        private int IdProducto;
        public bool Guardado { get; set; }
        public frmRegistrarVenta(int id) : this()
        {
            IdProducto = id;
            try
            {
                Venta objVenta = new DAOVenta().ObtenerUno(id);
                objVenta.CodigoBarras = Convert.ToInt32(txtCodigo.Text.Trim());
                objVenta.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());
                objVenta.IdProductos = Convert.ToInt32(txtIdProducto.Text.Trim());
                objVenta.Descripcion = txtDescripcion.Text.Trim();
                objVenta.fecha = mcFecha.SelectionStart.Day.ToString() + "-" +
                            mcFecha.SelectionStart.Month.ToString() + "-" +
                            mcFecha.SelectionStart.Year.ToString();
                objVenta.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
                objVenta.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Venta objVenta = new Venta();
                objVenta.CodigoBarras = Convert.ToInt32(txtCodigo.Text.Trim());
                objVenta.IdUsuario = Convert.ToInt32(txtIdUsuario.Text.Trim());
                objVenta.IdProductos = Convert.ToInt32(txtIdProducto.Text.Trim());
                objVenta.Descripcion = txtDescripcion.Text.Trim();
                objVenta.fecha = mcFecha.SelectionStart.Day.ToString() + "-" +
                            mcFecha.SelectionStart.Month.ToString() + "-" +
                            mcFecha.SelectionStart.Year.ToString();
                objVenta.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
                objVenta.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                bool resultado = false;

                //Agregar Venta
                if (IdProducto == 0)
                {
                    int idGenerado = new DAOVenta().agregar(objVenta);
                    resultado = (idGenerado > 0);
                }
                else
                {//Modificar el usuario

                    objVenta.IdProductos = IdProducto;

                    resultado = new DAOVenta().editar(objVenta);
                }

                if (resultado)
                {
                    Guardado = true;
                    MessageBox.Show("Usuario almacenado correctamente");
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
    }
}
