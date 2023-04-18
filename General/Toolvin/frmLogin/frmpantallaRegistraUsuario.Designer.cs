namespace frmLogin
{
    partial class frmpantallaRegistraUsuario
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
            this.chkAdminstra = new System.Windows.Forms.CheckBox();
            this.btnPermisoCajeros = new System.Windows.Forms.Button();
            this.btnPermisoProveedores = new System.Windows.Forms.Button();
            this.btnPermisoClientes = new System.Windows.Forms.Button();
            this.MDIPermisos = new System.Windows.Forms.Panel();
            this.chkEliminaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkModificaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkEliminaClientes = new System.Windows.Forms.CheckBox();
            this.chkAgregaUsuarios = new System.Windows.Forms.CheckBox();
            this.chkModificaClientes = new System.Windows.Forms.CheckBox();
            this.chkCreaCategorias = new System.Windows.Forms.CheckBox();
            this.chkAgregaClientes = new System.Windows.Forms.CheckBox();
            this.chkEliminaProductos = new System.Windows.Forms.CheckBox();
            this.chkFacturasProveedores = new System.Windows.Forms.CheckBox();
            this.chkModificaProductos = new System.Windows.Forms.CheckBox();
            this.chkEliminaProveedores = new System.Windows.Forms.CheckBox();
            this.chkAgregaProductos = new System.Windows.Forms.CheckBox();
            this.chkGeneraFacturas = new System.Windows.Forms.CheckBox();
            this.chkModificaProveedores = new System.Windows.Forms.CheckBox();
            this.chkEliminaCompras = new System.Windows.Forms.CheckBox();
            this.chkAgregaProveedores = new System.Windows.Forms.CheckBox();
            this.chkEntradasDinero = new System.Windows.Forms.CheckBox();
            this.chkCancelarCompras = new System.Windows.Forms.CheckBox();
            this.chkSalidasDinero = new System.Windows.Forms.CheckBox();
            this.btnPermisoProductos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPermisoVentas = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.ptbContrasenia = new System.Windows.Forms.PictureBox();
            this.ptbNombre = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MDIPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAdminstra
            // 
            this.chkAdminstra.AutoSize = true;
            this.chkAdminstra.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.chkAdminstra.Location = new System.Drawing.Point(466, 224);
            this.chkAdminstra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAdminstra.Name = "chkAdminstra";
            this.chkAdminstra.Size = new System.Drawing.Size(206, 30);
            this.chkAdminstra.TabIndex = 3;
            this.chkAdminstra.Text = "Administrar permisos";
            this.chkAdminstra.UseVisualStyleBackColor = true;
            this.chkAdminstra.CheckedChanged += new System.EventHandler(this.chkAdminstra_CheckedChanged);
            // 
            // btnPermisoCajeros
            // 
            this.btnPermisoCajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPermisoCajeros.ForeColor = System.Drawing.Color.Black;
            this.btnPermisoCajeros.Image = global::frmLogin.Properties.Resources.empleado;
            this.btnPermisoCajeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisoCajeros.Location = new System.Drawing.Point(778, 268);
            this.btnPermisoCajeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermisoCajeros.Name = "btnPermisoCajeros";
            this.btnPermisoCajeros.Size = new System.Drawing.Size(109, 42);
            this.btnPermisoCajeros.TabIndex = 8;
            this.btnPermisoCajeros.Text = "Cajeros";
            this.btnPermisoCajeros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPermisoCajeros.UseVisualStyleBackColor = true;
            this.btnPermisoCajeros.Click += new System.EventHandler(this.btnPermisoCajeros_Click);
            // 
            // btnPermisoProveedores
            // 
            this.btnPermisoProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPermisoProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnPermisoProveedores.Image = global::frmLogin.Properties.Resources.nota;
            this.btnPermisoProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisoProveedores.Location = new System.Drawing.Point(615, 268);
            this.btnPermisoProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermisoProveedores.Name = "btnPermisoProveedores";
            this.btnPermisoProveedores.Size = new System.Drawing.Size(158, 42);
            this.btnPermisoProveedores.TabIndex = 7;
            this.btnPermisoProveedores.Text = "Proveedores";
            this.btnPermisoProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPermisoProveedores.UseVisualStyleBackColor = true;
            this.btnPermisoProveedores.Click += new System.EventHandler(this.btnPermisoProveedores_Click);
            // 
            // btnPermisoClientes
            // 
            this.btnPermisoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPermisoClientes.ForeColor = System.Drawing.Color.Black;
            this.btnPermisoClientes.Image = global::frmLogin.Properties.Resources.cliente__1_;
            this.btnPermisoClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisoClientes.Location = new System.Drawing.Point(487, 268);
            this.btnPermisoClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermisoClientes.Name = "btnPermisoClientes";
            this.btnPermisoClientes.Size = new System.Drawing.Size(122, 42);
            this.btnPermisoClientes.TabIndex = 6;
            this.btnPermisoClientes.Text = "Clientes";
            this.btnPermisoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPermisoClientes.UseVisualStyleBackColor = true;
            this.btnPermisoClientes.Click += new System.EventHandler(this.btnPermisoClientes_Click);
            // 
            // MDIPermisos
            // 
            this.MDIPermisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MDIPermisos.Controls.Add(this.chkEliminaUsuarios);
            this.MDIPermisos.Controls.Add(this.chkModificaUsuarios);
            this.MDIPermisos.Controls.Add(this.chkEliminaClientes);
            this.MDIPermisos.Controls.Add(this.chkAgregaUsuarios);
            this.MDIPermisos.Controls.Add(this.chkModificaClientes);
            this.MDIPermisos.Controls.Add(this.chkCreaCategorias);
            this.MDIPermisos.Controls.Add(this.chkAgregaClientes);
            this.MDIPermisos.Controls.Add(this.chkEliminaProductos);
            this.MDIPermisos.Controls.Add(this.chkFacturasProveedores);
            this.MDIPermisos.Controls.Add(this.chkModificaProductos);
            this.MDIPermisos.Controls.Add(this.chkEliminaProveedores);
            this.MDIPermisos.Controls.Add(this.chkAgregaProductos);
            this.MDIPermisos.Controls.Add(this.chkGeneraFacturas);
            this.MDIPermisos.Controls.Add(this.chkModificaProveedores);
            this.MDIPermisos.Controls.Add(this.chkEliminaCompras);
            this.MDIPermisos.Controls.Add(this.chkAgregaProveedores);
            this.MDIPermisos.Controls.Add(this.chkEntradasDinero);
            this.MDIPermisos.Controls.Add(this.chkCancelarCompras);
            this.MDIPermisos.Controls.Add(this.chkSalidasDinero);
            this.MDIPermisos.Location = new System.Drawing.Point(242, 316);
            this.MDIPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MDIPermisos.Name = "MDIPermisos";
            this.MDIPermisos.Size = new System.Drawing.Size(654, 328);
            this.MDIPermisos.TabIndex = 59;
            // 
            // chkEliminaUsuarios
            // 
            this.chkEliminaUsuarios.AutoSize = true;
            this.chkEliminaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaUsuarios.Location = new System.Drawing.Point(19, 115);
            this.chkEliminaUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminaUsuarios.Name = "chkEliminaUsuarios";
            this.chkEliminaUsuarios.Size = new System.Drawing.Size(173, 26);
            this.chkEliminaUsuarios.TabIndex = 63;
            this.chkEliminaUsuarios.Text = "Eliminar usuarios";
            this.chkEliminaUsuarios.UseVisualStyleBackColor = true;
            this.chkEliminaUsuarios.Visible = false;
            // 
            // chkModificaUsuarios
            // 
            this.chkModificaUsuarios.AutoSize = true;
            this.chkModificaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaUsuarios.Location = new System.Drawing.Point(19, 71);
            this.chkModificaUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkModificaUsuarios.Name = "chkModificaUsuarios";
            this.chkModificaUsuarios.Size = new System.Drawing.Size(181, 26);
            this.chkModificaUsuarios.TabIndex = 62;
            this.chkModificaUsuarios.Text = "Modificar usuarios";
            this.chkModificaUsuarios.UseVisualStyleBackColor = true;
            this.chkModificaUsuarios.Visible = false;
            // 
            // chkEliminaClientes
            // 
            this.chkEliminaClientes.AutoSize = true;
            this.chkEliminaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaClientes.Location = new System.Drawing.Point(19, 115);
            this.chkEliminaClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminaClientes.Name = "chkEliminaClientes";
            this.chkEliminaClientes.Size = new System.Drawing.Size(170, 26);
            this.chkEliminaClientes.TabIndex = 63;
            this.chkEliminaClientes.Text = "Eliminar Clientes";
            this.chkEliminaClientes.UseVisualStyleBackColor = true;
            this.chkEliminaClientes.Visible = false;
            // 
            // chkAgregaUsuarios
            // 
            this.chkAgregaUsuarios.AutoSize = true;
            this.chkAgregaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaUsuarios.Location = new System.Drawing.Point(19, 28);
            this.chkAgregaUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAgregaUsuarios.Name = "chkAgregaUsuarios";
            this.chkAgregaUsuarios.Size = new System.Drawing.Size(173, 26);
            this.chkAgregaUsuarios.TabIndex = 61;
            this.chkAgregaUsuarios.Text = "Agregar usuarios";
            this.chkAgregaUsuarios.UseVisualStyleBackColor = true;
            this.chkAgregaUsuarios.Visible = false;
            // 
            // chkModificaClientes
            // 
            this.chkModificaClientes.AutoSize = true;
            this.chkModificaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaClientes.Location = new System.Drawing.Point(19, 70);
            this.chkModificaClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkModificaClientes.Name = "chkModificaClientes";
            this.chkModificaClientes.Size = new System.Drawing.Size(178, 26);
            this.chkModificaClientes.TabIndex = 62;
            this.chkModificaClientes.Text = "Modificar Clientes";
            this.chkModificaClientes.UseVisualStyleBackColor = true;
            this.chkModificaClientes.Visible = false;
            // 
            // chkCreaCategorias
            // 
            this.chkCreaCategorias.AutoSize = true;
            this.chkCreaCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreaCategorias.Location = new System.Drawing.Point(19, 158);
            this.chkCreaCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCreaCategorias.Name = "chkCreaCategorias";
            this.chkCreaCategorias.Size = new System.Drawing.Size(169, 26);
            this.chkCreaCategorias.TabIndex = 64;
            this.chkCreaCategorias.Text = "Crear categorías";
            this.chkCreaCategorias.UseVisualStyleBackColor = true;
            this.chkCreaCategorias.Visible = false;
            // 
            // chkAgregaClientes
            // 
            this.chkAgregaClientes.AutoSize = true;
            this.chkAgregaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaClientes.Location = new System.Drawing.Point(19, 25);
            this.chkAgregaClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAgregaClientes.Name = "chkAgregaClientes";
            this.chkAgregaClientes.Size = new System.Drawing.Size(170, 26);
            this.chkAgregaClientes.TabIndex = 61;
            this.chkAgregaClientes.Text = "Agregar Clientes";
            this.chkAgregaClientes.UseVisualStyleBackColor = true;
            this.chkAgregaClientes.Visible = false;
            // 
            // chkEliminaProductos
            // 
            this.chkEliminaProductos.AutoSize = true;
            this.chkEliminaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaProductos.Location = new System.Drawing.Point(19, 118);
            this.chkEliminaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminaProductos.Name = "chkEliminaProductos";
            this.chkEliminaProductos.Size = new System.Drawing.Size(184, 26);
            this.chkEliminaProductos.TabIndex = 63;
            this.chkEliminaProductos.Text = "Eliminar productos";
            this.chkEliminaProductos.UseVisualStyleBackColor = true;
            this.chkEliminaProductos.Visible = false;
            // 
            // chkFacturasProveedores
            // 
            this.chkFacturasProveedores.AutoSize = true;
            this.chkFacturasProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFacturasProveedores.Location = new System.Drawing.Point(19, 159);
            this.chkFacturasProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFacturasProveedores.Name = "chkFacturasProveedores";
            this.chkFacturasProveedores.Size = new System.Drawing.Size(171, 26);
            this.chkFacturasProveedores.TabIndex = 68;
            this.chkFacturasProveedores.Text = "Generar facturas";
            this.chkFacturasProveedores.UseVisualStyleBackColor = true;
            this.chkFacturasProveedores.Visible = false;
            // 
            // chkModificaProductos
            // 
            this.chkModificaProductos.AutoSize = true;
            this.chkModificaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaProductos.Location = new System.Drawing.Point(19, 72);
            this.chkModificaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkModificaProductos.Name = "chkModificaProductos";
            this.chkModificaProductos.Size = new System.Drawing.Size(192, 26);
            this.chkModificaProductos.TabIndex = 62;
            this.chkModificaProductos.Text = "Modificar productos";
            this.chkModificaProductos.UseVisualStyleBackColor = true;
            this.chkModificaProductos.Visible = false;
            // 
            // chkEliminaProveedores
            // 
            this.chkEliminaProveedores.AutoSize = true;
            this.chkEliminaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaProveedores.Location = new System.Drawing.Point(19, 115);
            this.chkEliminaProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminaProveedores.Name = "chkEliminaProveedores";
            this.chkEliminaProveedores.Size = new System.Drawing.Size(205, 26);
            this.chkEliminaProveedores.TabIndex = 67;
            this.chkEliminaProveedores.Text = "Eliminar proveedores";
            this.chkEliminaProveedores.UseVisualStyleBackColor = true;
            this.chkEliminaProveedores.Visible = false;
            // 
            // chkAgregaProductos
            // 
            this.chkAgregaProductos.AutoSize = true;
            this.chkAgregaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaProductos.Location = new System.Drawing.Point(19, 28);
            this.chkAgregaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAgregaProductos.Name = "chkAgregaProductos";
            this.chkAgregaProductos.Size = new System.Drawing.Size(184, 26);
            this.chkAgregaProductos.TabIndex = 61;
            this.chkAgregaProductos.Text = "Agregar productos";
            this.chkAgregaProductos.UseVisualStyleBackColor = true;
            this.chkAgregaProductos.Visible = false;
            // 
            // chkGeneraFacturas
            // 
            this.chkGeneraFacturas.AutoSize = true;
            this.chkGeneraFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGeneraFacturas.Location = new System.Drawing.Point(342, 28);
            this.chkGeneraFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGeneraFacturas.Name = "chkGeneraFacturas";
            this.chkGeneraFacturas.Size = new System.Drawing.Size(171, 26);
            this.chkGeneraFacturas.TabIndex = 65;
            this.chkGeneraFacturas.Text = "Generar facturas";
            this.chkGeneraFacturas.UseVisualStyleBackColor = true;
            this.chkGeneraFacturas.Visible = false;
            // 
            // chkModificaProveedores
            // 
            this.chkModificaProveedores.AutoSize = true;
            this.chkModificaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificaProveedores.Location = new System.Drawing.Point(19, 71);
            this.chkModificaProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkModificaProveedores.Name = "chkModificaProveedores";
            this.chkModificaProveedores.Size = new System.Drawing.Size(213, 26);
            this.chkModificaProveedores.TabIndex = 66;
            this.chkModificaProveedores.Text = "Modificar proveedores";
            this.chkModificaProveedores.UseVisualStyleBackColor = true;
            this.chkModificaProveedores.Visible = false;
            // 
            // chkEliminaCompras
            // 
            this.chkEliminaCompras.AutoSize = true;
            this.chkEliminaCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaCompras.Location = new System.Drawing.Point(19, 160);
            this.chkEliminaCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminaCompras.Name = "chkEliminaCompras";
            this.chkEliminaCompras.Size = new System.Drawing.Size(172, 26);
            this.chkEliminaCompras.TabIndex = 64;
            this.chkEliminaCompras.Text = "Eliminar árticulos";
            this.chkEliminaCompras.UseVisualStyleBackColor = true;
            this.chkEliminaCompras.Visible = false;
            // 
            // chkAgregaProveedores
            // 
            this.chkAgregaProveedores.AutoSize = true;
            this.chkAgregaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregaProveedores.Location = new System.Drawing.Point(19, 28);
            this.chkAgregaProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAgregaProveedores.Name = "chkAgregaProveedores";
            this.chkAgregaProveedores.Size = new System.Drawing.Size(205, 26);
            this.chkAgregaProveedores.TabIndex = 65;
            this.chkAgregaProveedores.Text = "Agregar proveedores";
            this.chkAgregaProveedores.UseVisualStyleBackColor = true;
            this.chkAgregaProveedores.Visible = false;
            // 
            // chkEntradasDinero
            // 
            this.chkEntradasDinero.AutoSize = true;
            this.chkEntradasDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntradasDinero.Location = new System.Drawing.Point(19, 25);
            this.chkEntradasDinero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEntradasDinero.Name = "chkEntradasDinero";
            this.chkEntradasDinero.Size = new System.Drawing.Size(264, 26);
            this.chkEntradasDinero.TabIndex = 61;
            this.chkEntradasDinero.Text = "Registrar entradas de dinero";
            this.chkEntradasDinero.UseVisualStyleBackColor = true;
            this.chkEntradasDinero.Visible = false;
            // 
            // chkCancelarCompras
            // 
            this.chkCancelarCompras.AutoSize = true;
            this.chkCancelarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelarCompras.Location = new System.Drawing.Point(19, 115);
            this.chkCancelarCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCancelarCompras.Name = "chkCancelarCompras";
            this.chkCancelarCompras.Size = new System.Drawing.Size(191, 26);
            this.chkCancelarCompras.TabIndex = 63;
            this.chkCancelarCompras.Text = "Cancelar comprasa";
            this.chkCancelarCompras.UseVisualStyleBackColor = true;
            this.chkCancelarCompras.Visible = false;
            // 
            // chkSalidasDinero
            // 
            this.chkSalidasDinero.AutoSize = true;
            this.chkSalidasDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalidasDinero.Location = new System.Drawing.Point(19, 70);
            this.chkSalidasDinero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSalidasDinero.Name = "chkSalidasDinero";
            this.chkSalidasDinero.Size = new System.Drawing.Size(250, 26);
            this.chkSalidasDinero.TabIndex = 62;
            this.chkSalidasDinero.Text = "Registrar salidas de dinero";
            this.chkSalidasDinero.UseVisualStyleBackColor = true;
            this.chkSalidasDinero.Visible = false;
            // 
            // btnPermisoProductos
            // 
            this.btnPermisoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPermisoProductos.ForeColor = System.Drawing.Color.Black;
            this.btnPermisoProductos.Image = global::frmLogin.Properties.Resources.codigo_de_barras__1_;
            this.btnPermisoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisoProductos.Location = new System.Drawing.Point(352, 268);
            this.btnPermisoProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermisoProductos.Name = "btnPermisoProductos";
            this.btnPermisoProductos.Size = new System.Drawing.Size(128, 42);
            this.btnPermisoProductos.TabIndex = 5;
            this.btnPermisoProductos.Text = "Productos";
            this.btnPermisoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPermisoProductos.UseVisualStyleBackColor = true;
            this.btnPermisoProductos.Click += new System.EventHandler(this.btnPermisoProductos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Nuevo cajero";
            // 
            // btnPermisoVentas
            // 
            this.btnPermisoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPermisoVentas.ForeColor = System.Drawing.Color.Black;
            this.btnPermisoVentas.Image = global::frmLogin.Properties.Resources.carrito_de_compras;
            this.btnPermisoVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisoVentas.Location = new System.Drawing.Point(242, 268);
            this.btnPermisoVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermisoVentas.Name = "btnPermisoVentas";
            this.btnPermisoVentas.Size = new System.Drawing.Size(104, 42);
            this.btnPermisoVentas.TabIndex = 4;
            this.btnPermisoVentas.Text = "Ventas";
            this.btnPermisoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPermisoVentas.UseVisualStyleBackColor = true;
            this.btnPermisoVentas.Click += new System.EventHandler(this.btnPermisoVentas_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(178)))));
            this.btnGuardarUsuario.Image = global::frmLogin.Properties.Resources.guardar_el_archivo;
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(1025, 669);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(212, 38);
            this.btnGuardarUsuario.TabIndex = 10;
            this.btnGuardarUsuario.Text = "Guardar usuario";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreCompleto.Location = new System.Drawing.Point(339, 168);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(472, 32);
            this.txtNombreCompleto.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNombreCompleto, "Máximo 20 caractéres");
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 54;
            this.label4.Text = "Nombre completo";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasenia.Location = new System.Drawing.Point(339, 122);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(389, 32);
            this.txtContrasenia.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtContrasenia, "Máximo 20 caractéres");
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(207, 125);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(105, 26);
            this.lblpass.TabIndex = 52;
            this.lblpass.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(339, 79);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(389, 32);
            this.txtUsuario.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtUsuario, "Máximo 20 caractéres");
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Usuario";
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.Image = global::frmLogin.Properties.Resources.comprobar__1_;
            this.ptbUsuario.Location = new System.Drawing.Point(735, 79);
            this.ptbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(34, 35);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUsuario.TabIndex = 60;
            this.ptbUsuario.TabStop = false;
            this.ptbUsuario.Visible = false;
            // 
            // ptbContrasenia
            // 
            this.ptbContrasenia.Image = global::frmLogin.Properties.Resources.comprobar__1_;
            this.ptbContrasenia.Location = new System.Drawing.Point(735, 122);
            this.ptbContrasenia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbContrasenia.Name = "ptbContrasenia";
            this.ptbContrasenia.Size = new System.Drawing.Size(34, 35);
            this.ptbContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbContrasenia.TabIndex = 61;
            this.ptbContrasenia.TabStop = false;
            this.ptbContrasenia.Visible = false;
            // 
            // ptbNombre
            // 
            this.ptbNombre.Image = global::frmLogin.Properties.Resources.comprobar__1_;
            this.ptbNombre.Location = new System.Drawing.Point(818, 168);
            this.ptbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbNombre.Name = "ptbNombre";
            this.ptbNombre.Size = new System.Drawing.Size(34, 35);
            this.ptbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNombre.TabIndex = 62;
            this.ptbNombre.TabStop = false;
            this.ptbNombre.Visible = false;
            // 
            // frmpantallaRegistraUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 718);
            this.Controls.Add(this.ptbNombre);
            this.Controls.Add(this.ptbContrasenia);
            this.Controls.Add(this.ptbUsuario);
            this.Controls.Add(this.chkAdminstra);
            this.Controls.Add(this.btnPermisoCajeros);
            this.Controls.Add(this.btnPermisoProveedores);
            this.Controls.Add(this.btnPermisoClientes);
            this.Controls.Add(this.MDIPermisos);
            this.Controls.Add(this.btnPermisoProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPermisoVentas);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmpantallaRegistraUsuario";
            this.Text = "frmpantallaRegistraUsuario";
            this.MDIPermisos.ResumeLayout(false);
            this.MDIPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAdminstra;
        private System.Windows.Forms.Button btnPermisoCajeros;
        private System.Windows.Forms.Button btnPermisoProveedores;
        private System.Windows.Forms.Button btnPermisoClientes;
        private System.Windows.Forms.Panel MDIPermisos;
        private System.Windows.Forms.Button btnPermisoProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPermisoVentas;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkGeneraFacturas;
        private System.Windows.Forms.CheckBox chkEliminaCompras;
        private System.Windows.Forms.CheckBox chkEntradasDinero;
        private System.Windows.Forms.CheckBox chkCancelarCompras;
        private System.Windows.Forms.CheckBox chkSalidasDinero;
        private System.Windows.Forms.CheckBox chkFacturasProveedores;
        private System.Windows.Forms.CheckBox chkEliminaProveedores;
        private System.Windows.Forms.CheckBox chkModificaProveedores;
        private System.Windows.Forms.CheckBox chkAgregaProveedores;
        private System.Windows.Forms.CheckBox chkCreaCategorias;
        private System.Windows.Forms.CheckBox chkEliminaProductos;
        private System.Windows.Forms.CheckBox chkModificaProductos;
        private System.Windows.Forms.CheckBox chkAgregaProductos;
        private System.Windows.Forms.CheckBox chkEliminaClientes;
        private System.Windows.Forms.CheckBox chkModificaClientes;
        private System.Windows.Forms.CheckBox chkAgregaClientes;
        private System.Windows.Forms.CheckBox chkEliminaUsuarios;
        private System.Windows.Forms.CheckBox chkModificaUsuarios;
        private System.Windows.Forms.CheckBox chkAgregaUsuarios;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.PictureBox ptbContrasenia;
        private System.Windows.Forms.PictureBox ptbNombre;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}