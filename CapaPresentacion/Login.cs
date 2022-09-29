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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textContaseña.Text=="86910923")
            {
                Delivery del = new Delivery();
                del.Show();
                this.Close();
            }
            else MessageBox.Show("Contraseña Incorrecta");
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
