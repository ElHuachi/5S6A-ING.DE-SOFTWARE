using Modelos;
using MySql.Data.MySqlClient;
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
    public partial class frmReporteInventario : Form
    {
        public frmReporteInventario()
        {
            InitializeComponent();
        }

        private void frmReporteInventario_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            MySqlDataReader tablaa;
            try
            {
                 string usuario = "root";
                 string password = "F1104";
                 string bd = "SistemaTienda";
                 string servidor = "localhost";
                 string puerto = "3306";

                MySqlConnection conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor + ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                MySqlCommand comando = new MySqlCommand("select * from inventario ",
                    conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                tablaa = comando.ExecuteReader();
                tabla.Load(tablaa);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvReporte.DataSource = tabla;
        }
    }
}
