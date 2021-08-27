using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NUsuario
    {
        public static DataTable Listar() 
        { 
            Dusuario Datos = new Dusuario();
            return Datos.Listar(); 
        }

        public static DataTable Buscar(String Valor) 
        {
            Dusuario Datos = new Dusuario();
            return Datos.Buscar(Valor);

        }

        public static DataTable Login(string email, string clave) 
        {
            Dusuario Datos = new Dusuario();
            return Datos.Login(email, clave);

        }

        public static string Insertar(int idRol, string nombre, string tipo_documento, string num_documento, string direccion, string telefono, string email, string clave) 
        {
            Dusuario Datos = new Dusuario();

            string existe = Datos.Existe(email);

            

            if (existe.Equals("1"))
            {
                return "El usuario ya existe";
            }
            else 
            {
                Usuario Usuario = new Usuario();
                Usuario.idRol = idRol;
                Usuario.nombre = nombre;
                Usuario.tipo_documento = tipo_documento;
                Usuario.num_documento = num_documento;
                Usuario.direccion = direccion;
                Usuario.telefono = telefono;
                Usuario.email = email;
                Usuario.clave = clave;
                return Datos.Insertar(Usuario);

            }
        }


        public static string Actualizar(int id, int idRol , string nombre, string tipo_documento, string num_documento, string direccion, string telefono,string emailAnt,  string email, string clave)

        {
            Dusuario Datos = new Dusuario();
            Usuario Usuario = new Usuario();


            if (emailAnt.Equals(email))
            
            {
                Usuario.idUsuario = id;
                Usuario.idRol = idRol;
                Usuario.nombre = nombre;
                Usuario.tipo_documento = tipo_documento;
                Usuario.num_documento = num_documento;
                Usuario.direccion = direccion;
                Usuario.telefono = telefono;
                Usuario.email = email;
                Usuario.clave = clave;
                return Datos.Actualizar(Usuario);
            }
            else 
            {

                string existe = Datos.Existe(email);

                if (existe.Equals("1"))
                {
                    return "El usuario ya se encuentra registrado";
                }
                else 
                {
                    Usuario.idUsuario = id;
                    Usuario.idRol = idRol;
                    Usuario.nombre = nombre;
                    Usuario.tipo_documento = tipo_documento;
                    Usuario.num_documento = num_documento;
                    Usuario.direccion = direccion;
                    Usuario.telefono = telefono;
                    Usuario.email = email;
                    Usuario.clave = clave;
                    return Datos.Actualizar(Usuario);
                }
            }
        }


        public static string Eliminar(int id)
        {
            Dusuario Datos = new Dusuario();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id) 
        {
            Dusuario Datos = new Dusuario();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id) 
        {
            Dusuario Datos = new Dusuario();
            return Datos.Desactivar(id);
        }
    }
}
