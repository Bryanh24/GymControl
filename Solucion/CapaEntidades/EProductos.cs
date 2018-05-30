using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public  class EProductos
    {

        public double PrecioCompraProducto { get; set; }
        public double PrecioVentaProducto { get; set; }
        public string MarcaProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int StockProducto { get; set; }
        public int idProducto { get; set; }
    }

}
