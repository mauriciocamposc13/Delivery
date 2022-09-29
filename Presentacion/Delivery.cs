using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void bProducto_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            pro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresosEgresos ing = new IngresosEgresos();
            ing.Show();
        }

        private void bComida_Click(object sender, EventArgs e)
        {
            Comida com = new Comida();
            com.Show();
        }

        private void bProveedor_Click(object sender, EventArgs e)
        {
            Proveedor pro = new Proveedor();
            pro.Show();
        }

        private void bCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
        }

        private void bRepartidor_Click(object sender, EventArgs e)
        {
            Repartidor repa = new Repartidor();
            repa.Show();
        }

        private void bCaja_Click(object sender, EventArgs e)
        {
            Caja caj = new Caja();
            caj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlDiario con = new ControlDiario();
            con.Show();
        }
    }
}
