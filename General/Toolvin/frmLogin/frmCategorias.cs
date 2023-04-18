using Datos;
using frmLogin;
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
    public partial class frmCategorias : Form
    {
        public bool Borrado { get; set; }
        public frmCategorias()
        {
            InitializeComponent();
            cargarTabla();
            btnEliminar.Visible = false;
        }

        public void cargarTabla()
        {
            dgvCategorias.DataSource = new DAOCategoria().ObtenerTodos();
            //dgvCategorias.Columns["Id"].Visible=false;
            dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";
            dgvCategorias.Columns["Activo"].Visible = false;
            //foreach (DataGridViewColumn columna in dgvCategorias.Columns)
            //{
            //    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
        }

        public void abrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                dgvCategorias.DataSource = new DAOCategoria().ObtenerTodos();
            }
            else
            {
                dgvCategorias.DataSource = new DAOCategoria().buscar(txtBuscar.Text.Trim());

            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategorias frm = new frmAgregarCategorias();
            abrirFormHijo(new frmAgregarCategorias());
            if (frm.Guardado)
            {
                //Actualizar la lista
                cargarTabla();
            }            
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                int idCategoria = int.Parse(dgvCategorias.SelectedRows[0].Cells["Id"].Value.ToString());
                frmAgregarCategorias categoria = new frmAgregarCategorias(idCategoria);
                categoria.ShowDialog();
                if (categoria.Guardado == true)
                {
                    //Actualizar la lista
                    cargarTabla();
                }
            }
            else
            {
                MessageBox.Show("Selecciona la categoría a editar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una categoría a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar la categoría " +
                    dgvCategorias.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int seleccion = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value.ToString());
                        if (new DAOCategoria().borradoLógico(seleccion))
                        {
                            Borrado = true;
                            MessageBox.Show("Categoría eliminada correctamente", "Eliminado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            cargarTabla();
        }

        private void dgvCategorias_Click(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(dgvCategorias.SelectedRows[0].Cells["Id"].Value.ToString());
            frmAgregarCategorias categoria = new frmAgregarCategorias(idCategoria);
            abrirFormHijo(categoria);
            if (categoria.Guardado == true)
            {
                //Actualizar la lista
                cargarTabla();
            }
        }



        private void btnGeneral_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent;
            frm.abrirFormHijo(new frmCategorias());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una categoría a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar la categoría " +
                    dgvCategorias.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int seleccion = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value.ToString());
                        if (new DAOCategoria().eliminar(seleccion))
                        {
                            Borrado = true;
                            MessageBox.Show("Categoría eliminada correctamente", "Eliminado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            cargarTabla();
            btnEliminar.Visible = false;

        }


        private void cbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInactivos.Checked == true)
            {
                dgvCategorias.DataSource = new DAOCategoria().ObtenerInactivos();
                btnGeneral.Enabled = true;
                
            }
            else
            {
                dgvCategorias.DataSource = new DAOCategoria().ObtenerTodos();
                btnGeneral.Enabled = true;
            }
        }
    }
}
