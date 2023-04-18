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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnMostrar.Visible = false;
            btnOcultar.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            DAOUsuario dao = new DAOUsuario();
            Usuario usuario = dao.IniciarSesion(txtUsuario.Text, txtpassword.Text);
            if (usuario != null)
            {
                Program.IdCodigo = usuario.Id;
                frmContenedorMDI fh = new frmContenedorMDI();
                fh.asigna(usuario.Nombre);
                fh.activa(usuario.Id);

                this.Hide();
                fh.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos");
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOcultar_MouseDown(object sender, MouseEventArgs e)
        {
            btnMostrar.Visible = true;
            btnOcultar.Visible = false;
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btnMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            btnOcultar.Visible = true;
            btnMostrar.Visible = false;
            txtpassword.UseSystemPasswordChar = false;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Equals(""))
            {
                btnMostrar.Visible = false;
                btnOcultar.Visible = false;
            }
            else {
                btnMostrar.Visible = true;
                btnOcultar.Visible = true;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnSalir.PerformClick();
            }
        }

        private void lblOlvide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Si olvido su clve, porfavor ingrese con el perfil de administraor o contacte con él", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
