using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class DetalleIngreso
    {
        public int iddetalle_ingreso { get; set; }
        public int idingreso { get; set; }
        public int idarticulo { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
    }
}
