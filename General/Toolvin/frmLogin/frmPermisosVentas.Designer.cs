namespace frmLogin
{
    partial class frmPermisosVentas
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
            this.chkEntradasDinero = new System.Windows.Forms.CheckBox();
            this.chkSalidasDinero = new System.Windows.Forms.CheckBox();
            this.chkCancelarCompras = new System.Windows.Forms.CheckBox();
            this.chkEliminaCompras = new System.Windows.Forms.CheckBox();
            this.chkGeneraFacturas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkEntradasDinero
            // 
            this.chkEntradasDinero.AutoSize = true;
            this.chkEntradasDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntradasDinero.Location = new System.Drawing.Point(12, 12);
            this.chkEntradasDinero.Name = "chkEntradasDinero";
            this.chkEntradasDinero.Size = new System.Drawing.Size(264, 26);
            this.chkEntradasDinero.TabIndex = 0;
            this.chkEntradasDinero.Text = "Registrar entradas de dinero";
            this.chkEntradasDinero.UseVisualStyleBackColor = true;
            // 
            // chkSalidasDinero
            // 
            this.chkSalidasDinero.AutoSize = true;
            this.chkSalidasDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalidasDinero.Location = new System.Drawing.Point(12, 57);
            this.chkSalidasDinero.Name = "chkSalidasDinero";
            this.chkSalidasDinero.Size = new System.Drawing.Size(250, 26);
            this.chkSalidasDinero.TabIndex = 1;
            this.chkSalidasDinero.Text = "Registrar salidas de dinero";
            this.chkSalidasDinero.UseVisualStyleBackColor = true;
            // 
            // chkCancelarCompras
            // 
            this.chkCancelarCompras.AutoSize = true;
            this.chkCancelarCompras.Checked = true;
            this.chkCancelarCompras.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCancelarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelarCompras.Location = new System.Drawing.Point(12, 102);
            this.chkCancelarCompras.Name = "chkCancelarCompras";
            this.chkCancelarCompras.Size = new System.Drawing.Size(191, 26);
            this.chkCancelarCompras.TabIndex = 2;
            this.chkCancelarCompras.Text = "Cancelar comprasa";
            this.chkCancelarCompras.UseVisualStyleBackColor = true;
            // 
            // chkEliminaCompras
            // 
            this.chkEliminaCompras.AutoSize = true;
            this.chkEliminaCompras.Checked = true;
            this.chkEliminaCompras.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEliminaCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaCompras.Location = new System.Drawing.Point(12, 147);
            this.chkEliminaCompras.Name = "chkEliminaCompras";
            this.chkEliminaCompras.Size = new System.Drawing.Size(172, 26);
            this.chkEliminaCompras.TabIndex = 3;
            this.chkEliminaCompras.Text = "Eliminar árticulos";
            this.chkEliminaCompras.UseVisualStyleBackColor = true;
            // 
            // chkGeneraFacturas
            // 
            this.chkGeneraFacturas.AutoSize = true;
            this.chkGeneraFacturas.Checked = true;
            this.chkGeneraFacturas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGeneraFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGeneraFacturas.Location = new System.Drawing.Point(335, 12);
            this.chkGeneraFacturas.Name = "chkGeneraFacturas";
            this.chkGeneraFacturas.Size = new System.Drawing.Size(171, 26);
            this.chkGeneraFacturas.TabIndex = 6;
            this.chkGeneraFacturas.Text = "Generar facturas";
            this.chkGeneraFacturas.UseVisualStyleBackColor = true;
            // 
            // frmPermisosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(655, 372);
            this.Controls.Add(this.chkGeneraFacturas);
            this.Controls.Add(this.chkEliminaCompras);
            this.Controls.Add(this.chkCancelarCompras);
            this.Controls.Add(this.chkSalidasDinero);
            this.Controls.Add(this.chkEntradasDinero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermisosVentas";
            this.Text = "frmPermisosVentas";
            this.Click += new System.EventHandler(this.frmPermisosVentas_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEntradasDinero;
        private System.Windows.Forms.CheckBox chkSalidasDinero;
        private System.Windows.Forms.CheckBox chkCancelarCompras;
        private System.Windows.Forms.CheckBox chkEliminaCompras;
        private System.Windows.Forms.CheckBox chkGeneraFacturas;
    }
}