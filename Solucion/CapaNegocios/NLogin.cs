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
     public class NLogin
    {
        DLogin objDato = new DLogin();

        public int NAgregarUsuario(ELogin pEn)
        {
            return objDato.DAgregarUsuarios(pEn);

        }


    }
}
