using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ControlDiario : Form
    {
        public ControlDiario()
        {
            InitializeComponent();
        }
        CN_Comanda objetoCN = new CN_Comanda();
        private void ControlDiarioProducto(DateTime filtro)
        {
            CN_Comanda objeto = new CN_Comanda();
            dataGridView1.DataSource = objeto.NControlDiarioProducto(filtro);
        }

        private void ControlDiarioProductoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_Comanda objeto = new CN_Comanda();
            dataGridView1.DataSource = objeto.NControlDiarioProductoFiltro(filtro1, filtro2, filtro3);
        }
        private void ControlDiarioComidaFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_Comanda objeto = new CN_Comanda();
            dataGridView2.DataSource = objeto.NControlDiarioComidaFiltro(filtro1, filtro2, filtro3);
        }
        private void ControlDiarioComida(DateTime filtro)
        {
            CN_Comanda objeto = new CN_Comanda();
            dataGridView2.DataSource = objeto.NControlDiarioComida(filtro);
        }

        //sumadores

        private void ControlDiarioProductoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_Comanda objeto = new CN_Comanda();
            label5.Text = objeto.NControlDiarioProductoFiltroSumador(filtro1, filtro2, filtro3);
        }
        private void ControlDiarioComidaFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_Comanda objeto = new CN_Comanda();
            label5.Text = objeto.NControlDiarioComidaFiltroSumador(filtro1, filtro2, filtro3);
        }
        private void ControlDiario_Load(object sender, EventArgs e)
        {
            ControlDiarioProducto(DateTime.Now);
            ControlDiarioComida(DateTime.Now);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ControlDiarioProducto(dateTimePicker1.Value);
            ControlDiarioComida(dateTimePicker1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlDiarioProductoFiltro(dateTimePicker2.Value, dateTimePicker3.Value, textBox1.Text);
            ControlDiarioProductoFiltroSumador(dateTimePicker2.Value, dateTimePicker3.Value, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlDiarioComidaFiltro(dateTimePicker2.Value, dateTimePicker3.Value, textBox1.Text);
            ControlDiarioComidaFiltroSumador(dateTimePicker2.Value, dateTimePicker3.Value, textBox1.Text);
        }
    }
}
