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
    public class DEmpleados
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
        EEmpleados Entidad = new EEmpleados();

        public DataTable DListado()

        {
            SqlCommand cmd = new SqlCommand("sp_listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();            
            da.Fill(dt);
            return dt;

        }

        public int AgregarEmpleados(EEmpleados pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("AgregarEmpleados", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Nombre", pEN.NombreEmpleado));
            command.Parameters.Add(new SqlParameter("@ApellidoPaterno", pEN.ApellidoPaternoEmpleado));
            command.Parameters.Add(new SqlParameter("@ApellidoMaterno", pEN.ApellidoMaternoEmpleado));
            command.Parameters.Add(new SqlParameter("@Celular", pEN.CelularEmpeado));
            command.Parameters.Add(new SqlParameter("@Correo", pEN.CorreoEmpleado));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

        public DataTable ConsultarNombreEmpleado(EEmpleados pEn)

        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("FiltroNombreEmpoleados", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@NombreEmpleado", pEn.ConsultarNombreEmpleado));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
       
            da.Fill(dt);
            cn.Close();
            return dt;

        }
        public int ModificarEmpleado(EEmpleados pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("ModificarEmpleados", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idEmpleado", pEN.idEmpleado));
            command.Parameters.Add(new SqlParameter("@NombreEmpleado", pEN.NombreEmpleado));
            command.Parameters.Add(new SqlParameter("@ApellidoPaternoEmpleado", pEN.ApellidoPaternoEmpleado));
            command.Parameters.Add(new SqlParameter("@ApellidoMaternoEmpleado", pEN.ApellidoMaternoEmpleado));
            command.Parameters.Add(new SqlParameter("@CelularEmpleado", pEN.CelularEmpeado));
            command.Parameters.Add(new SqlParameter("@CorreoEmpleado", pEN.CorreoEmpleado));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

        public int EliminarEmpleado(EEmpleados pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("EliminarEmpleado", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idEmpleado", pEN.idEmpleado));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }



    }
}
