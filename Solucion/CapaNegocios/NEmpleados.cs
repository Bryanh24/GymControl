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
    public class NEmpleados
    {
        DEmpleados objDato = new DEmpleados();



        public DataTable NListado()

        {
            return objDato.DListado();
        }

        public int AgregarEmpleados(EEmpleados pEn)
        {
           return objDato.AgregarEmpleados(pEn);

        }

        public DataTable ConsultarNombreEmpleado(EEmpleados pEN)
        {
            return objDato.ConsultarNombreEmpleado(pEN);
        }

        public int ModificarEmpleado(EEmpleados pEn)
        {
            return objDato.ModificarEmpleado(pEn);

        }
        public int EliminarClientes(EEmpleados pEN)

        {
            return objDato.EliminarEmpleado(pEN);
        }
        
    }
}
