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
   public class NCliente
    {
        DCliente objDato = new DCliente();

        public int AgregarEmpleados(ECliente pEn)
        {
            return objDato.AgregarCliente(pEn);

        }
        public int ModificarCliente(ECliente pEn)
        {
            return objDato.ModificarCliente(pEn);

        }
        public DataTable NListadoClientes()

        {
            return objDato.DListadoClientes();
        }

        public int EliminarClientes(ECliente pEN)

        {
            return objDato.EliminarClientes(pEN );
        }

    }
}
