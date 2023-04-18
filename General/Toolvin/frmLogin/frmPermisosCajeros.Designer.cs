namespace frmLogin
{
    partial class frmPermisosCajeros
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
            this.chkEliminaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkModificaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkAgregaUsuarios = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkEliminaUsuarios
            // 
            this.chkEliminaUsuarios.AutoSize = true;
            this.chkEliminaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaUsuarios.Location = new System.Drawing.Point(12, 100);
            this.chkEliminaUsuarios.Name = "chkEliminaUsuarios";
            this.chkEliminaUsuarios.Size = new System.Drawing.Size(173, 26);
            this.chkEliminaUsuarios.TabIndex = 15;
            this.chkEliminaUsuarios.Text = "Eliminar usuarios";
            this.chkEliminaUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkModificaUsuarios
            // 
            this.chkModificaUsuarios.AutoSize = true;
            this.chkModificaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaUsuarios.Location = new System.Drawing.Point(12, 56);
            this.chkModificaUsuarios.Name = "chkModificaUsuarios";
            this.chkModificaUsuarios.Size = new System.Drawing.Size(181, 26);
            this.chkModificaUsuarios.TabIndex = 14;
            this.chkModificaUsuarios.Text = "Modificar usuarios";
            this.chkModificaUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkAgregaUsuarios
            // 
            this.chkAgregaUsuarios.AutoSize = true;
            this.chkAgregaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaUsuarios.Location = new System.Drawing.Point(12, 12);
            this.chkAgregaUsuarios.Name = "chkAgregaUsuarios";
            this.chkAgregaUsuarios.Size = new System.Drawing.Size(173, 26);
            this.chkAgregaUsuarios.TabIndex = 13;
            this.chkAgregaUsuarios.Text = "Agregar usuarios";
            this.chkAgregaUsuarios.UseVisualStyleBackColor = true;
            // 
            // frmPermisosCajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 372);
            this.Controls.Add(this.chkEliminaUsuarios);
            this.Controls.Add(this.chkModificaUsuarios);
            this.Controls.Add(this.chkAgregaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermisosCajeros";
            this.Text = "frmPermisosCajeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEliminaUsuarios;
        private System.Windows.Forms.CheckBox chkModificaUsuarios;
        private System.Windows.Forms.CheckBox chkAgregaUsuarios;
    }
}