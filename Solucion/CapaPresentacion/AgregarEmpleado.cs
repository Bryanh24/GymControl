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
using System.Net.Mail;

namespace CapaPresentacion
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }
        EEmpleados objEntidad = new EEmpleados();
        NEmpleados objNegocio = new NEmpleados();

        void ListarEmpleado()
        {
            DataTable dt = objNegocio.NListado();
            TablaEmpleados.DataSource = dt;
        }
        private void LimpiarTextBox()
        {
            ConsNombreEmpleado.Text = "";
            ConsApellidoPaterno.Text = "";
            ConsApellidoMaterno.Text = "";
            ConsCorreoEmpleado.Text = "";
            ConsCelularEmpleado.Text = "";
        }

        private void IgualarEntidaes()
        {
            objEntidad.idEmpleado = Int32.Parse(ConsId.Text);
            objEntidad.NombreEmpleado = ConsNombreEmpleado.Text;
            objEntidad.ApellidoPaternoEmpleado = ConsApellidoPaterno.Text;
            objEntidad.ApellidoMaternoEmpleado = ConsApellidoMaterno.Text;
            objEntidad.CelularEmpeado = ConsCorreoEmpleado.Text;
            objEntidad.CorreoEmpleado = ConsCelularEmpleado.Text;
          
        }
       


        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            IgualarEntidaes();
            int agregar = objNegocio.ModificarEmpleado(objEntidad);
            LimpiarTextBox();
            ListarEmpleado();
            MessageBox.Show("Se agrego al Empleado existosamente.");
        }


        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
        }


        private void BtnEliminarRegistro_Click(object sender, EventArgs e)
        {
            objEntidad.idEmpleado = Int32.Parse(ConsId.Text);
            int eliminar = objNegocio.EliminarClientes(objEntidad);
            LimpiarTextBox();
            ListarEmpleado();
            MessageBox.Show("Se Elimino al Empleado existosamente.");

        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            IgualarEntidaes();
            int agregar = objNegocio.ModificarEmpleado(objEntidad);
            LimpiarTextBox();
            ListarEmpleado();
            MessageBox.Show("Se actualizo el registro correctamente.");

        }
        public void LlenarTextBox(int Columna)
        {

            Columna = TablaEmpleados.CurrentRow.Index;
            ConsId.Text = TablaEmpleados.Rows[Columna].Cells[0].Value.ToString();
            ConsNombreEmpleado.Text = TablaEmpleados.Rows[Columna].Cells[1].Value.ToString();
            ConsApellidoPaterno.Text = TablaEmpleados.Rows[Columna].Cells[2].Value.ToString();
            ConsApellidoMaterno.Text = TablaEmpleados.Rows[Columna].Cells[3].Value.ToString();
            ConsCelularEmpleado.Text = TablaEmpleados.Rows[Columna].Cells[4].Value.ToString();
            ConsCorreoEmpleado.Text = TablaEmpleados.Rows[Columna].Cells[5].Value.ToString();


        }

        private void TablaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBox(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras.","Formato no valido.");
            }
        }

        private void ConsCelularEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten Numeros.", "Formato no valido.");
            }

        }

        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void ConsCorreoEmpleado_Leave(object sender, EventArgs e)
        {
            if (validarEmail(ConsCorreoEmpleado.Text))
            {

            }
            else
            {
                MessageBox.Show("Correo invalido ejemplo: example@site.com", "Formato no valido.");
            }
        }
    }
}
