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
    public partial class frmRegistrarInventario : Form
    {
        public frmRegistrarInventario()
        {
            InitializeComponent();
        }
        private int IdProducto;
        public bool Guardado { get; set; }
        public frmRegistrarInventario(int id) : this()
        {
            IdProducto = id;
            try
            {
                Inventario objInventario = new DAOInventario().ObtenerUno(id);
                objInventario.CodigoBarras = Convert.ToInt32(txtCodigo.Text.Trim());
                objInventario.IdProducto = Convert.ToInt32(txtIdUsuario.Text.Trim());
                objInventario.Descripcion = txtDescripcion.Text.Trim();
                objInventario.Entrada = Convert.ToInt32(txtEntrada.Text.Trim());
                objInventario.Salida = Convert.ToInt32(txtSalida.Text.Trim());
                objInventario.Stock = Convert.ToInt32(txtStock.Text.Trim());

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
                Inventario objInventario = new Inventario();
                objInventario.CodigoBarras = Convert.ToInt32(txtCodigo.Text.Trim());
                objInventario.IdProducto = Convert.ToInt32(txtIdUsuario.Text.Trim());
                objInventario.Descripcion = txtDescripcion.Text.Trim();
                objInventario.Entrada = Convert.ToInt32(txtEntrada.Text.Trim());
                objInventario.Salida = Convert.ToInt32(txtSalida.Text.Trim());
                objInventario.Stock = Convert.ToInt32(txtStock.Text.Trim());
                bool resultado = false;

                //Agregar Venta
                if (IdProducto == 0)
                {
                    int idGenerado = new DAOInventario().agregar(objInventario);
                    resultado = (idGenerado > 0);
                }
                else
                {//Modificar el usuario

                    objInventario.IdProducto = IdProducto;

                    resultado = new DAOInventario().editar(objInventario);
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
