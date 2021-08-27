using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class Darticulo
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
                SqlCommand Comando = new SqlCommand("articulo_listar", SqlCon);
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
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();

            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("articulo_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
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

        public string Existe(string Valor)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();

            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("articulo_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@Existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                respuesta = Convert.ToString(ParExiste);
                


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        public string Insertar(Articulo Obj) 
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();
            try
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("articulo_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.idcategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.precio_venta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.imagen;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";


            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
            
        }

        public string Actualizar(Articulo Obj) 
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Conexion do_conexion = new Conexion();

            try 
            {
                SqlCon = do_conexion.ConectarBD();
                SqlCommand Comando = new SqlCommand("articulo_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Obj.idarticulo;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.idcategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.precio_venta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.imagen;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1? "OK" : "No se pudo Actualizar el registro";

            }
            catch (Exception ex) 
            {
                throw ex;
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
                SqlCommand Comando = new SqlCommand("articulo_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
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
                SqlCommand Comando = new SqlCommand("articulo_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede desactivar Categoria";

            }
            catch (Exception ex)
            {
                throw ex;
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
                SqlCommand Comando = new SqlCommand("articulo_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id;
                SqlCon.Open();
                respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede desactivar Categoria";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }
    }
}
