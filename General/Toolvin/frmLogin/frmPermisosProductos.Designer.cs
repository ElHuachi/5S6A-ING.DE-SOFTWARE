namespace frmLogin
{
    partial class frmPermisosProductos
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
            this.chkEliminaProductos = new System.Windows.Forms.CheckBox();
            this.chkModificaProductos = new System.Windows.Forms.CheckBox();
            this.chkAgregaProductos = new System.Windows.Forms.CheckBox();
            this.chkCreaCategorias = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkEliminaProductos
            // 
            this.chkEliminaProductos.AutoSize = true;
            this.chkEliminaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaProductos.Location = new System.Drawing.Point(12, 102);
            this.chkEliminaProductos.Name = "chkEliminaProductos";
            this.chkEliminaProductos.Size = new System.Drawing.Size(184, 26);
            this.chkEliminaProductos.TabIndex = 5;
            this.chkEliminaProductos.Text = "Eliminar productos";
            this.chkEliminaProductos.UseVisualStyleBackColor = true;
            // 
            // chkModificaProductos
            // 
            this.chkModificaProductos.AutoSize = true;
            this.chkModificaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaProductos.Location = new System.Drawing.Point(12, 57);
            this.chkModificaProductos.Name = "chkModificaProductos";
            this.chkModificaProductos.Size = new System.Drawing.Size(192, 26);
            this.chkModificaProductos.TabIndex = 4;
            this.chkModificaProductos.Text = "Modificar productos";
            this.chkModificaProductos.UseVisualStyleBackColor = true;
            // 
            // chkAgregaProductos
            // 
            this.chkAgregaProductos.AutoSize = true;
            this.chkAgregaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaProductos.Location = new System.Drawing.Point(12, 12);
            this.chkAgregaProductos.Name = "chkAgregaProductos";
            this.chkAgregaProductos.Size = new System.Drawing.Size(184, 26);
            this.chkAgregaProductos.TabIndex = 3;
            this.chkAgregaProductos.Text = "Agregar productos";
            this.chkAgregaProductos.UseVisualStyleBackColor = true;
            // 
            // chkCreaCategorias
            // 
            this.chkCreaCategorias.AutoSize = true;
            this.chkCreaCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreaCategorias.Location = new System.Drawing.Point(12, 143);
            this.chkCreaCategorias.Name = "chkCreaCategorias";
            this.chkCreaCategorias.Size = new System.Drawing.Size(169, 26);
            this.chkCreaCategorias.TabIndex = 6;
            this.chkCreaCategorias.Text = "Crear categorías";
            this.chkCreaCategorias.UseVisualStyleBackColor = true;
            // 
            // frmPermisosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 372);
            this.Controls.Add(this.chkCreaCategorias);
            this.Controls.Add(this.chkEliminaProductos);
            this.Controls.Add(this.chkModificaProductos);
            this.Controls.Add(this.chkAgregaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermisosProductos";
            this.Text = "frmPermisosProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEliminaProductos;
        private System.Windows.Forms.CheckBox chkModificaProductos;
        private System.Windows.Forms.CheckBox chkAgregaProductos;
        private System.Windows.Forms.CheckBox chkCreaCategorias;
    }
}