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
    public partial class PProductos : Form
    {
        public PProductos()
        {
            InitializeComponent();
        }
        EProductos objEntidad = new EProductos();
        NProductos objNegocio = new NProductos();

        void ListarEmpleado()
        {
            DataTable dt = objNegocio.NListadoProductos();
            TablaProductos.DataSource = dt;
        }
        public void eliminarProductos()
        {
            objEntidad.idProducto = Int32.Parse(BtnId.Text);
            int eliminar = objNegocio.NEliminarProductos(objEntidad);
            DataTable dt = objNegocio.NListadoProductos();
            TablaProductos.DataSource = dt;
            TablaProductos.DataSource = dt;
            BtnCantidad.Text = "";
            btnDescripcion.Text = "";
            BtnId.Text = "";
            btnMarca.Text = "";
            BtnPrecioCompra.Text = "";
            BtnPrecioVenta.Text = "";
            
            MessageBox.Show("Se ha eliminado el registro correctamente.");

        }
        private void PProductos_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objEntidad.PrecioCompraProducto = double.Parse( BtnPrecioCompra.Text);
            objEntidad.PrecioVentaProducto = double.Parse(BtnPrecioVenta.Text);
            objEntidad.MarcaProducto = btnMarca.Text;
            objEntidad.DescripcionProducto = btnDescripcion.Text;
            objEntidad.StockProducto =Int32.Parse(BtnCantidad.Text);
            DataTable dt = objNegocio.NListadoProductos();
            int agregar = objNegocio.NAgregarProducto(objEntidad);
            TablaProductos.DataSource = dt;
        }
        public void LlenarTextBox(int Columna)
        {

            Columna = TablaProductos.CurrentRow.Index;

            BtnId.Text = TablaProductos.Rows[Columna].Cells[0].Value.ToString();
            BtnPrecioCompra.Text = TablaProductos.Rows[Columna].Cells[1].Value.ToString();
            BtnPrecioVenta.Text = TablaProductos.Rows[Columna].Cells[2].Value.ToString();
            btnMarca.Text = TablaProductos.Rows[Columna].Cells[3].Value.ToString();
            btnDescripcion.Text = TablaProductos.Rows[Columna].Cells[4].Value.ToString();
            BtnCantidad.Text = TablaProductos.Rows[Columna].Cells[5].Value.ToString();


        }

        private void TablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBox(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminarProductos();
        }
    }
}
