namespace frmLogin
{
    partial class frmPermisosProveedores
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
            this.chkAgregaProveedores = new System.Windows.Forms.CheckBox();
            this.chkModificaProveedores = new System.Windows.Forms.CheckBox();
            this.chkEliminaProveedores = new System.Windows.Forms.CheckBox();
            this.chkGenerafacturas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkAgregaProveedores
            // 
            this.chkAgregaProveedores.AutoSize = true;
            this.chkAgregaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaProveedores.Location = new System.Drawing.Point(12, 12);
            this.chkAgregaProveedores.Name = "chkAgregaProveedores";
            this.chkAgregaProveedores.Size = new System.Drawing.Size(205, 26);
            this.chkAgregaProveedores.TabIndex = 9;
            this.chkAgregaProveedores.Text = "Agregar proveedores";
            this.chkAgregaProveedores.UseVisualStyleBackColor = true;
            // 
            // chkModificaProveedores
            // 
            this.chkModificaProveedores.AutoSize = true;
            this.chkModificaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaProveedores.Location = new System.Drawing.Point(12, 56);
            this.chkModificaProveedores.Name = "chkModificaProveedores";
            this.chkModificaProveedores.Size = new System.Drawing.Size(213, 26);
            this.chkModificaProveedores.TabIndex = 10;
            this.chkModificaProveedores.Text = "Modificar proveedores";
            this.chkModificaProveedores.UseVisualStyleBackColor = true;
            // 
            // chkEliminaProveedores
            // 
            this.chkEliminaProveedores.AutoSize = true;
            this.chkEliminaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaProveedores.Location = new System.Drawing.Point(12, 100);
            this.chkEliminaProveedores.Name = "chkEliminaProveedores";
            this.chkEliminaProveedores.Size = new System.Drawing.Size(205, 26);
            this.chkEliminaProveedores.TabIndex = 11;
            this.chkEliminaProveedores.Text = "Eliminar proveedores";
            this.chkEliminaProveedores.UseVisualStyleBackColor = true;
            // 
            // chkGenerafacturas
            // 
            this.chkGenerafacturas.AutoSize = true;
            this.chkGenerafacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenerafacturas.Location = new System.Drawing.Point(12, 144);
            this.chkGenerafacturas.Name = "chkGenerafacturas";
            this.chkGenerafacturas.Size = new System.Drawing.Size(171, 26);
            this.chkGenerafacturas.TabIndex = 12;
            this.chkGenerafacturas.Text = "Generar facturas";
            this.chkGenerafacturas.UseVisualStyleBackColor = true;
            // 
            // frmPermisosProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 372);
            this.Controls.Add(this.chkGenerafacturas);
            this.Controls.Add(this.chkEliminaProveedores);
            this.Controls.Add(this.chkModificaProveedores);
            this.Controls.Add(this.chkAgregaProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermisosProveedores";
            this.Text = "frmPermisosProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAgregaProveedores;
        private System.Windows.Forms.CheckBox chkModificaProveedores;
        private System.Windows.Forms.CheckBox chkEliminaProveedores;
        private System.Windows.Forms.CheckBox chkGenerafacturas;
    }
}