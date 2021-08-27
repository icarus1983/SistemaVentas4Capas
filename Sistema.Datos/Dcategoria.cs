using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Entidades;
using System.Data.SqlClient;
namespace Sistema.Datos
{
    public class Dcategoria
    {
        public  DataTable Listar() 
        {
            SqlDataReader resultado;
            DataTable dt = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conectar = new Conexion();
            
            
            try 
            {
                SqlCon = do_conectar.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                resultado = Comando.ExecuteReader();
                dt.Load(resultado);
                return dt;


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

        public DataTable Seleccionar() 
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();

            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_seleccionar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                resultado = Comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
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

        public DataTable Buscar(string Valor) 
        {

            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_Conectar = new Conexion();
            try 
            {
                SqlCon = do_Conectar.ConectarBD();
                
                SqlCommand Comando = new SqlCommand("categoria_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            
        }

        public string Existe(string Valor)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            
            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                respuesta = Convert.ToString(ParExiste.Value);

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        public string Insertar(Categoria Obj) 
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;       
        }

        public string Actualizar(Categoria Obj) 
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.idcategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            
            }
            catch (Exception ex) 
            {
                respuesta = ex.Message;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        
        }

        public string Eliminar(int id) 
        { 
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery()==1? "OK": "No se pudo eliminar el registro";
            }
            catch (Exception ex)            
            {
                respuesta = ex.Message;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return respuesta;
        }

        public string Activar(int id) 
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede activar Categoria";
                
            }
            catch (Exception ex) 
            {
                respuesta = ex.Message;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        
        }

        public string Desactivar(int id)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("categoria_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("idcategoria", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede desactivar Categoria";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

    }
}
