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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        public string numeroCaja { get; set; }
        CN_Comanda objetoCN = new CN_Comanda();
        CN_Caja objetoCN1 = new CN_Caja();
        private bool Editar = false;

        private void FiltrarCliente(string filtro)
        {
            CN_Cliente objeto = new CN_Cliente();
            dataGridView1.DataSource = objeto.FiltrarNCliente(filtro);
        }
        private void FiltrarRepartidor(string filtro)
        {
            CN_Repartidor objeto = new CN_Repartidor();
            dataGridView2.DataSource = objeto.FiltrarNRepartidor(filtro);
        }
        private void MostrarComanda(string filtro)
        {
            CN_Comanda objeto = new CN_Comanda();
            dataGridView3.DataSource = objeto.NMostrarComanda(filtro);
        }
        private void Venta_Load(object sender, EventArgs e)
        {
            
            lnro.Text = "";
            lnroCaja.Text = numeroCaja;
            FiltrarCliente("");
            FiltrarRepartidor("");
            textTotal.Text = "0";
            textEfectivo.Text = "0";
            textDebito.Text = "0";
            label11.Text = "";
            MostrarComanda(lnroCaja.Text);
        }
        private void limpiarForm()
        {
            lnro.Text = "";
            dateTimeFecha.Value= DateTime.Today;
            textCliente.Text = "";
            textRepartidor.Text = "";
            textObs.Text = "";
            textTotal.Text = "0";
            textEfectivo.Text = "0";
            textDebito.Text = "0";
            label11.Text = "";
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.NInsetarComanda(dateTimeFecha.Value, textCliente.Text, textRepartidor.Text, textObs.Text, textTotal.Text, textEfectivo.Text, textDebito.Text, lnroCaja.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarComanda(lnroCaja.Text);
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar Comanda por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarComanda(lnro.Text,dateTimeFecha.Value, textCliente.Text, textRepartidor.Text, textObs.Text, textTotal.Text, textEfectivo.Text, textDebito.Text, lnroCaja.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarComanda(lnroCaja.Text);
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    limpiarForm();
                    Editar = false;
                    MessageBox.Show("No se pudo editar por: " + ex);
                }
            }

        }

        private void bEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {
                Editar = true;
                lnro.Text = dataGridView3.CurrentRow.Cells["Codigo"].Value.ToString();
                dateTimeFecha.Value = Convert.ToDateTime(dataGridView3.CurrentRow.Cells["Fecha"].Value.ToString());
                textCliente.Text = dataGridView3.CurrentRow.Cells["Cliente"].Value.ToString();
                textRepartidor.Text = dataGridView3.CurrentRow.Cells["Repartidor"].Value.ToString();
                textObs.Text = dataGridView3.CurrentRow.Cells["Observación"].Value.ToString();
                textTotal.Text = dataGridView3.CurrentRow.Cells["Total"].Value.ToString();
                textEfectivo.Text = dataGridView3.CurrentRow.Cells["Efectivo"].Value.ToString();
                textDebito.Text = dataGridView3.CurrentRow.Cells["Debito"].Value.ToString();

          
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (Editar == true)
            {
                Editar = false;
                limpiarForm();
                MessageBox.Show("Si seleccionó Editar primero tiene que Guardar para despúes eliminar, Seleccione de nuevo la fila a eliminar");
            }
            else if (dataGridView3.SelectedRows.Count > 0)
            {
                lnro.Text = dataGridView3.CurrentRow.Cells["Codigo"].Value.ToString();
                objetoCN.NEliminarComanda(lnro.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarComanda(lnroCaja.Text);
                lnro.Text = "";
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lnro.Text= dataGridView3.CurrentRow.Cells["Codigo"].Value.ToString();
            dateTimeFecha.Value = Convert.ToDateTime(dataGridView3.CurrentRow.Cells["Fecha"].Value.ToString());
            textCliente.Text = dataGridView3.CurrentRow.Cells["Cliente"].Value.ToString();
            textRepartidor.Text = dataGridView3.CurrentRow.Cells["Repartidor"].Value.ToString();
            textObs.Text = dataGridView3.CurrentRow.Cells["Observación"].Value.ToString();
            textTotal.Text = dataGridView3.CurrentRow.Cells["Total"].Value.ToString();
            textEfectivo.Text = dataGridView3.CurrentRow.Cells["Efectivo"].Value.ToString();
            textDebito.Text = dataGridView3.CurrentRow.Cells["Debito"].Value.ToString();
            label11.Text= dataGridView3.CurrentRow.Cells["Codigo"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCliente.Text= dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textRepartidor.Text= dataGridView2.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void textFClien_TextChanged(object sender, EventArgs e)
        {
            FiltrarCliente(textFClien.Text);
        }

        private void textFRep_TextChanged(object sender, EventArgs e)
        {
            FiltrarRepartidor(textFRep.Text);
        }

        private void bACaja_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                string detallecaja = "Comanda n° " + lnro.Text + " Cliente: " + textCliente.Text + " Repartidor: " + textRepartidor.Text;
                objetoCN1.NInsertarDetalleCaja(detallecaja, textEfectivo.Text, textDebito.Text, lnroCaja.Text);
                objetoCN1.NAtualizarCaja(lnroCaja.Text, textEfectivo.Text);
                MessageBox.Show("Se inserto correctamente");
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void bADetalle_Click(object sender, EventArgs e)
        {

            if (label11.Text != "")
            {
                VentaDetalle ventadeta = new VentaDetalle();
                ventadeta.numeroComanda = label11.Text;
                ventadeta.Show();
            }
            else MessageBox.Show("Seleccione una Comanda");
            
            
        }

  
        private void bActualizar_Click(object sender, EventArgs e)
        {
            MostrarComanda(lnroCaja.Text);
        }
    }
}
