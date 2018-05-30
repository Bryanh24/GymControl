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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ELogin objEntidad = new ELogin();
        NLogin objNegocio = new NLogin();

        public void AgregarUsuario()
        {
            objEntidad.NombreUsuario = TxtRegistrarNombreUsu.Text;
            objEntidad.Pass = TxtRegistrarPassUsu.Text;
            int agregar = objNegocio.NAgregarUsuario(objEntidad);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            PanelIniciarSesion.Visible = true;
            PanelRegistrarse.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelIniciarSesion.Visible = false;
            PanelRegistrarse.Visible = true;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            PanelIniciarSesion.Visible = true;
            PanelRegistrarse.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }
    }
}
