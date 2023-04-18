using Datos;
using Modelos;
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

namespace frmLogin
{
    public partial class frmAgregarproveedores : Form
    {        
        public bool Guardado { get; set; }        

        public frmAgregarproveedores()
        {
            InitializeComponent();
        }
        private int idProveedor;
        public frmAgregarproveedores(int id) : this()
        {
            idProveedor = id;
            //Cargar el usuario de la BD            
            try
            {
                Proveedores objproveedor = new DAOProveedores().ObtenerUno(id);
                txtProveedor.Text = objproveedor.proveedor;
                txtCorreo.Text = objproveedor.correo;
                txtTelefono.Text = objproveedor.telefono;
                txtDireccion.Text = objproveedor.direccion;
                txtDescripcion.Text = objproveedor.descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ptbProveedor.Visible == true && ptbCorreo.Visible == true && ptbTelefono.Visible == true 
                && ptbDireccion.Visible == true && ptbDescripcion.Visible == true)
            {
                try
                {                    
                    //Hacer objeto de clase proveedor el cual sirvira para llenar el constructor con los valores ingresados
                    Proveedores objProveedor = new Proveedores();
                    objProveedor.proveedor = txtProveedor.Text;
                    objProveedor.correo = txtCorreo.Text;
                    objProveedor.telefono = txtTelefono.Text;
                    objProveedor.direccion = txtDireccion.Text;
                    objProveedor.descripcion = txtDescripcion.Text;
                    objProveedor.activo = 1;
                    //Se manda llamar el metodo agregar de la clase DAOProveedores y le pasamos los parametros con la informacion
                    int idGenerado = new DAOProveedores().agregar(objProveedor);
                    MessageBox.Show("Información almacenada");
                    //Crear un objeto en el que se van a guardar todos los componentes que tiene un panel
                    //Para que no se pierdan al momento de invocar el otro panel
                    frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent.Parent.Parent;
                    frm.abrirFormHijo(new frmProveedores());
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible almacenar la informacion");
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent.Parent.Parent;
            frm.abrirFormHijo(new frmProveedores());
            this.Close();
        } 

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            //Comparar si lo que se esta ingresando en la cadena es cumple con la expresion regular
            /*Es expresion regular nos indica que la cadena puede numeros y letra, el simbolo de mas indica que 
            puede contener una o mas letras o numeros despues debe aparecer el @
             */
            if (Regex.IsMatch(txtCorreo.Text, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*")) 
            { 
                ptbCorreo.Visible = true;
            }
            else
            {
                ptbCorreo.Visible = false;
            }
        }

        private void ptbGanancia_Click(object sender, EventArgs e)
        {

        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtProveedor.Text.Trim().Length <= 30 && txtProveedor.Text.Trim().Length >= 3)
            {
                ptbProveedor.Visible = true;
            }
            else
            {
                ptbProveedor.Visible = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim().Length <= 15 && txtTelefono.Text.Trim().Length >= 10)
            {
                ptbTelefono.Visible = true;
            }
            else
            {
                ptbTelefono.Visible = false;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim().Length <= 200 && txtDireccion.Text.Trim().Length > 5)
            {
                ptbDireccion.Visible = true;
            }
            else
            {
                ptbDireccion.Visible = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim().Length <= 200 && txtDescripcion.Text.Trim().Length > 4)
            {
                ptbDescripcion.Visible = true;
            }
            else
            {
                ptbDescripcion.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
