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
using Northwind;

namespace frmLogin
{
    public partial class frmProveedores : Form
    {
        public bool Borrado { get; set; }
        public int a = Program.IdCodigo;

        public frmProveedores()
        {
            Usuario obj = new DAOUsuario().ObtenerUno(a);
            InitializeComponent();
            cargarTabla();
            btnNuevoProveedor.Enabled = obj.AgregarProveedores;
            btnModificarProveedores.Enabled = obj.EditarProveedores;
            btnEliminarProveedor.Enabled = obj.EliminarProveedores;
        }
        public void abrirFormHijo(object formhijo)
        {
            //Se agrega un panel por asi decirlo estatico es decir que sirve como base para no mostrar mas ventanas
            if (this.MDIProveedores.Controls.Count > 0)
            {
                this.MDIProveedores.Controls.RemoveAt(0);
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MDIProveedores.Controls.Add(fh);
            this.MDIProveedores.Tag = fh;
            fh.Show();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            frmContenedorMDI frm = (frmContenedorMDI)this.Parent.Parent;
            frm.abrirFormHijo(new frmProveedores());
        }
        private void cargarTabla()
        {
            //Crear una tabla con los datos que devuelve el metodo ObtenerTodos
            dgvProveedores.DataSource = new DAOProveedores().ObtenerTodos();
            //Se le cambia el nombre de la columna para que aparezca con la primera letra mayuscula
            dgvProveedores.Columns["ID"].Visible = false;
            dgvProveedores.Columns["proveedor"].HeaderText = "Proveedor";
            dgvProveedores.Columns["correo"].HeaderText = "Correo";
            dgvProveedores.Columns["telefono"].HeaderText = "Telefono";
            dgvProveedores.Columns["direccion"].HeaderText = "Direccion";
            dgvProveedores.Columns["descripcion"].HeaderText = "Descripcion";
            dgvProveedores.Columns["activo"].HeaderText = "Activo";
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmAgregarproveedores());
        }
        
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un proveedor a eliminar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar al proveedor " + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //Almacena el id del proveedor
                        string seleccion = dgvProveedores.SelectedRows[0].Cells[0].Value.ToString();
                        //Manda llamar el metodo eliminar y recibe como parametro el id del proveedor
                        if (new DAOProveedores().eliminar(seleccion))
                        {
                            Borrado = true;
                            MessageBox.Show("Producto eliminado correctamente", "Eliminado",
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                dgvProveedores.DataSource = new DAOProveedores().ObtenerTodos();
            }
            else
            {
                dgvProveedores.DataSource = new DAOProveedores().buscar(txtBuscar.Text.Trim());

            }
        }

        private void btnModificarProveedores_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                int idproveedor = int.Parse(dgvProveedores.SelectedRows[0].Cells["Id"].Value.ToString());
                frmAgregarproveedores proveedor = new frmAgregarproveedores(idproveedor);
                abrirFormHijo(proveedor);
                if (proveedor.Guardado == true)
                {
                    //Actualizar la lista
                    cargarTabla();
                }
            }
            else
            {
                MessageBox.Show("Selecciona el registro a editar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            dialogo.FileName = "Proveedores.xlsx";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                new ExportarXLS().CreateExcelFile(dgvProveedores, dialogo.FileName);
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            cargarTablaDesactivos();
        }

        private void btnActivar_Click_1(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un proveedor a activar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de activar al proveedor " + "?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //Almacena el id del proveedor
                        string seleccion = dgvProveedores.SelectedRows[0].Cells[0].Value.ToString();
                        //Manda llamar el metodo eliminar y recibe como parametro el id del proveedor
                        if (new DAOProveedores().activarProveedor(seleccion))
                        {
                            Borrado = true;
                            MessageBox.Show("Proveedor activado correctamente", "Activado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            cargarTablaDesactivos();
        }
    

        private void cargarTablaDesactivos()
        {
            //Crear una tabla con los datos que devuelve el metodo ObtenerTodos
            dgvProveedores.DataSource = new DAOProveedores().ObtenerTodosDesactivos();
            //Se le cambia el nombre de la columna para que aparezca con la primera letra mayuscula
            dgvProveedores.Columns["ID"].Visible = false;
            dgvProveedores.Columns["proveedor"].HeaderText = "Proveedor";
            dgvProveedores.Columns["correo"].HeaderText = "Correo";
            dgvProveedores.Columns["telefono"].HeaderText = "Telefono";
            dgvProveedores.Columns["direccion"].HeaderText = "Direccion";
            dgvProveedores.Columns["descripcion"].HeaderText = "Descripcion";
            dgvProveedores.Columns["activo"].HeaderText = "Activo";
        }
    }
}
