using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace frmLogin
{

    public partial class frmNuevoProducto : Form
    {
        public bool Guardado { get; set; }

        private string IdProducto;
        public frmNuevoProducto(string id) : this()
        {
            IdProducto = id;
            //Cargar el usuario de la BD
            try
            {
                Productos objProducto = new DAOProductos().ObtenerUno(id);
                txtCodigo.Text = objProducto.CodigoBarras.ToString();
                txtDescripcion.Text = objProducto.Descripcion;
                rdbUnidad.Checked = objProducto.VentaPorUnidad;
                rdbGranel.Checked = objProducto.VentaAGranel;
                rdbpaquete.Checked = objProducto.VentaPorPaquete;
                txtCosto.Text = objProducto.PrecioCosto.ToString();
                txtGanancia.Text = objProducto.Ganancia.ToString();
                txtVenta.Text = objProducto.PrecioVenta.ToString();
                cboCategoria.SelectedValue = objProducto.categorias;
                txtCantidad.Text = objProducto.Cantidad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        public int a = Program.IdCodigo;
        public frmNuevoProducto()
        {
            InitializeComponent();
            List<Categoria> lista = new DAOCategoria().ObtenerTodos();
            cboCategoria.DataSource = lista;
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "ID";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ptbCodigo.Visible==true && ptbDescripcion.Visible==true && ptbCosto.Visible==true &&
                ptbGanancia.Visible==true && ptbVenta.Visible==true && ptbCategoria.Visible==true &&
                ptbCantidad.Visible==true )
            {
                try
                {
                    Productos objProducto = new Productos();
                    objProducto.CodigoBarras = txtCodigo.Text.Trim();
                    objProducto.Descripcion = txtDescripcion.Text.Trim();
                    objProducto.VentaPorUnidad = rdbUnidad.Checked;
                    objProducto.VentaAGranel = rdbGranel.Checked;
                    objProducto.VentaPorPaquete = rdbpaquete.Checked;
                    objProducto.PrecioCosto = Convert.ToDouble(txtCosto.Text.Trim());
                    objProducto.Ganancia = Convert.ToDouble(txtGanancia.Text.Trim());
                    objProducto.PrecioVenta = Convert.ToDouble(txtVenta.Text.Trim());
                    objProducto.Cantidad =  Convert.ToDouble(txtCantidad.Text.Trim());
                    objProducto.categorias = Convert.ToInt32(cboCategoria.SelectedValue);
                    objProducto.Activo = Convert.ToInt32(cbActivo.Checked==true);
                    bool resultado = false;

                    //Agregar empleado
                    if (IdProducto==null)
                    {
                        int idGenerado = new DAOProductos().agregar(objProducto);
                        resultado = (idGenerado > 0);
                    }
                    else
                    {//Modificar el usuario

                        //objProducto.IdProductos = IdProducto;
                        objProducto.CodigoBarras = Convert.ToString(IdProducto);
                        resultado = new DAOProductos().editar(objProducto);
                    }

                    if (resultado)
                    {
                        Guardado = true;
                        MessageBox.Show("Producto almacenado correctamente");
                        txtCodigo.Text = "";
                        txtDescripcion.Text = "";
                        txtCosto.Text = "";
                        txtGanancia.Text = "";
                        txtVenta.Text = "";
                        txtCantidad.Text = "";
                    }
                    else
                    {
                        Guardado = true;
                        MessageBox.Show("Producto almacenado correctamente");
                        txtCodigo.Text = "";
                        txtDescripcion.Text = "";
                        txtCosto.Text = "";
                        txtGanancia.Text = "";
                        txtVenta.Text = "";
                        txtCantidad.Text = "";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos o inválidos " +
                    "\nPosiciona el cursor sobre las cajas de texto para obtener más información ",
                    "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
        }

        public void abrirFormHijo(object formhijo)
        {
            if (this.panelContenedorRegistrar.Controls.Count > 0)
            {
                this.panelContenedorRegistrar.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorRegistrar.Controls.Add(fh);
            this.panelContenedorRegistrar.Tag = fh;
            fh.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent.Parent.Parent;
            frm.abrirFormHijo(new frmCategorias());

            //frmNuevoProducto frm = (frmNuevoProducto)this;
            //frm.abrirFormHijo(new frmCategorias());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent.Parent.Parent;
            frm.abrirFormHijo(new frmTodosLosProductos());
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Length<=20 && txtCodigo.Text.Trim().Length>0
                && Regex.IsMatch(txtCodigo.Text.Trim(), "^[0-9]{11,13}$"))
            {
                ptbCodigo.Visible=true;
            }
            else
            {
                ptbCodigo.Visible=false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim().Length<=200 && txtDescripcion.Text.Trim().Length>0)
            {
                ptbDescripcion.Visible=true;
            }
            else
            {
                ptbDescripcion.Visible=false;
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (txtCosto.Text.Trim().Length<=13 && Regex.IsMatch(txtCosto.Text.Trim(), "^[0-9]{1,10}((.)[0-9]{2})?$"))
            {
                ptbCosto.Visible=true;
            }
            else
            {
                ptbCosto.Visible=false;
            }
        }

        private void txtGanancia_TextChanged(object sender, EventArgs e)
        {
            if (txtGanancia.Text.Trim().Length<=13 && Regex.IsMatch(txtGanancia.Text.Trim(), "^[0-9]{1,10}((.)[0-9]{2})?$"))
            {
                ptbGanancia.Visible=true;
            }
            else
            {
                ptbGanancia.Visible=false;
            }
        }

        private void txtVenta_TextChanged(object sender, EventArgs e)
        {
            if (txtVenta.Text.Trim().Length<=13 && Regex.IsMatch(txtVenta.Text.Trim(), "^[0-9]{1,10}((.)[0-9]{2})?$"))
            {
                ptbVenta.Visible=true;
            }
            else
            {
                ptbVenta.Visible=false;
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedItem.Equals(""))
            {
                ptbCategoria.Visible=false;
            }
            else
            {
                ptbCategoria.Visible=true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (rdbGranel.Checked == true)
            {
                toolTip1.SetToolTip(txtCantidad, "Cantidades decimales con dos digitos después del punto");
                if (Regex.IsMatch(txtCantidad.Text.Trim(), "^[0-9]{1,10}((.)[0-9]{2})?$"))
                {
                    ptbCantidad.Visible = true;
                }
                else
                {
                    ptbCantidad.Visible = false;
                }
            }else if(rdbpaquete.Checked==true)
            {
                toolTip1.SetToolTip(txtCantidad, "Cantidades enteras");
                if (txtCantidad.Text.Trim().Length <= 13 && Regex.IsMatch(txtCantidad.Text.Trim(), "^[0-9]{1,10}?$"))
                {
                    ptbCantidad.Visible = true;
                }
                else
                {
                    ptbCantidad.Visible = false;
                }
            }else if (rdbUnidad.Checked == true)
            {
                toolTip1.SetToolTip(txtCantidad, "Cantidades enteras");
                if (txtCantidad.Text.Trim().Length <= 13 && Regex.IsMatch(txtCantidad.Text.Trim(), "^[0-9]{1,10}?$"))
                {
                    ptbCantidad.Visible = true;
                }
                else
                {
                    ptbCantidad.Visible = false;
                }
            }
            
        }

        private void txtGanancia_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                double sum = Convert.ToDouble(txtCosto.Text) + Convert.ToDouble(txtGanancia.Text);
                txtVenta.Text = sum.ToString();
            }
        }

        private void cbActivo_CheckedChanged(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(cbActivo.Checked) == 1 || Convert.ToInt32(cbActivo.Checked)== 2)
            {

            }
        }
    }
    }

