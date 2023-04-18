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
    public partial class frmPermisosVentas : Form
    {
        public bool Guardado { get; set; }

        private int IdUsuario;
        public frmPermisosVentas(int id) : this()
        {
            IdUsuario = id;
            //Cargar el usuario de la BD
            try
            {
                Usuario objUsuario = new DAOUsuario().ObtenerUno(id);
                chkEntradasDinero.Checked = objUsuario.EntradasDinero;
                chkSalidasDinero.Checked = objUsuario.SalidasDinero;
                chkCancelarCompras.Checked = objUsuario.CancelarCompras;
                chkEliminaCompras.Checked = objUsuario.CancelarCompras;
                chkGeneraFacturas.Checked = objUsuario.GenerarFacturasVentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public frmPermisosVentas()
        {
            InitializeComponent();
        }

        private void frmPermisosVentas_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objUsuario = new Usuario();

            objUsuario.EntradasDinero= chkEntradasDinero.Checked;
            objUsuario.SalidasDinero= chkSalidasDinero.Checked;
            objUsuario.CancelarCompras= chkCancelarCompras.Checked;
            objUsuario.CancelarCompras= chkEliminaCompras.Checked;
            objUsuario.GenerarFacturasVentas= chkGeneraFacturas.Checked;
            bool resultado = false;

            //Agregar empleado
            if (IdUsuario == 0)
            {
                int idGenerado = new DAOUsuario().agregar(objUsuario);
                resultado = (idGenerado > 0);
            }
            else
            {//Modificar el usuario

                objUsuario.Id = IdUsuario;

                resultado = new DAOUsuario().editar(objUsuario);
            }

            if (resultado)
            {
                Guardado = true;
                MessageBox.Show("Usuario almacenado correctamente");

                frmCrearUsuario frm = (frmCrearUsuario)this.Parent.Parent;
                frm.cargarTabla();
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
