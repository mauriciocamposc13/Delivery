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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void bCaja_Click(object sender, EventArgs e)
        {
            Caja caj = new Caja();
            caj.Show();
        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
