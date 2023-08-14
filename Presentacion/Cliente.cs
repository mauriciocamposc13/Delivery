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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        CN_Cliente objetoCN = new CN_Cliente();
        private bool Editar = false;
        private void Cliente_Load(object sender, EventArgs e)
        {
            MostrarClien();
            codCliente.Text = "";
        }
        private void MostrarClien()
        {
            CN_Cliente objeto = new CN_Cliente();
            dataGridView1.DataSource = objeto.MostrarNCliente();
        }
        private void limpiarForm()
        {
            codCliente.Text="";
            textNombre.Clear();
            textTel.Clear();
            textDesc.Clear();
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarNCliente(textNombre.Text, textTel.Text, textDesc.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarClien();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar cliente por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarNCliente(codCliente.Text,textNombre.Text, textTel.Text, textDesc.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarClien();
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
                codCliente.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                textNombre.Text= dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textTel.Text = dataGridView1.CurrentRow.Cells["Teléfono"].Value.ToString();
                textDesc.Text = dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();
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
                codCliente.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                objetoCN.EliminarNCliente(codCliente.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarClien();
                codCliente.Text = "";
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codCliente.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
        }
    }     
}
