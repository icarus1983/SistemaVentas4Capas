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
   public class NCategoria
    {
        public static DataTable Listar() 
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Listar();
        }

        public static DataTable Seleccionar() 
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Seleccionar();
        }

        public static DataTable Buscar(string Valor) 
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(string nombre, string descripcion)
        {
            Dcategoria Datos = new Dcategoria();
            string existe = Datos.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else 
            {
                Categoria Categoria = new Categoria();
                Categoria.nombre = nombre;
                Categoria.descripcion = descripcion;
                return Datos.Insertar(Categoria);
            }           
        }

        public static string Actualizar(int id,string NombreAnt, string nombre, string descripcion) 
        {
            Dcategoria Datos = new Dcategoria();
            Categoria Categoria = new Categoria();

            if (NombreAnt.Equals(nombre))
            {
                Categoria.idcategoria = id;
                Categoria.nombre = nombre;
                Categoria.descripcion = descripcion;
                return Datos.Actualizar(Categoria);
            }
            else 
            {
                string existe = Datos.Existe(nombre);
                if (existe.Equals("1"))
                {
                    return "La categoria ya existe";
                }
                else
                {
                    Categoria.idcategoria = id;
                    Categoria.nombre = nombre;
                    Categoria.descripcion = descripcion;
                    return Datos.Actualizar(Categoria);
                }
            }

            
        }

        public static string Eliminar(int id) 
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id) 
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Activar(id);
        }
        public static string Desactivar(int id) 
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Desactivar(id);
        }



    }
}
