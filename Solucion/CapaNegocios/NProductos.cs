using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDato;
using System.Data;

namespace CapaNegocios
{
   public class NProductos
    {
        DProductos objDato = new DProductos();

        public DataTable NListadoProductos()

        {
            return objDato.DListadoProductos();
        }

        public int NAgregarProducto(EProductos pEn)
        {
            return objDato.DAgregarProductos(pEn);

        }

        public int NEliminarProductos(EProductos pEn)
        {
            return objDato.EliminarProductos(pEn);

        }
    }
}
