using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Datos
{
    public class Drol
    {
        public DataTable Listar() 
        {
            SqlDataReader resultado;
            SqlConnection SqlCon = new SqlConnection();
            DataTable tabla = new DataTable();
            Conexion do_conexion = new Conexion();

            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("listar_rol", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

      
    }
}
