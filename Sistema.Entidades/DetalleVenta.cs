using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class DetalleVenta
    {
        public int idDetalle_venta  {get; set;}
        public int idVenta { get; set; }
        public int idArticulo { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal descuento { get; set; }
    }
}
