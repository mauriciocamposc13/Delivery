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
    public partial class Repartidor : Form
    {
        public Repartidor()
        {
            InitializeComponent();
        }
        CN_Repartidor objetoCN = new CN_Repartidor();
        private bool Editar = false;
        private void Repartidor_Load(object sender, EventArgs e)
        {
            MostrarRepartidor();
            codRepartidor.Text = "";
        }

        private void MostrarRepartidor()
        {
            CN_Repartidor objeto = new CN_Repartidor();
            dataGridView1.DataSource = objeto.MostrarNRepartidor();
        }
        private void limpiarForm()
        {
            codRepartidor.Text = "";
            textNombreRepartidor.Clear();
            textTelRepartidor.Clear();
            textDescRepartidor.Clear();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarNRepartidor(textNombreRepartidor.Text, textTelRepartidor.Text, textDescRepartidor.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarRepartidor();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar Repartidor por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarNRepartidor(codRepartidor.Text, textNombreRepartidor.Text, textTelRepartidor.Text, textDescRepartidor.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarRepartidor();
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
                codRepartidor.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                textNombreRepartidor.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textTelRepartidor.Text = dataGridView1.CurrentRow.Cells["Teléfono"].Value.ToString();
                textDescRepartidor.Text = dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();

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
                codRepartidor.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                objetoCN.EliminarNRepartidor(codRepartidor.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarRepartidor();
                codRepartidor.Text = "";
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codRepartidor.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
        }
    }
}
