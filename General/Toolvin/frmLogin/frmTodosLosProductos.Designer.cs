namespace frmLogin
{
    partial class frmTodosLosProductos
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
            this.MDIProductos = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarProductoLogico = new System.Windows.Forms.Button();
            this.btnModificarProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExportar = new System.Windows.Forms.Button();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.MDIProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MDIProductos
            // 
            this.MDIProductos.BackColor = System.Drawing.Color.White;
            this.MDIProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MDIProductos.Controls.Add(this.dgvDatos);
            this.MDIProductos.Location = new System.Drawing.Point(5, 116);
            this.MDIProductos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MDIProductos.Name = "MDIProductos";
            this.MDIProductos.Size = new System.Drawing.Size(1266, 476);
            this.MDIProductos.TabIndex = 71;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1264, 474);
            this.dgvDatos.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.txtBuscar);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(22, 66);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(343, 25);
            this.panel7.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Buscar ...";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(108, 3);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(234, 17);
            this.txtBuscar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBuscar, "Ingresa una letra o palabra a buscar");
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmLogin.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "ADMINISTRACION DE PRODUCTOS";
            // 
            // btnEliminarProductoLogico
            // 
            this.btnEliminarProductoLogico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminarProductoLogico.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProductoLogico.Image = global::frmLogin.Properties.Resources.eliminar;
            this.btnEliminarProductoLogico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProductoLogico.Location = new System.Drawing.Point(659, 64);
            this.btnEliminarProductoLogico.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminarProductoLogico.Name = "btnEliminarProductoLogico";
            this.btnEliminarProductoLogico.Size = new System.Drawing.Size(129, 32);
            this.btnEliminarProductoLogico.TabIndex = 3;
            this.btnEliminarProductoLogico.Text = "Eliminar producto";
            this.btnEliminarProductoLogico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProductoLogico.UseVisualStyleBackColor = true;
            this.btnEliminarProductoLogico.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProductos
            // 
            this.btnModificarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModificarProductos.ForeColor = System.Drawing.Color.Black;
            this.btnModificarProductos.Image = global::frmLogin.Properties.Resources.lapizAzul;
            this.btnModificarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProductos.Location = new System.Drawing.Point(505, 64);
            this.btnModificarProductos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(140, 32);
            this.btnModificarProductos.TabIndex = 2;
            this.btnModificarProductos.Text = "Modificar producto";
            this.btnModificarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProductos.UseVisualStyleBackColor = true;
            this.btnModificarProductos.Click += new System.EventHandler(this.btnModificarProductos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(9, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 1);
            this.panel1.TabIndex = 78;
            // 
            // btnGeneral
            // 
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGeneral.ForeColor = System.Drawing.Color.Black;
            this.btnGeneral.Image = global::frmLogin.Properties.Resources.rueda_dentada;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(802, 64);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(107, 32);
            this.btnGeneral.TabIndex = 4;
            this.btnGeneral.Text = "Administrar";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoProducto.Image = global::frmLogin.Properties.Resources.mas__1_;
            this.btnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.Location = new System.Drawing.Point(411, 64);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(80, 32);
            this.btnNuevoProducto.TabIndex = 1;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(178)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1283, 26);
            this.panel5.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRODUCTOS";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Image = global::frmLogin.Properties.Resources.salida__2_;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(923, 64);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(107, 32);
            this.btnExportar.TabIndex = 84;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Location = new System.Drawing.Point(1040, 70);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(88, 17);
            this.cbActivos.TabIndex = 88;
            this.cbActivos.Text = "Ver Inactivos";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // frmTodosLosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 512);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarProductoLogico);
            this.Controls.Add(this.btnModificarProductos);
            this.Controls.Add(this.MDIProductos);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmTodosLosProductos";
            this.Text = "frmTodosLosProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTodosLosProductos_Load);
            this.MDIProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MDIProductos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarProductoLogico;
        private System.Windows.Forms.Button btnModificarProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.CheckBox cbActivos;
    }
}