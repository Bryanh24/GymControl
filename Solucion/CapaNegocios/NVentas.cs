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
    public class NVentas
    {

        DVentas objDato = new DVentas();

        public int AgregarEmpleados(EVentas pEn)
        {
            return objDato.DConsultarEmpleado(pEn);

        }
    }

}
