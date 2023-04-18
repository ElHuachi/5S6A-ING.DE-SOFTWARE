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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            abrirFormHijo(new frmNuevoProducto());
        }

        private void abrirFormHijo(object formhijo)
        {
            //if (this.MDIProductos.Controls.Count > 0)
            //{
            //    this.MDIProductos.Controls.RemoveAt(0);
            //}
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MDIProductos.Controls.Add(fh);
            this.MDIProductos.Tag = fh;
            fh.Show();
        }

        public void btnPermisoVentas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmNuevoProducto());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmModificarProducto());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmVentanaEliminarProducto());
        }
    }
}
