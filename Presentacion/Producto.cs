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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        CN_Producto objetoCN = new CN_Producto();
        private bool Editar = false;
        private void Productos_Load(object sender, EventArgs e)
        {
            numero.Text = "";
            MostrarPProdcto();
        }
        private void MostrarPProdcto()
        {
            CN_Producto objeto = new CN_Producto();
            dataGridView1.DataSource = objeto.NMostrarProducto();
        }
        private void MostrarProductoFaltante()
        {
            CN_Producto objeto = new CN_Producto();
            dataGridView1.DataSource = objeto.NMostrarProductoFaltante();
        }
        private void limpiarForm()
        {
            textCod.Clear();
            textCodBarra.Clear();
            textNombre.Clear();
            textMarca.Clear();
            textDesc.Clear();
            textPCosto.Clear();
            textPVenta.Clear();
            textSMin.Clear();
            textSEx.Clear();
            dateTimeVto.Value = DateTime.Today;
            textCategoria.Clear();
        }       
        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.NInsertarProducto(textCod.Text, textCodBarra.Text, textNombre.Text, textMarca.Text, textPCosto.Text, textPVenta.Text, textDesc.Text, textSMin.Text, textSEx.Text,dateTimeVto.Value, textCategoria.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarPProdcto();
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
                    numero.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
                    objetoCN.NEditarProducto(numero.Text, textCod.Text, textCodBarra.Text, textNombre.Text, textMarca.Text, textPCosto.Text, textPVenta.Text, textDesc.Text, textSMin.Text, textSEx.Text, dateTimeVto.Value, textCategoria.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarPProdcto();
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
                textMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                textPCosto.Text = dataGridView1.CurrentRow.Cells["Pr. Costo"].Value.ToString();
                textPVenta.Text = dataGridView1.CurrentRow.Cells["Pr. Venta"].Value.ToString();
                textDesc.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
                textSMin.Text = dataGridView1.CurrentRow.Cells["Stock Minimo"].Value.ToString();
                textSEx.Text = dataGridView1.CurrentRow.Cells["Stock Existente"].Value.ToString();
               dateTimeVto.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Vencimiento"].Value);
                textCategoria.Text = dataGridView1.CurrentRow.Cells["Categoría"].Value.ToString();
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
                objetoCN.NEliminarProducto(numero.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarPProdcto();
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            Editar = false;
        }
        private void FiltrarPProducto(string filtro)
        {
            CN_Producto objeto4 = new CN_Producto();
            dataGridView1.DataSource = objeto4.NFiltrarProducto(filtro);
        }

        //Sumador
        private void FiltrarPProductoSumador(string filtro)
        {
            CN_Producto objeto4 = new CN_Producto();
            labelTotalcosto.Text = objeto4.NFiltrarProductoSumador(filtro);
        }
        private void FiltrarPProductoSumador2(string filtro)
        {
            CN_Producto objeto4 = new CN_Producto();
            labelTotalventa.Text = objeto4.NFiltrarProductoSumador2(filtro);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FiltrarPProducto(textFiltro.Text);
            FiltrarPProductoSumador2(textFiltro.Text);
            FiltrarPProductoSumador(textFiltro.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numero.Text= dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
        }

        private void bFaltante_Click(object sender, EventArgs e)
        {
            MostrarProductoFaltante();
        }
    }
}
