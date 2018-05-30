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
    public partial class PVentas : Form
    {
        public PVentas()
        {
            InitializeComponent();
        }
        EVentas objEntidad = new EVentas();
        NVentas objNegocio = new NVentas();

        private void  BuscarCliente()
        {
            objEntidad.IdProducto = Int32.Parse( txtDocIdentidad.Text);
            objEntidad.NombreCliente = txtDatos.Text;
            int agregar = objNegocio.AgregarEmpleados(objEntidad);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
    }
}
