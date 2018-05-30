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
    public  class DProductos
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
        EEmpleados Entidad = new EEmpleados();

        public DataTable DListadoProductos()

        {
            SqlCommand cmd = new SqlCommand("sp_ListarProductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public int DAgregarProductos(EProductos pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("AgregarProductos", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@PrecioCompraProducto", pEN.PrecioCompraProducto));
            command.Parameters.Add(new SqlParameter("@PrecioVentaProducto", pEN.PrecioVentaProducto));
            command.Parameters.Add(new SqlParameter("@MarcaProducto", pEN.MarcaProducto));
            command.Parameters.Add(new SqlParameter("@DescripcionProducto", pEN.DescripcionProducto));
            command.Parameters.Add(new SqlParameter("@StockProducto", pEN.StockProducto));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

        public int EliminarProductos(EProductos pEN)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("EliminarProductos", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idProducto", pEN.idProducto));
            int resultado = (int)command.ExecuteNonQuery();
            cn.Close();
            return resultado;
        }

    }
}
