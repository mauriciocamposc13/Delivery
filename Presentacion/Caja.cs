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
    public partial class Caja : Form
    {
        
        public Caja()
        {
            InitializeComponent();
        }
        CN_Caja objetoCN = new CN_Caja();
        private bool Editar = false;
        private bool Editar1 = false;
        private void Caja_Load(object sender, EventArgs e)
        {
            codigoCaja.Text = "";
            codigoCaja1.Text = "";
            numeroDetalleCaja.Text = "";
            MostrarPCaja();
            textmontoInicio.Text = "0";
            textmontoCierre.Text = "0";
            textEfectivo.Text = "0";
            textDebito.Text = "0";
        }
        private void MostrarPCaja()
        {
            CN_Caja objeto = new CN_Caja();
            dataGridView1.DataSource = objeto.NMostrarCaja();
        }
        private void limpiarForm()
        {
            codigoCaja.Text = "";
            dateTimeFecha.Value = DateTime.Now;
            textNombre.Clear();
            textmontoInicio.Text = "0";
            textmontoCierre.Text = "0";
        }
        private void limpiarForm1()
        {
            textDetalle.Clear();
            textEfectivo.Text = "0";
            textDebito.Text = "0";

        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.NInsertarCaja(dateTimeFecha.Value, textNombre.Text, textmontoInicio.Text, textmontoInicio.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarPCaja();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar Caja por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.NEditarCaja(codigoCaja.Text, dateTimeFecha.Value, textNombre.Text, textmontoInicio.Text, textmontoCierre.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarPCaja();
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                codigoCaja.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                dateTimeFecha.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString());
                textNombre.Text = dataGridView1.CurrentRow.Cells["Nombre Empleado"].Value.ToString();               
                textmontoInicio.Text = dataGridView1.CurrentRow.Cells["Monto Inicio"].Value.ToString();
                textmontoCierre.Text = dataGridView1.CurrentRow.Cells["Monto Cierre"].Value.ToString();
               
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
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                codigoCaja.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                objetoCN.NEliminarCaja(codigoCaja.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarPCaja();
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;
        }
        private void FiltrarPCaja(DateTime filtro)
        {
            CN_Caja objeto4 = new CN_Caja();
            dataGridView1.DataSource = objeto4.NFiltrarCaja(filtro);
        }
        private void dateTimeFiltro_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPCaja(dateTimeFiltro.Value);
        }
        private void FiltrarPDetalleCaja(string filtro)
        {
            CN_Caja objeto4 = new CN_Caja();
            dataGridView2.DataSource = objeto4.NFiltrarDetalleCaja(filtro);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoCaja.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
            codigoCaja1.Text= dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
            FiltrarPDetalleCaja(codigoCaja1.Text);
        }
        //DETALLE CAJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numeroDetalleCaja.Text= dataGridView2.CurrentRow.Cells["Número Detalle"].Value.ToString();
        }
        private void bGuardar1_Click(object sender, EventArgs e)
        {
            if (Editar1 == false)
            {
                try
                {
                    objetoCN.NInsertarDetalleCaja(textDetalle.Text, textEfectivo.Text, textDebito.Text, codigoCaja1.Text);
                    objetoCN.NAtualizarCaja(codigoCaja1.Text, textEfectivo.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarPCaja();
                    FiltrarPDetalleCaja(codigoCaja1.Text);
                    limpiarForm1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar Caja por: " + ex);
                }
            }
            if (Editar1 == true)
            {
                try
                {
                    objetoCN.NEditarDetalleCaja(numeroDetalleCaja.Text,textDetalle.Text, textEfectivo.Text, textDebito.Text, codigoCaja1.Text);
                    objetoCN.NAtualizarCaja3(codigoCaja1.Text, dataGridView2.CurrentRow.Cells["Efectivo"].Value.ToString(),textEfectivo.Text);
                    MessageBox.Show("Se editó correctamente");
                    FiltrarPDetalleCaja(codigoCaja1.Text);
                    limpiarForm1();
                    Editar1 = false;
                }
                catch (Exception ex)
                {
                    limpiarForm1();
                    Editar1 = false;
                    MessageBox.Show("No se pudo editar por: " + ex);
                }
            }
        }
        private void bEditar1_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                Editar1 = true;
                numeroDetalleCaja.Text = dataGridView2.CurrentRow.Cells["Número Detalle"].Value.ToString();
                textDetalle.Text = dataGridView2.CurrentRow.Cells["Detalle"].Value.ToString();
                textEfectivo.Text = dataGridView2.CurrentRow.Cells["Efectivo"].Value.ToString();
                textDebito.Text = dataGridView2.CurrentRow.Cells["Debito"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void bEliminar1_Click(object sender, EventArgs e)
        {
            if (Editar1 == true)
            {
                Editar1 = false;
                limpiarForm1();
                MessageBox.Show("Si seleccionó Editar primero tiene que Guardar para despúes eliminar, Seleccione de nuevo la fila a eliminar");
            }
            else if (dataGridView2.SelectedRows.Count > 0)
            {
                numeroDetalleCaja.Text = dataGridView2.CurrentRow.Cells["Número Detalle"].Value.ToString();                
                objetoCN.NAtualizarCaja2(codigoCaja1.Text, dataGridView2.CurrentRow.Cells["Efectivo"].Value.ToString());
                objetoCN.NEliminarDetalleCaja(numeroDetalleCaja.Text);
                MostrarPCaja();
                MessageBox.Show("Eliminado correctamente");
                FiltrarPDetalleCaja(codigoCaja1.Text);
                limpiarForm1();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar1 = false;
        }
        private void bTodas_Click(object sender, EventArgs e)
        {
            MostrarPCaja();
        }
        private void bVender_Click(object sender, EventArgs e)
        {
            if (codigoCaja1.Text != "")
            {
                Venta vend = new Venta();
               vend.numeroCaja = codigoCaja1.Text;
                vend.Show();
            }
            else MessageBox.Show("Seleccione una Caja");
        }
        private void bActualizar_Click(object sender, EventArgs e)
        {if (codigoCaja1.Text != "") {
                FiltrarPDetalleCaja(codigoCaja1.Text);                
            }
            else MessageBox.Show("Seleccione una Caja");
        }
    }
}
