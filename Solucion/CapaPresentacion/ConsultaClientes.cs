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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }
        ECliente objEntidad = new ECliente();
        NCliente objNegocio = new NCliente();
        VMembrecia membrecias = new VMembrecia();
        MenuPrincipal MenuPrincipal = new MenuPrincipal();


        private void AbrirFormulario(object FormularioHijo)
        {
            if (MenuPrincipal.panelContenedor.Controls.Count > 0)
            MenuPrincipal.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormularioHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Bottom;
            fh.Size = MenuPrincipal.panelContenedor.Size;
            MenuPrincipal.panelContenedor.Controls.Add(fh);
            MenuPrincipal.panelContenedor.Tag = fh;
            fh.Show();

        }
        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            DataTable dt = objNegocio.NListadoClientes();
            TablaClientes.DataSource = dt;

        }

        public void LlenarTextBox(int Columna)
        {

            Columna = TablaClientes.CurrentRow.Index;
            membrecias.TxtId.Text = TablaClientes.Rows[Columna].Cells[0].Value.ToString();
            membrecias.txtNombre.Text = TablaClientes.Rows[Columna].Cells[1].Value.ToString();
            membrecias.textBox2.Text = TablaClientes.Rows[Columna].Cells[2].Value.ToString();
            membrecias.textBox3.Text = TablaClientes.Rows[Columna].Cells[3].Value.ToString();
            

        }

        private void TablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBox(0);
            membrecias.Update();

        }
    }
}
