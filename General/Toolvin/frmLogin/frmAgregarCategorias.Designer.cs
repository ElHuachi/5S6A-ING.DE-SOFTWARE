namespace frmLogin
{
    partial class frmAgregarCategorias
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbDescripcion = new System.Windows.Forms.PictureBox();
            this.ptbNombre = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.pbActivo = new System.Windows.Forms.PictureBox();
            this.txtActivo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F);
            this.label2.Location = new System.Drawing.Point(63, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F);
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "REGISTRAR CATEGORÍA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.pbActivo);
            this.panel1.Controls.Add(this.ptbDescripcion);
            this.panel1.Controls.Add(this.txtActivo);
            this.panel1.Controls.Add(this.ptbNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 369);
            this.panel1.TabIndex = 0;
            // 
            // ptbDescripcion
            // 
            this.ptbDescripcion.Image = global::frmLogin.Properties.Resources.comprobar__1_;
            this.ptbDescripcion.Location = new System.Drawing.Point(597, 111);
            this.ptbDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ptbDescripcion.Name = "ptbDescripcion";
            this.ptbDescripcion.Size = new System.Drawing.Size(23, 23);
            this.ptbDescripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDescripcion.TabIndex = 11;
            this.ptbDescripcion.TabStop = false;
            this.ptbDescripcion.Visible = false;
            // 
            // ptbNombre
            // 
            this.ptbNombre.Image = global::frmLogin.Properties.Resources.comprobar__1_;
            this.ptbNombre.Location = new System.Drawing.Point(473, 38);
            this.ptbNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ptbNombre.Name = "ptbNombre";
            this.ptbNombre.Size = new System.Drawing.Size(23, 23);
            this.ptbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNombre.TabIndex = 10;
            this.ptbNombre.TabStop = false;
            this.ptbNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(155, 38);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(314, 24);
            this.txtNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNombre, "Máximo 30 caractéres");
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(155, 79);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(438, 77);
            this.txtDescripcion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDescripcion, "Máximo 200 caractéres");
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(178)))));
            this.btnCancelar.Image = global::frmLogin.Properties.Resources.cerca__1_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(454, 220);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(178)))));
            this.btnGuardar.Image = global::frmLogin.Properties.Resources.guardar_el_archivo;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(588, 220);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Categoría";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(177, 220);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(55, 17);
            this.cbActivo.TabIndex = 88;
            this.cbActivo.Text = "activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // pbActivo
            // 
            this.pbActivo.Image = global::frmLogin.Properties.Resources.comprobar__1_;
            this.pbActivo.Location = new System.Drawing.Point(275, 220);
            this.pbActivo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbActivo.Name = "pbActivo";
            this.pbActivo.Size = new System.Drawing.Size(23, 23);
            this.pbActivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActivo.TabIndex = 90;
            this.pbActivo.TabStop = false;
            this.pbActivo.Visible = false;
            // 
            // txtActivo
            // 
            this.txtActivo.AutoSize = true;
            this.txtActivo.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtActivo.Location = new System.Drawing.Point(103, 220);
            this.txtActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(44, 18);
            this.txtActivo.TabIndex = 89;
            this.txtActivo.Text = "activo";
            // 
            // frmAgregarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmAgregarCategorias";
            this.Text = "frmAgregarCategorias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox ptbNombre;
        private System.Windows.Forms.PictureBox ptbDescripcion;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.PictureBox pbActivo;
        private System.Windows.Forms.Label txtActivo;
    }
}