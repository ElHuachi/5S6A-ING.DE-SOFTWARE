namespace frmLogin
{
    partial class frmContenedorMDI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MDI = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnCajeros = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.lblUsuario);
            this.panel4.Location = new System.Drawing.Point(883, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 62);
            this.panel4.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(81, 12);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(220, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Buenas tardes @usuario";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Location = new System.Drawing.Point(1222, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 26);
            this.panel3.TabIndex = 6;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Image = global::frmLogin.Properties.Resources.guion;
            this.btnMinimizar.Location = new System.Drawing.Point(1, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 26);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCategorias);
            this.panel2.Controls.Add(this.btnOrdenes);
            this.panel2.Controls.Add(this.btnCajeros);
            this.panel2.Controls.Add(this.btnProveedores);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnVentas);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 45);
            this.panel2.TabIndex = 0;
            // 
            // MDI
            // 
            this.MDI.Location = new System.Drawing.Point(1, 122);
            this.MDI.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MDI.Name = "MDI";
            this.MDI.Size = new System.Drawing.Size(1279, 593);
            this.MDI.TabIndex = 3;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnCategorias.Image = global::frmLogin.Properties.Resources.actualizar_flecha;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(703, 6);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(104, 32);
            this.btnCategorias.TabIndex = 88;
            this.btnCategorias.Text = "Categórias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOrdenes.ForeColor = System.Drawing.Color.Black;
            this.btnOrdenes.Image = global::frmLogin.Properties.Resources.rueda_dentada;
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.Location = new System.Drawing.Point(595, 6);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(104, 32);
            this.btnOrdenes.TabIndex = 5;
            this.btnOrdenes.Text = "F6 Ordenes";
            this.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Visible = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnCajeros
            // 
            this.btnCajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCajeros.ForeColor = System.Drawing.Color.Black;
            this.btnCajeros.Image = global::frmLogin.Properties.Resources.empleado;
            this.btnCajeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajeros.Location = new System.Drawing.Point(487, 6);
            this.btnCajeros.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCajeros.Name = "btnCajeros";
            this.btnCajeros.Size = new System.Drawing.Size(103, 32);
            this.btnCajeros.TabIndex = 4;
            this.btnCajeros.Text = "F5 Cajeros";
            this.btnCajeros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajeros.UseVisualStyleBackColor = true;
            this.btnCajeros.Click += new System.EventHandler(this.btnCajeros_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnProveedores.Image = global::frmLogin.Properties.Resources.nota;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(361, 6);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(123, 32);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "F4 Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = global::frmLogin.Properties.Resources.cliente__1_;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(253, 6);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(104, 32);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "F3 Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Image = global::frmLogin.Properties.Resources.codigo_de_barras__1_;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(133, 6);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(116, 32);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "F2 Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Image = global::frmLogin.Properties.Resources.carrito_de_compras;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(25, 6);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(103, 32);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "F1 Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = global::frmLogin.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(31, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 26);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frmLogin.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmContenedorMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 557);
            this.Controls.Add(this.MDI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmContenedorMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContenedorMDI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContenedorMDI_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCajeros;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.FlowLayoutPanel MDI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnCategorias;
    }
}