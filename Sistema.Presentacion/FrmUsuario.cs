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
    public partial class FrmUsuario : Form
    {
        private string emailAnt = "";
        public FrmUsuario()
        {
            InitializeComponent();
        }

        public void Formato() 
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[4].Width = 170;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Número Doc.";
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[7].HeaderText = "Dirección";
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Teléfono";
            DgvListado.Columns[9].Width = 120;

        }

        private void Limpiar()
        {
            txt_buscar.Clear();
            txt_nombre.Clear();
            txt_id.Clear();
            txt_numDocumento.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            txt_clave.Clear();
           
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
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NUsuario.Listar();
                this.Formato();
                this.Limpiar();
                lbl_total.Text = Convert.ToString(DgvListado.Rows.Count); 
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
                DgvListado.DataSource = NUsuario.Buscar(txt_buscar.Text.Trim());
                this.Formato();
                lbl_total.Text = "Total Registro: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CargarRol() 
        {
            try 
            {              
                cbo_rol.DataSource = NRol.Listar();
                cbo_rol.ValueMember = "idrol";
                cbo_rol.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarRol();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            try
            {
                if (cbo_rol.Text == string.Empty || txt_email.Text == string.Empty || txt_nombre.Text == string.Empty || txt_clave.Text == string.Empty)
                {
                    this.MensajeError("Los datos estan incompletos");
                    Err_errIcono.SetError(cbo_rol, "Debe seleccionar un Rol");
                    Err_errIcono.SetError(txt_nombre, "Debe ingresar un nombre");
                    Err_errIcono.SetError(txt_email, "Debe ingresar un correo");
                    Err_errIcono.SetError(txt_clave, "Debe ingresar un Password");
                }
                else 
                {
                    respuesta = NUsuario.Insertar(Convert.ToInt32(cbo_rol.SelectedValue), txt_nombre.Text.Trim(), cbo_tipoDocumento.Text, txt_numDocumento.Text.Trim(), txt_direccion.Text.Trim(), txt_telefono.Text.Trim(), txt_email.Text.Trim(), txt_clave.Text.Trim());
                    if (respuesta == "OK")
                    {
                        this.MensajeOkey("El registro se inserto correctamente");
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

       

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();               
                btn_actualizar.Visible = true;
                btn_insertar.Visible = false;

                txt_id.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                cbo_rol.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idrol"].Value);
                txt_nombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                cbo_tipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                txt_numDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                txt_direccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                txt_telefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                this.emailAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                txt_email.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                tabGeneral.SelectedIndex = 1;





            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar desde la celda nombre" + "|Error: " + ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            try
            {
                if (txt_id.Text == string.Empty || cbo_rol.Text == string.Empty || txt_email.Text == string.Empty || txt_nombre.Text == string.Empty)
                {
                    this.MensajeError("Los datos estan incompletos");
                    Err_errIcono.SetError(cbo_rol, "Debe seleccionar un Rol");
                    Err_errIcono.SetError(txt_nombre, "Debe ingresar un nombre");
                    Err_errIcono.SetError(txt_email, "Debe ingresar un correo");
                    
                }
                else
                {
                    respuesta = NUsuario.Actualizar(Convert.ToInt32( txt_id.Text), Convert.ToInt32(cbo_rol.SelectedValue), txt_nombre.Text.Trim(), cbo_tipoDocumento.Text, txt_numDocumento.Text.Trim(), txt_direccion.Text.Trim(), txt_telefono.Text.Trim(),this.emailAnt, txt_email.Text.Trim(), txt_clave.Text.Trim()); 
                    if (respuesta == "OK")
                    {
                        this.MensajeOkey("El registro se actualizo correctamente");
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
                opcion = MessageBox.Show("Realmente desea eliminar el registro", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK) 
                {
                    int codigo;
                    string respuesta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows) 
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        respuesta = NUsuario.Eliminar(codigo);

                        if (respuesta.Equals("OK"))
                        {
                            this.MensajeOkey("Registro eliminado Correctamente" + Convert.ToString(row.Cells[2].Value));
                        }
                        else 
                        {
                            this.MensajeError(respuesta);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea activar el registro", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string respuesta = "";
                    int codigo;

                    foreach (DataGridViewRow row in DgvListado.Rows) 
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        respuesta = NUsuario.Activar(codigo);

                        if (respuesta == "OK")
                        {
                            this.MensajeOkey("Registro activado correctamente: " + Convert.ToString(row.Cells[4].Value));
                            this.Listar();
                        }
                        else 
                        {
                            this.MensajeError(respuesta);
                        }
                    }

                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea desactivar el registro", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK) 
                {
                    string respuesta = "";
                    int codigo;

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        respuesta = NUsuario.Desactivar(codigo);

                        if (respuesta == "OK")
                        {
                            this.MensajeOkey("Registro desactivado correctamente: " + Convert.ToString(row.Cells[4].Value));
                            this.Listar();
                        }
                        else
                        {
                            this.MensajeError(respuesta);
                        }
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
