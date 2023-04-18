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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
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
            this.MDIVenta.Controls.Add(fh);
            this.MDIVenta.Tag = fh;
            fh.Show();
        }

        private void btnRegistrarInventario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmRegistrarInventario());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmReporteInventario());
        }
    }
}
