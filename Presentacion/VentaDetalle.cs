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
    public partial class VentaDetalle : Form
    {
        CN_Comanda objetoCN = new CN_Comanda();
        CN_Producto objetoProducto = new CN_Producto();
        public string numeroComanda { get; set; }
        public VentaDetalle()
        {
            InitializeComponent();
        }

        private void VentaDetalle_Load(object sender, EventArgs e)
        {
            lComanda.Text = numeroComanda;
            FiltrarProductoComanda("");
            FiltrarComidaComanda("");
            label8.Text = "";
            textCantidad.Text = "1";
            label12.Text = "";
            MostrarDetalleComanda(lComanda.Text);
            MostrarTotalComanda(lComanda.Text);//mostrar total comanda
           // label13.Text = objetoCN.NMostrarTotalComanda(lComanda.Text);//MOSTRAR TOTAL COMANDA ACA
            lComanda.Text = numeroComanda;
        }
        private void FiltrarProductoComanda(string filtro)
        {
            CN_Producto objeto = new CN_Producto();
            dataGridView1.DataSource = objeto.NFiltrarProductoComanda(filtro);
        }

        private void textProducto_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductoComanda(textProducto.Text);
        }

        private void MostrarTotalComanda(string filtro)
        {
            CN_Comanda objeto = new CN_Comanda();
            label13.Text  = objeto.NMostrarTotalComanda(filtro);
        }

        private void FiltrarComidaComanda(string filtro)
        {
            CN_Comida objeto = new CN_Comida();
            dataGridView2.DataSource = objeto.NFiltrarComidaComanda(filtro);
        }

        private void textComida_TextChanged(object sender, EventArgs e)
        {
            FiltrarComidaComanda(textComida.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label12.Text = "Producto";
            textCodigo.Text = dataGridView1.CurrentRow.Cells["Número"].Value.ToString();
            textNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textDescripción.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
            textPrecio.Text = dataGridView1.CurrentRow.Cells["Pr. Venta"].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label12.Text = "Comida";
            textCodigo.Text = dataGridView2.CurrentRow.Cells["Número"].Value.ToString();
            textNombre.Text = dataGridView2.CurrentRow.Cells["Nombre"].Value.ToString();
            textDescripción.Text = dataGridView2.CurrentRow.Cells["Descripción"].Value.ToString();
            textPrecio.Text = dataGridView2.CurrentRow.Cells["Pr. Venta"].Value.ToString();
        }

        //Detalle Comanda
        private void MostrarDetalleComanda(string filtro)
        {
            CN_Comanda objeto = new CN_Comanda();
            dataGridView3.DataSource = objeto.NMostrarDetalleComanda(filtro);
        }


        private void limpiarForm()
        {
            label12.Text = "";
            textCodigo.Clear();
            textNombre.Clear();
            textDescripción.Clear();
            textPrecio.Clear();
            textCantidad.Text = "1";

        }


        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.NInsertarDetalleComanda(textCodigo.Text, textNombre.Text, textDescripción.Text, textCantidad.Text, textPrecio.Text, lComanda.Text, label12.Text);
                
                if (label12.Text=="Producto")
                {
                    objetoProducto.NActualizarProducto(textCodigo.Text, textCantidad.Text);
                    FiltrarProductoComanda("");
                }
                
                objetoCN.NActualizarMontoComanda(lComanda.Text, textCantidad.Text, textPrecio.Text);
                MostrarTotalComanda(lComanda.Text);
                MessageBox.Show("Se inserto correctamente");
                MostrarDetalleComanda(lComanda.Text);
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar Detalle por: " + ex);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                label8.Text = dataGridView3.CurrentRow.Cells["Número"].Value.ToString();
                objetoCN.NEliminarDetalleComanda(label8.Text);
                if (label12.Text == "Producto")
                {
                    Decimal canti = Convert.ToDecimal(textCantidad.Text) * (-1M);
                    objetoProducto.NActualizarProducto(textCodigo.Text, Convert.ToString(canti));
                    FiltrarProductoComanda("");
                    canti = 0M;


                }
                Decimal cantiNeg = Convert.ToDecimal(textCantidad.Text)*(-1M);
                objetoCN.NActualizarMontoComanda(lComanda.Text, Convert.ToString(cantiNeg), textPrecio.Text);
                    cantiNeg = 0M;
                MostrarTotalComanda(lComanda.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarDetalleComanda(lComanda.Text);
                label8.Text = "";
                limpiarForm();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
          
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = dataGridView3.CurrentRow.Cells["Número"].Value.ToString();


            label12.Text = dataGridView3.CurrentRow.Cells["Tipo"].Value.ToString();//tipo
            label8.Text = dataGridView3.CurrentRow.Cells["Número"].Value.ToString(); ;//Numero Detalle
            textCantidad.Text = dataGridView3.CurrentRow.Cells["Cantidad"].Value.ToString();
            textCodigo.Text = dataGridView3.CurrentRow.Cells["Código"].Value.ToString();
            textNombre.Text = dataGridView3.CurrentRow.Cells["Nombre"].Value.ToString();
            textDescripción.Text = dataGridView3.CurrentRow.Cells["Descripción"].Value.ToString();
            textPrecio.Text = dataGridView3.CurrentRow.Cells["Precio Unid."].Value.ToString();


        }

     
    }
}
