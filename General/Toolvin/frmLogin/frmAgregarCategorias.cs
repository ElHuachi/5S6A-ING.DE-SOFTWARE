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
    public partial class frmAgregarCategorias : Form
    {
        public bool Guardado { get; set; }
        public frmAgregarCategorias()
        {
            InitializeComponent();
        }

        private int idCategoria;

        public frmAgregarCategorias(int id) : this()
        {
            idCategoria = id;
            //Cargar el usuario de la BD
            try
            {
                Categoria objCategoria = new DAOCategoria().ObtenerUno(id);
                txtNombre.Text = objCategoria.Nombre;
                txtDescripcion.Text = objCategoria.Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ptbNombre.Visible==true && ptbDescripcion.Visible==true && cbActivo.Checked== true)
            {
                try
                {
                    Categoria objCategoria = new Categoria();
                    objCategoria.Nombre = txtNombre.Text.Trim();
                    objCategoria.Descripcion = txtDescripcion.Text.Trim();
                    objCategoria.Activo = Convert.ToInt32(cbActivo.Checked == true); ;
                    bool resultado = false;
                    //Agregar empleado
                    if (idCategoria == 0)
                    {
                        int idGenerado = new DAOCategoria().agregar(objCategoria);
                        resultado = (idGenerado > 0);

                    }
                    else
                    {//Modificar el usuario
                        objCategoria.Id = idCategoria;
                        resultado = new DAOCategoria().editar(objCategoria);
                    }

                    if (resultado)
                    {
                        Guardado = true;
                        MessageBox.Show("Categoría almacenada correctamente", "Guardado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        frmCategorias frm = (frmCategorias)this.Parent.Parent;
                        frm.cargarTabla();
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

                    MessageBox.Show(this, ex.Message, "Error al guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length<=40 && txtNombre.Text.Trim().Length>0)
            {
                ptbNombre.Visible=true;
            }
            else
            {
                ptbNombre.Visible=false;
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


    }
}
