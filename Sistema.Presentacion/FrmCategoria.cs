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

namespace Sistema.Presentacion
{
    public partial class FrmCategoria : Form
    {
        private string NombreAnt;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try 
            {
                DgvListado.DataSource = NCategoria.Listar();
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
                DgvListado.DataSource = NCategoria.Buscar(txt_buscar.Text);
                this.Formato();
                lbl_total.Text = "Total Registro: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato() 
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripción";
            DgvListado.Columns[4].Width = 100;

        }

        private void Limpiar() 
        {
            txt_buscar.Clear();
            txt_nombre.Clear();
            txt_id.Clear();
            txt_descripcion.Clear();
            btn_insertar.Visible = true;
            Err_errIcono.Clear();
            btn_actualizar.Visible = false;

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


        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            try 
            {
                string respuesta = "";
                if (txt_nombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán marcados.");
                    Err_errIcono.SetError(txt_nombre, "Ingrese un nombre");
                }
                else
                {
                    respuesta = NCategoria.Insertar(txt_nombre.Text.Trim(), txt_descripcion.Text.Trim());
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOkey("Se inserto de forma correcta el registro");
                        this.Limpiar();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btn_actualizar.Visible = true;
                btn_insertar.Visible = false;
                txt_id.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Id"].Value);
                this.NombreAnt = txt_nombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["nombre"].Value);
                txt_nombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["nombre"].Value);
                txt_descripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["descripcion"].Value);
                tabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Seleccione desde la celda nombre");
            }

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txt_nombre.Text == string.Empty || txt_id.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán marcados.");
                    Err_errIcono.SetError(txt_nombre, "Ingrese un nombre");
                }
                else
                {
                    respuesta = NCategoria.Actualizar(Convert.ToInt32(txt_id.Text) ,this.NombreAnt, txt_nombre.Text.Trim(), txt_descripcion.Text.Trim());
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOkey("Se actualizó de forma correcta el registro");
                        this.Limpiar();
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

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chk_eliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chk_eliminar.Value = !Convert.ToBoolean(chk_eliminar.Value);


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

                    foreach (DataGridViewRow row in DgvListado.Rows) 
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo =  Convert.ToInt32(row.Cells[1].Value);
                            respuesta = NCategoria.Eliminar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOkey("Registro eliminado correctamente: " + Convert.ToString(row.Cells[2].Value));
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
                            respuesta = NCategoria.Activar(codigo);
                            

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
                            respuesta = NCategoria.Desactivar(codigo);

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
