
namespace Sistema.Presentacion
{
    partial class FrmUsuario
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
            this.Err_errIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_acceso = new System.Windows.Forms.GroupBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.cbo_tipoDocumento = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_numDocumento = new System.Windows.Forms.TextBox();
            this.lbl_numDoc = new System.Windows.Forms.Label();
            this.lbl_tipoDocumento = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.chk_seleccionar = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Err_errIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grp_acceso.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Err_errIcono
            // 
            this.Err_errIcono.ContainerControl = this;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(768, 327);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(147, 23);
            this.btn_actualizar.TabIndex = 8;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Los datos que estan con (*) son obligatorios";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(971, 327);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(149, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(768, 327);
            this.btn_insertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(147, 23);
            this.btn_insertar.TabIndex = 5;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(155, 23);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(153, 22);
            this.txt_id.TabIndex = 4;
            this.txt_id.Visible = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(155, 103);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(319, 22);
            this.txt_nombre.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grp_acceso);
            this.tabPage2.Controls.Add(this.cbo_tipoDocumento);
            this.tabPage2.Controls.Add(this.txt_telefono);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_direccion);
            this.tabPage2.Controls.Add(this.lbl_direccion);
            this.tabPage2.Controls.Add(this.txt_numDocumento);
            this.tabPage2.Controls.Add(this.lbl_numDoc);
            this.tabPage2.Controls.Add(this.lbl_tipoDocumento);
            this.tabPage2.Controls.Add(this.lbl_Rol);
            this.tabPage2.Controls.Add(this.cbo_rol);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_insertar);
            this.tabPage2.Controls.Add(this.txt_id);
            this.tabPage2.Controls.Add(this.txt_nombre);
            this.tabPage2.Controls.Add(this.lbl_nombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1392, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grp_acceso
            // 
            this.grp_acceso.Controls.Add(this.txt_clave);
            this.grp_acceso.Controls.Add(this.txt_email);
            this.grp_acceso.Controls.Add(this.label5);
            this.grp_acceso.Controls.Add(this.lbl_password);
            this.grp_acceso.Controls.Add(this.lbl_email);
            this.grp_acceso.Location = new System.Drawing.Point(733, 63);
            this.grp_acceso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_acceso.Name = "grp_acceso";
            this.grp_acceso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_acceso.Size = new System.Drawing.Size(423, 186);
            this.grp_acceso.TabIndex = 24;
            this.grp_acceso.TabStop = false;
            this.grp_acceso.Text = "Acceso";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(119, 79);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(249, 22);
            this.txt_clave.TabIndex = 26;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(119, 36);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(249, 22);
            this.txt_email.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 51);
            this.label5.TabIndex = 2;
            this.label5.Text = "A: Para ingresar un usuario el password es obligatorio, \r\npero para actualizar de" +
    "je en blanco el campo clave\r\n y la clave no se actualizara";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(11, 79);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(88, 17);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password(A)";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(7, 39);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 17);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email(*)";
            // 
            // cbo_tipoDocumento
            // 
            this.cbo_tipoDocumento.FormattingEnabled = true;
            this.cbo_tipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE",
            ""});
            this.cbo_tipoDocumento.Location = new System.Drawing.Point(155, 143);
            this.cbo_tipoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_tipoDocumento.Name = "cbo_tipoDocumento";
            this.cbo_tipoDocumento.Size = new System.Drawing.Size(319, 24);
            this.cbo_tipoDocumento.TabIndex = 23;
            this.cbo_tipoDocumento.Text = "DNI";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(155, 266);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(319, 22);
            this.txt_telefono.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Teléfono";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(155, 226);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(319, 22);
            this.txt_direccion.TabIndex = 18;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(47, 226);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(67, 17);
            this.lbl_direccion.TabIndex = 17;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_numDocumento
            // 
            this.txt_numDocumento.Location = new System.Drawing.Point(155, 186);
            this.txt_numDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_numDocumento.Name = "txt_numDocumento";
            this.txt_numDocumento.Size = new System.Drawing.Size(319, 22);
            this.txt_numDocumento.TabIndex = 16;
            // 
            // lbl_numDoc
            // 
            this.lbl_numDoc.AutoSize = true;
            this.lbl_numDoc.Location = new System.Drawing.Point(47, 186);
            this.lbl_numDoc.Name = "lbl_numDoc";
            this.lbl_numDoc.Size = new System.Drawing.Size(87, 17);
            this.lbl_numDoc.TabIndex = 15;
            this.lbl_numDoc.Text = "Número Doc";
            // 
            // lbl_tipoDocumento
            // 
            this.lbl_tipoDocumento.AutoSize = true;
            this.lbl_tipoDocumento.Location = new System.Drawing.Point(47, 143);
            this.lbl_tipoDocumento.Name = "lbl_tipoDocumento";
            this.lbl_tipoDocumento.Size = new System.Drawing.Size(69, 17);
            this.lbl_tipoDocumento.TabIndex = 13;
            this.lbl_tipoDocumento.Text = "Tipo Doc.";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(47, 66);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(44, 17);
            this.lbl_Rol.TabIndex = 12;
            this.lbl_Rol.Text = "Rol(*)";
            // 
            // cbo_rol
            // 
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Location = new System.Drawing.Point(155, 63);
            this.cbo_rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(319, 24);
            this.cbo_rol.TabIndex = 11;
            this.cbo_rol.Text = "Seleccione Rol...";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(47, 103);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 17);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre(*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(491, 437);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.Location = new System.Drawing.Point(352, 437);
            this.btn_desactivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(88, 23);
            this.btn_desactivar.TabIndex = 6;
            this.btn_desactivar.Text = "Desactivar";
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.Location = new System.Drawing.Point(185, 437);
            this.btn_activar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(75, 23);
            this.btn_activar.TabIndex = 5;
            this.btn_activar.Text = "Activar";
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // chk_seleccionar
            // 
            this.chk_seleccionar.AutoSize = true;
            this.chk_seleccionar.Location = new System.Drawing.Point(5, 442);
            this.chk_seleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_seleccionar.Name = "chk_seleccionar";
            this.chk_seleccionar.Size = new System.Drawing.Size(104, 21);
            this.chk_seleccionar.TabIndex = 4;
            this.chk_seleccionar.Text = "Seleccionar";
            this.chk_seleccionar.UseVisualStyleBackColor = true;
            this.chk_seleccionar.CheckedChanged += new System.EventHandler(this.chk_seleccionar_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(557, 21);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(168, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(5, 23);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(545, 22);
            this.txt_buscar.TabIndex = 2;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(725, 443);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(54, 17);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "TOTAL";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_eliminar);
            this.tabPage1.Controls.Add(this.btn_desactivar);
            this.tabPage1.Controls.Add(this.btn_activar);
            this.tabPage1.Controls.Add(this.chk_seleccionar);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.txt_buscar);
            this.tabPage1.Controls.Add(this.lbl_total);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1392, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(5, 69);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1372, 354);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 12);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1400, 539);
            this.tabGeneral.TabIndex = 1;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 645);
            this.Controls.Add(this.tabGeneral);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Err_errIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grp_acceso.ResumeLayout(false);
            this.grp_acceso.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider Err_errIcono;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.CheckBox chk_seleccionar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.GroupBox grp_acceso;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ComboBox cbo_tipoDocumento;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_numDocumento;
        private System.Windows.Forms.Label lbl_numDoc;
        private System.Windows.Forms.Label lbl_tipoDocumento;
    }
}