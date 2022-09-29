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
    public partial class IngresosEgresos : Form
    {
        //Filtros 
        private void MostrarIngresoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_IngresoEgreso objeto = new CN_IngresoEgreso();
            dataGridView2.DataSource = objeto.MostrarIngresoFiltro(filtro1, filtro2, filtro3);
        }
        private void MostrarIngresoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_IngresoEgreso objeto = new CN_IngresoEgreso();
            lTotal.Text = objeto.MostrarIngresoFiltroSumador(filtro1, filtro2, filtro3);
        }
        private void MostrarEgresoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_IngresoEgreso objeto = new CN_IngresoEgreso();
            dataGridView1.DataSource = objeto.MostrarEgresoFiltro(filtro1, filtro2, filtro3);
        }
        private void MostrarEgresoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            CN_IngresoEgreso objeto = new CN_IngresoEgreso();
            lTotal.Text = objeto.MostrarEgresoFiltroSumador(filtro1, filtro2, filtro3);
        }




        //Ingreso
        public IngresosEgresos()
        {
            InitializeComponent();
            lTotal.Text = "";
        }
        CN_IngresoEgreso objetoCN = new CN_IngresoEgreso();
        private bool Editar = false;
        private bool Editar1 = false;
        private void MostrarIngreso()
        {
            CN_IngresoEgreso objeto = new CN_IngresoEgreso();
            dataGridView2.DataSource = objeto.NMostrarIngreso();
        }
      
        private void limpiarForm()
        {
            textMonto.Clear();
            textDesc.Clear();
            textCategoriaI.Clear();
            dateTimeFchIngreso.Value = DateTime.Today;
        }
        private void bGuardarIngreso_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.NInsetarIngreso(dateTimeFchIngreso.Value, textMonto.Text, textDesc.Text, textCategoriaI.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarIngreso();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar producto por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    codIngreso.Text = dataGridView2.CurrentRow.Cells["Código"].Value.ToString();
                    objetoCN.NEditarIngreso(codIngreso.Text,dateTimeFchIngreso.Value, textMonto.Text, textDesc.Text, textCategoriaI.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarIngreso();
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

        private void bEditarIngreso_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Editar = true;
                codIngreso.Text = dataGridView2.CurrentRow.Cells["Código"].Value.ToString();
            dateTimeFchIngreso.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells["Fecha"].Value);
            textMonto.Text = dataGridView2.CurrentRow.Cells["Monto"].Value.ToString();
            textDesc.Text= dataGridView2.CurrentRow.Cells["Descripción"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void bEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (Editar == true)
            {
                Editar = false;
                limpiarForm();
                MessageBox.Show("Si seleccionó Editar primero tiene que Guardar para despúes eliminar, Seleccione de nuevo la fila a eliminar");
            }

            else if (dataGridView2.SelectedRows.Count > 0)
            {
                codIngreso.Text = dataGridView2.CurrentRow.Cells["Código"].Value.ToString();
                objetoCN.NEliminarIngreso(codIngreso.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarIngreso();
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codIngreso.Text = dataGridView2.CurrentRow.Cells["Código"].Value.ToString();
        }

       

        private void IngresosEgresos_Load(object sender, EventArgs e)
        {
            MostrarIngreso();
            codIngreso.Text = "";
            MostrarEgreso();
            codEgreso.Text = "";
        }

        //////////////EGRESOS

        private void MostrarEgreso()
        {
            CN_IngresoEgreso objeto1 = new CN_IngresoEgreso();
            dataGridView1.DataSource = objeto1.NMostrarEgreso();
        }

        private void limpiarForm1()
        {
            textMontoEgreso.Clear();
            textDescEgreso.Clear();
            textCategoriaE.Clear();
            dateTimeFchEgreso.Value = DateTime.Today;
        }

        private void bGuardarEgreso_Click(object sender, EventArgs e)
        {
            if (Editar1 == false)
            {
                try
                {
                    objetoCN.NInsetarEgreso(dateTimeFchEgreso.Value, textMontoEgreso.Text, textDescEgreso.Text, textCategoriaE.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarEgreso();
                    limpiarForm1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar producto por: " + ex);
                }
            }
            if (Editar1 == true)
            {
                try
                {
                    codEgreso.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                    objetoCN.NEditarEgreso(codEgreso.Text,dateTimeFchEgreso.Value, textMontoEgreso.Text, textDescEgreso.Text, textCategoriaE.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarEgreso();
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

        private void bEditarEgreso_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar1 = true;
                codEgreso.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                dateTimeFchEgreso.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha"].Value);
                textMontoEgreso.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
                textDescEgreso.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void bEliminarEgreso_Click(object sender, EventArgs e)
        {
            if (Editar1 == true)
            {
                Editar1 = false;
                limpiarForm1();
                MessageBox.Show("Si seleccionó Editar primero tiene que Guardar para despúes eliminar, Seleccione de nuevo la fila a eliminar");
            }

            else if (dataGridView1.SelectedRows.Count > 0)
            {
                codEgreso.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                objetoCN.NEliminarEgreso(codEgreso.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarEgreso();
                limpiarForm1();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar1 = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codEgreso.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarIngresoFiltro(dateTimePicker1.Value, dateTimePicker2.Value, tCateg.Text);
            MostrarIngresoFiltroSumador(dateTimePicker1.Value, dateTimePicker2.Value, tCateg.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarEgresoFiltro(dateTimePicker1.Value, dateTimePicker2.Value, tCateg.Text);
            MostrarEgresoFiltroSumador(dateTimePicker1.Value, dateTimePicker2.Value, tCateg.Text);
        }
    }
}
