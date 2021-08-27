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
using System.Data;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Cancelar() 
        
        {
            txt_email.Clear();
            txt_email.Clear();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.Login(txt_email.Text.Trim(), txt_password.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("No existe el usuario", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][4]) == false)
                    {
                        MessageBox.Show("Usuario no activo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmPrincipal Frm = new FrmPrincipal();
                        Frm.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        Frm.Rol = Convert.ToString(Tabla.Rows[0][2]);
                        Frm.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                        Frm.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                        Frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
