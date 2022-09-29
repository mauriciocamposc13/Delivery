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
    public partial class ImprimirComanda : Form
    {
        public ImprimirComanda()
        {
            InitializeComponent();
        }
        public string numeroComanda { get; set; }
        private void ImprimirComanda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DeliveryDataSet.ImprimirComanda' Puede moverla o quitarla según sea necesario.
            this.ImprimirComandaTableAdapter.Fill(this.DeliveryDataSet.ImprimirComanda,Convert.ToInt64(numeroComanda));

            this.reportViewer1.RefreshReport();
        }
    }
}
