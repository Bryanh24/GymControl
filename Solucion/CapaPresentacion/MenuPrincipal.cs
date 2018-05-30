using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (PanelMenuVertical.Width == 250)
            {
                PanelMenuVertical.Width = 50;
            }
            else
            {
                PanelMenuVertical.Width = 250;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio1());
        }

        private void AbrirFormulario(object FormularioHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = FormularioHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Bottom;
                fh.Size = this.panelContenedor.Size;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AgregarCliente());

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AgregarEmpleado());
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PProductos());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PVentas());

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new VMembrecia());

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox5.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}