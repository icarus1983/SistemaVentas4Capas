using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;
namespace Sistema.Datos

{
    public class Dusuario
    {
        public DataTable Listar() 
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("usuario_listar", SqlCon);
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

        public DataTable Buscar(string Valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("usuario_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
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

        public DataTable Login(string email, string clave) 
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("usuario_login", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
                SqlCon.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
                    
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Insertar(Usuario obj)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {

                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("usuario_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.idRol;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = obj.tipo_documento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = obj.num_documento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.clave;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

                return respuesta;
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

        public string Existe(String Valor) 
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("usuario_existe", SqlCon);
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

        public string Actualizar(Usuario obj) 
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();

            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("usuario_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idUsuario;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.idRol;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = obj.tipo_documento;
                Comando.Parameters.Add("num_documento", SqlDbType.VarChar).Value = obj.num_documento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = obj.telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.clave;
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
                SqlCommand Comando = new SqlCommand("usuario_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
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
                SqlCommand Comando = new SqlCommand("usuario_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el Usuario";

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
                SqlCommand Comando = new SqlCommand("usuario_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede desactivar Usuario";

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
