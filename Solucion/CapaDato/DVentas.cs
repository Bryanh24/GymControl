using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDato
{
    public class DVentas
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
         EVentas entidad = new EVentas();

        public int DConsultarEmpleado(EVentas pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("FiltroNombreClientes", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@IdCliente", pEN.IdProducto));
            //command.Parameters.Add(new SqlParameter("@NombreCliente", pEN.NombreCliente));
            //command. = ParameterDirection.Output;
            SqlParameter outparam = command.Parameters.AddWithValue("@NombreCliente", pEN.NombreCliente);
            outparam.Direction = ParameterDirection.Output;
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

    }
}
