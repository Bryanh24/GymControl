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
    public class DCliente
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
        EEmpleados Entidad = new EEmpleados();

        public DataTable DListadoClientes()

        {
            SqlCommand cmd = new SqlCommand("sp_listarClientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public int AgregarCliente(ECliente pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("AgregarClientes", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@NombreCliente", pEN.NombreCliente));
            command.Parameters.Add(new SqlParameter("@ApellidoPaternoCliente", pEN.ApellidoPaternoCliente));
            command.Parameters.Add(new SqlParameter("@ApellidoMaternoCliente", pEN.ApellidoMaternoCliente));
            command.Parameters.Add(new SqlParameter("@CelularCliente", pEN.CelularCliente));
            command.Parameters.Add(new SqlParameter("@CorreoCliente", pEN.CorreoCliente));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }
        public int ModificarCliente(ECliente pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("ModificarClientes", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idCliente", pEN.idCliente));
            command.Parameters.Add(new SqlParameter("@NombreCliente", pEN.NombreCliente));
            command.Parameters.Add(new SqlParameter("@ApellidoPaternoCliente", pEN.ApellidoPaternoCliente));
            command.Parameters.Add(new SqlParameter("@ApellidoMaternoCliente", pEN.ApellidoMaternoCliente));
            command.Parameters.Add(new SqlParameter("@CelularCliente", pEN.CelularCliente));
            command.Parameters.Add(new SqlParameter("@CorreoCliente", pEN.CorreoCliente));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

        public int EliminarClientes(ECliente pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("EliminarClientes", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@id", pEN.idCliente));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

    }

}
