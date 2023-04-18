namespace frmLogin
{
    partial class frmPermisosClientes
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
            this.chkEliminaClientes = new System.Windows.Forms.CheckBox();
            this.chkModificaClientes = new System.Windows.Forms.CheckBox();
            this.chkAgregaClientes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkEliminaClientes
            // 
            this.chkEliminaClientes.AutoSize = true;
            this.chkEliminaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaClientes.Location = new System.Drawing.Point(12, 102);
            this.chkEliminaClientes.Name = "chkEliminaClientes";
            this.chkEliminaClientes.Size = new System.Drawing.Size(170, 26);
            this.chkEliminaClientes.TabIndex = 8;
            this.chkEliminaClientes.Text = "Eliminar Clientes";
            this.chkEliminaClientes.UseVisualStyleBackColor = true;
            // 
            // chkModificaClientes
            // 
            this.chkModificaClientes.AutoSize = true;
            this.chkModificaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaClientes.Location = new System.Drawing.Point(12, 57);
            this.chkModificaClientes.Name = "chkModificaClientes";
            this.chkModificaClientes.Size = new System.Drawing.Size(178, 26);
            this.chkModificaClientes.TabIndex = 7;
            this.chkModificaClientes.Text = "Modificar Clientes";
            this.chkModificaClientes.UseVisualStyleBackColor = true;
            // 
            // chkAgregaClientes
            // 
            this.chkAgregaClientes.AutoSize = true;
            this.chkAgregaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaClientes.Location = new System.Drawing.Point(12, 12);
            this.chkAgregaClientes.Name = "chkAgregaClientes";
            this.chkAgregaClientes.Size = new System.Drawing.Size(170, 26);
            this.chkAgregaClientes.TabIndex = 6;
            this.chkAgregaClientes.Text = "Agregar Clientes";
            this.chkAgregaClientes.UseVisualStyleBackColor = true;
            // 
            // frmPermisosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 372);
            this.Controls.Add(this.chkEliminaClientes);
            this.Controls.Add(this.chkModificaClientes);
            this.Controls.Add(this.chkAgregaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermisosClientes";
            this.Text = "frmPermisosClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEliminaClientes;
        private System.Windows.Forms.CheckBox chkModificaClientes;
        private System.Windows.Forms.CheckBox chkAgregaClientes;
    }
}