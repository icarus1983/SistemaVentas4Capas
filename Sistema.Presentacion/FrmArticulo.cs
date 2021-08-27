using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;
using System.Drawing.Imaging;
using System.IO;

namespace Sistema.Presentacion
{
    public partial class FrmArticulo : Form
    {
        private string rutaOrigen = "";
        private string rutaDestino = "";
        private string directorio = "C:\\Users\\Guille\\Documents\\Visual Studio 2019\\udemy\\modelo4capas\\SistemaImagenes\\";
        private string nombreAnt = "";

        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Listar();
                this.Formato();
                this.Limpiar();
                lbl_total.Text = "Total Registro: " + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Buscar(txt_buscar.Text);
                this.Formato();
                lbl_total.Text = "Total Registro: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CargarCategoria()
        {
            try
            {
                cbo_categoria.DataSource = NCategoria.Seleccionar();
                cbo_categoria.ValueMember = "idcategoria";
                cbo_categoria.DisplayMember = "nombre";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "Categoria";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Código";
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Precio Venta";
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[8].Width = 200;
            DgvListado.Columns[8].HeaderText = "Descripción";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;



        }

        private void Limpiar()
        {
            txt_buscar.Clear();
            txt_nombre.Clear();
            txt_codigoBarras.Clear();
            pnl_panelCodigo.BackgroundImage = null;
            btn_guardarCodigo.Enabled = true;
            txt_stock.Clear();
            txt_precioVenta.Clear();
            txt_imagen.Clear();
            pic_imagen.Image = null;
            txt_id.Clear();
            txt_descripcion.Clear();
            btn_insertar.Visible = true;
            Err_errIcono.Clear();
            btn_actualizar.Visible = false;
            this.rutaDestino = "";
            this.rutaOrigen = "";

            DgvListado.Columns[0].Visible = false;
            btn_activar.Visible = false;
            btn_desactivar.Visible = false;
            btn_eliminar.Visible = false;
            chk_seleccionar.Checked = false;

        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOkey(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoria();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Image files (*.jpg, *.jepg, *.jpe, *.jfif, *.png) | *.jpg; *.jepg; *.jpe; *.jfif; *.png";
            if (File.ShowDialog() == DialogResult.OK)
            {
                pic_imagen.Image = Image.FromFile(File.FileName);
                txt_imagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\\") + 1);
                this.rutaOrigen = File.FileName;
            }
        }

        private void btn_generarCodigo_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            pnl_panelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txt_codigoBarras.Text, Color.Black, Color.White, 400, 100);
            btn_guardarCodigo.Enabled = true;
        }

        private void btn_guardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgCodigo = (Image)pnl_panelCodigo.BackgroundImage.Clone();
            SaveFileDialog guardarCodigoBarra = new SaveFileDialog();
            guardarCodigoBarra.AddExtension = true;
            guardarCodigoBarra.Filter = "Image PNG (*.png) | +.png";
            guardarCodigoBarra.ShowDialog();

            if (!string.IsNullOrEmpty(guardarCodigoBarra.FileName))
            {
                imgCodigo.Save(guardarCodigoBarra.FileName, ImageFormat.Png);
            }
            imgCodigo.Dispose();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (cbo_categoria.Text == string.Empty || txt_nombre.Text == string.Empty || txt_precioVenta.Text == string.Empty || txt_stock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán marcados.");
                    Err_errIcono.SetError(cbo_categoria, "Seleccione categoria");
                    Err_errIcono.SetError(txt_nombre, "Ingrese un nombre");
                    Err_errIcono.SetError(txt_precioVenta, "Ingrese precio de venta");
                    Err_errIcono.SetError(txt_stock, "Ingrese Stock");
                }
                else
                {
                    respuesta = NArticulo.Insertar(Convert.ToInt32(cbo_categoria.SelectedValue), txt_codigoBarras.Text.Trim(), txt_nombre.Text.Trim(), Convert.ToDecimal(txt_precioVenta.Text.Trim()), Convert.ToInt32(txt_stock.Text), txt_descripcion.Text.Trim(), txt_imagen.Text.Trim());
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOkey("Se inserto de forma correcta el registro");
                        if (txt_imagen.Text != string.Empty)
                        {
                            this.rutaDestino = this.directorio + txt_imagen.Text;
                            File.Copy(this.rutaOrigen, this.rutaDestino);
                        }

                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btn_actualizar.Visible = true;
                btn_insertar.Visible = false;
                txt_id.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                cbo_categoria.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                txt_codigoBarras.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                this.nombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txt_nombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txt_precioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_Venta"].Value);
                txt_stock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                txt_descripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                string Imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if (Imagen != string.Empty)
                {
                    pic_imagen.Image = Image.FromFile(this.directorio + Imagen);
                    txt_imagen.Text = Imagen;
                }
                else
                {
                    pic_imagen.Image = null;
                    txt_imagen.Text = "";
                }
                tabGeneral.SelectedIndex = 1;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar desde la celda nombre" + "|Error: " + ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txt_id.Text == string.Empty || cbo_categoria.Text == string.Empty || txt_nombre.Text == string.Empty || txt_precioVenta.Text == string.Empty || txt_stock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán marcados.");
                    Err_errIcono.SetError(cbo_categoria, "Seleccione categoria");
                    Err_errIcono.SetError(txt_nombre, "Ingrese un nombre");
                    Err_errIcono.SetError(txt_precioVenta, "Ingrese precio de venta");
                    Err_errIcono.SetError(txt_stock, "Ingrese Stock");
                }
                else
                {
                    respuesta = NArticulo.Actualizar(Convert.ToInt32(txt_id.Text), Convert.ToInt32(cbo_categoria.SelectedValue), txt_codigoBarras.Text.Trim(), this.nombreAnt, txt_nombre.Text.Trim(), Convert.ToDecimal(txt_precioVenta.Text.Trim()), Convert.ToInt32(txt_stock.Text), txt_descripcion.Text.Trim(), txt_imagen.Text.Trim()); ;
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOkey("Se actualizo de forma correcta el registro");
                        if (txt_imagen.Text != string.Empty && this.rutaOrigen != string.Empty)
                        {
                            this.rutaDestino = this.directorio + txt_imagen.Text;
                            File.Copy(this.rutaOrigen, this.rutaDestino);
                        }

                        this.Listar();
                        tabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chk_eliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chk_eliminar.Value = !Convert.ToBoolean(chk_eliminar.Value);
            }
        }

        private void chk_seleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_seleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                btn_activar.Visible = true;
                btn_desactivar.Visible = true;
                btn_eliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                btn_activar.Visible = false;
                btn_desactivar.Visible = false;
                btn_eliminar.Visible = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente deseas eliminar el registro", "Sistema de venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";
                    string Imagen = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Imagen = Convert.ToString(row.Cells[9].Value);
                            respuesta = NArticulo.Eliminar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOkey("Registro eliminado correctamente: " + Convert.ToString(row.Cells[5].Value));
                                File.Delete(this.directorio + Imagen);
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Listar();
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente deseas activar el registro", "Sistema de venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NArticulo.Activar(codigo);


                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOkey("Registro Activado correctamente: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Listar();
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente deseas desactivar el registro", "Sistema de venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NArticulo.Desactivar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOkey("Registro Desactivado correctamente: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Listar();
        }
    }
 }

