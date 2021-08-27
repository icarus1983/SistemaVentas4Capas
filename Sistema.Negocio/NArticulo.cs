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
    public class NArticulo
    {
        public static DataTable Listar()
        {
            Darticulo Datos = new Darticulo();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            Darticulo Datos = new Darticulo();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(int idCategoria, string codigo, string nombre, decimal precio_venta, int stock, string descripcion, string imagen)
        {
            Darticulo Datos = new Darticulo();
            string existe = Datos.Existe(nombre);
            if (existe.Equals(1))
            {
                return "El producto ya existe";
            }
            else
            {
                Articulo Articulo = new Articulo();
                Articulo.idcategoria = idCategoria;
                Articulo.codigo = codigo;
                Articulo.nombre = nombre;
                Articulo.precio_venta = precio_venta;
                Articulo.stock = stock;
                Articulo.descripcion = descripcion;
                Articulo.imagen = imagen;
                return Datos.Insertar(Articulo);

            }

        }


        public static string Actualizar(int id, int idCategoria, string codigo, string NombreAnt, string nombre,decimal precio_venta,int stock, string descripcion, string imagen)
        {
            Darticulo Datos = new Darticulo();
            Articulo Articulo = new Articulo();

            if (NombreAnt.Equals(nombre))
            {
                Articulo.idarticulo = id;
                Articulo.idcategoria = idCategoria;
                Articulo.codigo = codigo;
                Articulo.nombre = nombre;
                Articulo.precio_venta = precio_venta;
                Articulo.stock = stock;
                Articulo.descripcion = descripcion;
                Articulo.imagen = imagen;               
                return Datos.Actualizar(Articulo);
            }
            else
            {
                string existe = Datos.Existe(nombre);
                if (existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    Articulo.idarticulo = id;
                    Articulo.idcategoria = idCategoria;
                    Articulo.codigo = codigo;
                    Articulo.nombre = nombre;
                    Articulo.precio_venta = precio_venta;
                    Articulo.stock = stock;
                    Articulo.descripcion = descripcion;
                    Articulo.imagen = imagen;
                    return Datos.Actualizar(Articulo);
                }
            }


        }

        public static string Eliminar(int id) 
        {
            Darticulo Datos = new Darticulo();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id) 
        {
            Darticulo Datos = new Darticulo();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id) 
        {
            Darticulo Datos = new Darticulo();
            return Datos.Desactivar(id);
        }
    }
}
