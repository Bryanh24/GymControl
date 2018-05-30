using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class ECliente
    {
        public string NombreCliente { get; set; }
        public string ApellidoPaternoCliente { get; set; }
        public string ApellidoMaternoCliente { get; set; }
        public string CelularCliente { get; set; }
        public string CorreoCliente { get; set; }
        public string ConsultarNombreCliente{ get; set; }
        public int idCliente { get; set; }
    }
}
