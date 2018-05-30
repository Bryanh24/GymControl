using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato
{
   public class DLogin
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
        ELogin entidad = new ELogin();

        public int DAgregarUsuarios(ELogin pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("Sp_AgregarUsuarios", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@NombreUsuario", pEN.NombreUsuario));
            command.Parameters.Add(new SqlParameter("@Pass", pEN.Pass));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }
    }
}
