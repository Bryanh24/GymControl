using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }
        ECliente objEntidad = new ECliente();
        NCliente objNegocio = new NCliente();

        private void IgualarEntidades()
        {

            objEntidad.NombreCliente = ConsultarNombreCliente.Text;
            objEntidad.ApellidoPaternoCliente = ConsApellidoPaternoCliente.Text;
            objEntidad.ApellidoMaternoCliente = ConsApellidoMaternoCliente.Text;
            objEntidad.CelularCliente = ConsultarCelularCliente.Text;
            objEntidad.CorreoCliente = ConsultarCorreoCliente.Text;
            int agregar = objNegocio.AgregarEmpleados(objEntidad);
        }

        private void LimpiarTxtBox()
        {
            ConsultarIdCliente.Text = "";
            ConsultarNombreCliente.Text = "";
            ConsApellidoPaternoCliente.Text = "";
            ConsApellidoMaternoCliente.Text = "";
            ConsultarCelularCliente.Text = "";
            ConsultarCorreoCliente.Text = "";
        }
        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            IgualarEntidades();
            LimpiarTxtBox();
            DataTable dt = objNegocio.NListadoClientes();
            TablaClientes.DataSource = dt;
            MessageBox.Show("Se agrego al cliente existosamente.");
        }

        private void TablaEmpleados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

           

          

        }

        private void TablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = objNegocio.NListadoClientes();
            TablaClientes.DataSource = dt;
      

        }

        private void TablaClientes_Click(object sender, EventArgs e)
        {

            LlenarTextBox(0);
        }

        public  void LlenarTextBox(int Columna)
        {
            
            Columna = TablaClientes.CurrentRow.Index;
            ConsultarIdCliente.Text = TablaClientes.Rows[Columna].Cells[0].Value.ToString();
            ConsultarNombreCliente.Text = TablaClientes.Rows[Columna].Cells[1].Value.ToString();
            ConsApellidoPaternoCliente.Text = TablaClientes.Rows[Columna].Cells[2].Value.ToString();
            ConsApellidoMaternoCliente.Text = TablaClientes.Rows[Columna].Cells[3].Value.ToString();
            ConsultarCelularCliente.Text = TablaClientes.Rows[Columna].Cells[4].Value.ToString();
            ConsultarCorreoCliente.Text = TablaClientes.Rows[Columna].Cells[5].Value.ToString();


        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            IgualarEntidades();
            DataTable dt = objNegocio.NListadoClientes();
            TablaClientes.DataSource = dt;
            LimpiarTxtBox();
            MessageBox.Show("Se actualizo el registro correctamente.");

        }

        private void BtnEliminarRegistro_Click(object sender, EventArgs e)
        {
            objEntidad.idCliente = Int32.Parse( ConsultarIdCliente.Text);
            int eliminar = objNegocio.EliminarClientes(objEntidad);
            DataTable dt = objNegocio.NListadoClientes();
            TablaClientes.DataSource = dt;
            TablaClientes.DataSource = dt;
            ConsultarIdCliente.Text = "";
            ConsultarNombreCliente.Text = "";
            ConsApellidoPaternoCliente.Text = "";
            ConsApellidoMaternoCliente.Text = "";
            ConsultarCelularCliente.Text = "";
            ConsultarCorreoCliente.Text = "";
            MessageBox.Show("Se ha eliminado el registro correctamente.");

        }
    }
}
