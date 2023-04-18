namespace frmLogin
{
    partial class frmProveedores
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MDIProveedores = new System.Windows.Forms.Panel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.MDIProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1283, 26);
            this.panel5.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PROVEEDORES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(7, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 1);
            this.panel1.TabIndex = 99;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtBuscar);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(20, 70);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(343, 25);
            this.panel7.TabIndex = 93;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(101, 4);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(239, 16);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 21);
            this.label3.TabIndex = 98;
            this.label3.Text = "ADMINISTRACION DE PROVEEDORES";
            // 
            // MDIProveedores
            // 
            this.MDIProveedores.Controls.Add(this.dgvProveedores);
            this.MDIProveedores.Location = new System.Drawing.Point(10, 118);
            this.MDIProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.MDIProveedores.Name = "MDIProveedores";
            this.MDIProveedores.Size = new System.Drawing.Size(1246, 437);
            this.MDIProveedores.TabIndex = 101;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.Location = new System.Drawing.Point(0, 0);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersWidth = 62;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(1246, 437);
            this.dgvProveedores.TabIndex = 6;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // btnActivar
            // 
            this.btnActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnActivar.ForeColor = System.Drawing.Color.Black;
            this.btnActivar.Image = global::frmLogin.Properties.Resources.empleado;
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.Location = new System.Drawing.Point(1041, 63);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(159, 32);
            this.btnActivar.TabIndex = 105;
            this.btnActivar.Text = "Activar proveedor";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click_1);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMostrar.ForeColor = System.Drawing.Color.Black;
            this.btnMostrar.Image = global::frmLogin.Properties.Resources.empleado;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(1041, 28);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(159, 32);
            this.btnMostrar.TabIndex = 104;
            this.btnMostrar.Text = "Ver proveedor desactivos";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Image = global::frmLogin.Properties.Resources.excel;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(680, 63);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(107, 28);
            this.btnExportar.TabIndex = 102;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGeneral.ForeColor = System.Drawing.Color.Black;
            this.btnGeneral.Image = global::frmLogin.Properties.Resources.rueda_dentada;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(907, 28);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(130, 32);
            this.btnGeneral.TabIndex = 97;
            this.btnGeneral.Text = "Administrar";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevoProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoProveedor.Image = global::frmLogin.Properties.Resources.mass;
            this.btnNuevoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(388, 63);
            this.btnNuevoProveedor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(136, 32);
            this.btnNuevoProveedor.TabIndex = 94;
            this.btnNuevoProveedor.Text = "Nuevo proveedor";
            this.btnNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProveedor.Image = global::frmLogin.Properties.Resources.eliminar1;
            this.btnEliminarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(528, 63);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(148, 29);
            this.btnEliminarProveedor.TabIndex = 96;
            this.btnEliminarProveedor.Text = "Eliminar proveedor";
            this.btnEliminarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnModificarProveedores
            // 
            this.btnModificarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModificarProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnModificarProveedores.Image = global::frmLogin.Properties.Resources.lapizAzul;
            this.btnModificarProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProveedores.Location = new System.Drawing.Point(889, 67);
            this.btnModificarProveedores.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModificarProveedores.Name = "btnModificarProveedores";
            this.btnModificarProveedores.Size = new System.Drawing.Size(148, 32);
            this.btnModificarProveedores.TabIndex = 95;
            this.btnModificarProveedores.Text = "Modificar proveedor";
            this.btnModificarProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProveedores.UseVisualStyleBackColor = true;
            this.btnModificarProveedores.Visible = false;
            this.btnModificarProveedores.Click += new System.EventHandler(this.btnModificarProveedores_Click);
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
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 578);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.MDIProveedores);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedores);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.MDIProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnModificarProveedores;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel MDIProveedores;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnActivar;
    }
}