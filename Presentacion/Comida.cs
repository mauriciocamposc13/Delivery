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
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }
        CN_Comida objetoCN = new CN_Comida();
        private bool Editar = false;

        private void Comida_Load(object sender, EventArgs e)
        {
            numero.Text = "";
            MostrarPComida();
        }
        private void MostrarPComida()
        {
            CN_Comida objeto = new CN_Comida();
            dataGridView1.DataSource = objeto.NMostrarComida();
        }
        private void limpiarForm()
        {
            numero.Text = "";
            textCod.Clear();
            textCodBarra.Clear();
            textNombre.Clear();          
            textDesc.Clear();
            textPCosto.Clear();
            textPVenta.Clear();
        
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.NInsertarComida(textCod.Text, textCodBarra.Text, textNombre.Text, textPCosto.Text, textPVenta.Text, textDesc.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarPComida();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar Comida por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    numero.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                    objetoCN.NEditarComida(numero.Text, textCod.Text, textCodBarra.Text, textNombre.Text, textPCosto.Text, textPVenta.Text, textDesc.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarPComida();
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
                numero.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                textCod.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                textCodBarra.Text = dataGridView1.CurrentRow.Cells["Código de Barra"].Value.ToString();
                textNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textPCosto.Text = dataGridView1.CurrentRow.Cells["Pr. Costo"].Value.ToString();
                textPVenta.Text = dataGridView1.CurrentRow.Cells["Pr. Venta"].Value.ToString();
                textDesc.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
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
                numero.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                objetoCN.NEliminarComida(numero.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarPComida();
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;
        }
        private void FiltrarPComida(string filtro)
        {
            CN_Comida objeto4 = new CN_Comida();
            dataGridView1.DataSource = objeto4.NFiltrarComida(filtro);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numero.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FiltrarPComida(textFiltro.Text);
        }
    }
}
