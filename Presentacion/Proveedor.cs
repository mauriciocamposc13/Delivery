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
    public partial class Proveedor : Form
    {
        CN_Proveedor objetoCN = new CN_Proveedor();
        private bool Editar = false;
        public Proveedor()
        {
            InitializeComponent();
        }
        private void MostrarPProveedores()
        {
            CN_Proveedor objeto = new CN_Proveedor();
            dataGridView1.DataSource = objeto.MostrarNProveedores();
        }
        private void limpiarForm()
        {
            label2.Text="";
            textnomProv.Clear();
            textnomEmpl.Clear();
            texttelProv.Clear();
            textdomProv.Clear();
        }
        private void Proveedor_Load(object sender, EventArgs e)
        {
            MostrarPProveedores();
            label2.Text = "";
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {

            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarNProveedor(textnomProv.Text, textnomEmpl.Text, texttelProv.Text, textdomProv.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarPProveedores();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar Proveedor por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    label2.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                    objetoCN.EditarNProveedor(label2.Text, textnomProv.Text, textnomEmpl.Text, texttelProv.Text, textdomProv.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarPProveedores();
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
                label2.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                textnomProv.Text= dataGridView1.CurrentRow.Cells["Nombre Empresa"].Value.ToString();
                textnomEmpl.Text= dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                texttelProv.Text= dataGridView1.CurrentRow.Cells["Teléfono"].Value.ToString();
                textdomProv.Text= dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();


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
                label2.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
                objetoCN.EliminarNProveedor(label2.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarPProveedores();
                label2.Text = "";
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
        }
    }
}
