
namespace Sistema.Presentacion
{
    partial class FrmArticulo
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
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_precioVenta = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_precioVenta = new System.Windows.Forms.Label();
            this.pnl_panelCodigo = new System.Windows.Forms.Panel();
            this.btn_guardarCodigo = new System.Windows.Forms.Button();
            this.btn_generarCodigo = new System.Windows.Forms.Button();
            this.txt_codigoBarras = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.pic_imagen = new System.Windows.Forms.PictureBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.txt_imagen = new System.Windows.Forms.TextBox();
            this.lbl_imagen = new System.Windows.Forms.Label();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.chk_seleccionar = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Err_errIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Err_errIcono
            // 
            this.Err_errIcono.ContainerControl = this;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(175, 511);
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
            this.label3.Location = new System.Drawing.Point(171, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Los datos que estan con (*) son obligatorios";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(365, 511);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(175, 511);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(147, 23);
            this.btn_insertar.TabIndex = 5;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(365, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(154, 22);
            this.txt_id.TabIndex = 4;
            this.txt_id.Visible = false;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(801, 372);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(346, 101);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(172, 121);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(346, 22);
            this.txt_nombre.TabIndex = 2;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(695, 372);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(82, 17);
            this.lbl_descripcion.TabIndex = 1;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_stock);
            this.tabPage2.Controls.Add(this.txt_precioVenta);
            this.tabPage2.Controls.Add(this.lbl_stock);
            this.tabPage2.Controls.Add(this.lbl_precioVenta);
            this.tabPage2.Controls.Add(this.pnl_panelCodigo);
            this.tabPage2.Controls.Add(this.btn_guardarCodigo);
            this.tabPage2.Controls.Add(this.btn_generarCodigo);
            this.tabPage2.Controls.Add(this.txt_codigoBarras);
            this.tabPage2.Controls.Add(this.lbl_codigo);
            this.tabPage2.Controls.Add(this.pic_imagen);
            this.tabPage2.Controls.Add(this.btn_cargar);
            this.tabPage2.Controls.Add(this.txt_imagen);
            this.tabPage2.Controls.Add(this.lbl_imagen);
            this.tabPage2.Controls.Add(this.cbo_categoria);
            this.tabPage2.Controls.Add(this.lbl_categoria);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_insertar);
            this.tabPage2.Controls.Add(this.txt_id);
            this.tabPage2.Controls.Add(this.txt_descripcion);
            this.tabPage2.Controls.Add(this.txt_nombre);
            this.tabPage2.Controls.Add(this.lbl_descripcion);
            this.tabPage2.Controls.Add(this.lbl_nombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1322, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(174, 428);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(341, 22);
            this.txt_stock.TabIndex = 23;
            // 
            // txt_precioVenta
            // 
            this.txt_precioVenta.Location = new System.Drawing.Point(175, 390);
            this.txt_precioVenta.Name = "txt_precioVenta";
            this.txt_precioVenta.Size = new System.Drawing.Size(340, 22);
            this.txt_precioVenta.TabIndex = 22;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(50, 433);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(119, 17);
            this.lbl_stock.TabIndex = 21;
            this.lbl_stock.Text = "Stock Producto(*)";
            // 
            // lbl_precioVenta
            // 
            this.lbl_precioVenta.AutoSize = true;
            this.lbl_precioVenta.Location = new System.Drawing.Point(61, 390);
            this.lbl_precioVenta.Name = "lbl_precioVenta";
            this.lbl_precioVenta.Size = new System.Drawing.Size(108, 17);
            this.lbl_precioVenta.TabIndex = 20;
            this.lbl_precioVenta.Text = "Precio Venta (*)";
            // 
            // pnl_panelCodigo
            // 
            this.pnl_panelCodigo.Location = new System.Drawing.Point(172, 253);
            this.pnl_panelCodigo.Name = "pnl_panelCodigo";
            this.pnl_panelCodigo.Size = new System.Drawing.Size(430, 120);
            this.pnl_panelCodigo.TabIndex = 19;
            // 
            // btn_guardarCodigo
            // 
            this.btn_guardarCodigo.Enabled = false;
            this.btn_guardarCodigo.Location = new System.Drawing.Point(335, 208);
            this.btn_guardarCodigo.Name = "btn_guardarCodigo";
            this.btn_guardarCodigo.Size = new System.Drawing.Size(94, 23);
            this.btn_guardarCodigo.TabIndex = 18;
            this.btn_guardarCodigo.Text = "Guardar";
            this.btn_guardarCodigo.UseVisualStyleBackColor = true;
            this.btn_guardarCodigo.Click += new System.EventHandler(this.btn_guardarCodigo_Click);
            // 
            // btn_generarCodigo
            // 
            this.btn_generarCodigo.Location = new System.Drawing.Point(186, 208);
            this.btn_generarCodigo.Name = "btn_generarCodigo";
            this.btn_generarCodigo.Size = new System.Drawing.Size(99, 23);
            this.btn_generarCodigo.TabIndex = 17;
            this.btn_generarCodigo.Text = "Generar Codigo ";
            this.btn_generarCodigo.UseVisualStyleBackColor = true;
            this.btn_generarCodigo.Click += new System.EventHandler(this.btn_generarCodigo_Click);
            // 
            // txt_codigoBarras
            // 
            this.txt_codigoBarras.Location = new System.Drawing.Point(172, 171);
            this.txt_codigoBarras.Name = "txt_codigoBarras";
            this.txt_codigoBarras.Size = new System.Drawing.Size(344, 22);
            this.txt_codigoBarras.TabIndex = 16;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(66, 174);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(98, 17);
            this.lbl_codigo.TabIndex = 15;
            this.lbl_codigo.Text = "Codigo Barras";
            // 
            // pic_imagen
            // 
            this.pic_imagen.Location = new System.Drawing.Point(801, 121);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.Size = new System.Drawing.Size(281, 221);
            this.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_imagen.TabIndex = 14;
            this.pic_imagen.TabStop = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(1100, 74);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(113, 29);
            this.btn_cargar.TabIndex = 13;
            this.btn_cargar.Text = "Seleccionar...";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // txt_imagen
            // 
            this.txt_imagen.Enabled = false;
            this.txt_imagen.Location = new System.Drawing.Point(801, 76);
            this.txt_imagen.Name = "txt_imagen";
            this.txt_imagen.Size = new System.Drawing.Size(281, 22);
            this.txt_imagen.TabIndex = 12;
            // 
            // lbl_imagen
            // 
            this.lbl_imagen.AutoSize = true;
            this.lbl_imagen.Location = new System.Drawing.Point(695, 76);
            this.lbl_imagen.Name = "lbl_imagen";
            this.lbl_imagen.Size = new System.Drawing.Size(54, 17);
            this.lbl_imagen.TabIndex = 11;
            this.lbl_imagen.Text = "Imagen";
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(175, 72);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(344, 24);
            this.cbo_categoria.TabIndex = 10;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(67, 75);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(84, 17);
            this.lbl_categoria.TabIndex = 9;
            this.lbl_categoria.Text = "Categoría(*)";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(66, 121);
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
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.Location = new System.Drawing.Point(342, 437);
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
            this.chk_seleccionar.Location = new System.Drawing.Point(6, 442);
            this.chk_seleccionar.Name = "chk_seleccionar";
            this.chk_seleccionar.Size = new System.Drawing.Size(104, 21);
            this.chk_seleccionar.TabIndex = 4;
            this.chk_seleccionar.Text = "Seleccionar";
            this.chk_seleccionar.UseVisualStyleBackColor = true;
            this.chk_seleccionar.CheckedChanged += new System.EventHandler(this.chk_seleccionar_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(558, 21);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(168, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(6, 23);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(545, 22);
            this.txt_buscar.TabIndex = 2;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(726, 443);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(54, 17);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "TOTAL";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 69);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1293, 354);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
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
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1322, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1330, 636);
            this.tabGeneral.TabIndex = 1;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 636);
            this.Controls.Add(this.tabGeneral);
            this.Name = "FrmArticulo";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Err_errIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox cbo_categoria;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.PictureBox pic_imagen;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.TextBox txt_imagen;
        private System.Windows.Forms.Label lbl_imagen;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button btn_guardarCodigo;
        private System.Windows.Forms.Button btn_generarCodigo;
        private System.Windows.Forms.TextBox txt_codigoBarras;
        private System.Windows.Forms.Panel pnl_panelCodigo;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_precioVenta;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_precioVenta;
    }
}