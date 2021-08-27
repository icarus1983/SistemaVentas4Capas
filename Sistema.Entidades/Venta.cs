using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public int idUsuario { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public DateTime fecha { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }

    }
}
