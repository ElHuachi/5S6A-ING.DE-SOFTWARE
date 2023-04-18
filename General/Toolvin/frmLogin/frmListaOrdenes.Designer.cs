using System.Reflection.Emit;
using System.Windows.Forms;

namespace Categorias_Clientes
{
    partial class frmListaOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbClientes = new System.Windows.Forms.RadioButton();
            this.rdbDia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDetallado = new System.Windows.Forms.RadioButton();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(14, 128);
            this.dgvOrdenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersWidth = 51;
            this.dgvOrdenes.RowTemplate.Height = 24;
            this.dgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenes.Size = new System.Drawing.Size(788, 222);
            this.dgvOrdenes.TabIndex = 0;
            this.dgvOrdenes.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(344, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ventas";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(778, 58);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(135, 49);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnExportar, "Exportar tabla a un archivo .xlsx");
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(14, 86);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnBuscar, "Aplicar filtro de búsqueda seleccionado");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label6.Location = new System.Drawing.Point(306, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label7.Location = new System.Drawing.Point(306, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbClientes
            // 
            this.rdbClientes.AutoSize = true;
            this.rdbClientes.Location = new System.Drawing.Point(18, 8);
            this.rdbClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbClientes.Name = "rdbClientes";
            this.rdbClientes.Size = new System.Drawing.Size(91, 24);
            this.rdbClientes.TabIndex = 0;
            this.rdbClientes.TabStop = true;
            this.rdbClientes.Text = "Clientes";
            this.rdbClientes.UseVisualStyleBackColor = true;
            // 
            // rdbDia
            // 
            this.rdbDia.AutoSize = true;
            this.rdbDia.Location = new System.Drawing.Point(117, 8);
            this.rdbDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDia.Name = "rdbDia";
            this.rdbDia.Size = new System.Drawing.Size(58, 24);
            this.rdbDia.TabIndex = 2;
            this.rdbDia.Text = "Día";
            this.rdbDia.UseVisualStyleBackColor = true;
            this.rdbDia.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDetallado);
            this.groupBox1.Controls.Add(this.rdbDia);
            this.groupBox1.Controls.Add(this.rdbClientes);
            this.groupBox1.Location = new System.Drawing.Point(123, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdbDetallado
            // 
            this.rdbDetallado.AutoSize = true;
            this.rdbDetallado.Location = new System.Drawing.Point(18, 49);
            this.rdbDetallado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDetallado.Name = "rdbDetallado";
            this.rdbDetallado.Size = new System.Drawing.Size(102, 24);
            this.rdbDetallado.TabIndex = 1;
            this.rdbDetallado.TabStop = true;
            this.rdbDetallado.Text = "Detallado";
            this.rdbDetallado.UseVisualStyleBackColor = true;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(457, 59);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(193, 26);
            this.txtInicio.TabIndex = 30;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(457, 97);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(193, 26);
            this.txtFin.TabIndex = 31;
            // 
            // frmListaOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 362);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrdenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmListaOrdenes";
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Label label2;
        private Button btnExportar;
        private Button btnBuscar;
        private ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private RadioButton rdbClientes;
        private RadioButton rdbDia;
        private GroupBox groupBox1;
        private RadioButton rdbDetallado;
        private TextBox txtInicio;
        private TextBox txtFin;
    }
}