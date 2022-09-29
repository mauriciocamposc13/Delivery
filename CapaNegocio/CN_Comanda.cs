using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
   public class CN_Comanda
    {

        private CD_Comanda objetoCD = new CD_Comanda();

        public DataTable NMostrarComanda(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarComanda(Convert.ToInt64(filtro));
            return tabla;
        }

        public void NInsetarComanda(DateTime fechaComanda, string nomCliente, string nomRepartiodor, string observacion, string montoTotal, string montoEfectivo, string montoDebito, string codCaja)
        {

            objetoCD.InsetarComanda(fechaComanda, nomCliente, nomRepartiodor, observacion,Convert.ToDecimal(montoTotal),Convert.ToDecimal(montoEfectivo),Convert.ToDecimal(montoDebito),Convert.ToInt64(codCaja));
        }
        public void EditarComanda(string codComanda, DateTime fechaComanda, string nomCliente, string nomRepartiodor, string observacion, string montoTotal, string montoEfectivo, string montoDebito, string codCaja)
        {
            objetoCD.EditarComanda(Convert.ToInt64(codComanda),fechaComanda, nomCliente, nomRepartiodor, observacion, Convert.ToDecimal(montoTotal), Convert.ToDecimal(montoEfectivo), Convert.ToDecimal(montoDebito), Convert.ToInt64(codCaja));
        }
        public void NEliminarComanda(string codComanda)
        {
            objetoCD.EliminarComanda(Convert.ToInt64(codComanda));
        }
        public void NActualizarMontoComanda(string codComanda,string cantidad, string precio)
        {
            objetoCD.ActualizarMontoComanda(Convert.ToInt64(codComanda),Convert.ToDecimal(cantidad),Convert.ToDecimal(precio));

        }

        public string NMostrarTotalComanda(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTotalComanda(Convert.ToInt64(filtro));
            string tot=tabla.Rows[0]["montoTotal"].ToString();
            return tot;
        }

        //Detalle Comanda
        public DataTable NMostrarDetalleComanda(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarDetalleComanda(Convert.ToInt64(filtro));
            return tabla;
        }
        public void NInsertarDetalleComanda(string codigo, string nombre, string descrip, string cantidad,string precioUnidad, string codComanda, string tipo)
        { 
            objetoCD.InsertarDetalleComanda( codigo, nombre, descrip, Convert.ToDecimal(cantidad), Convert.ToDecimal(precioUnidad),Convert.ToInt64(codComanda), tipo);
        }
    
        public void NEliminarDetalleComanda(string codDComanda)
        {
            objetoCD.EliminarDetalleComanda(Convert.ToInt64(codDComanda));
        }
        ///Filtros especiales ControlDiarioProducto

        public DataTable NControlDiarioProducto(DateTime filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ControlDiarioProducto(filtro);
            return tabla;
        }

        public DataTable NControlDiarioComida(DateTime filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ControlDiarioComida(filtro);
            return tabla;
        }
        public DataTable NControlDiarioProductoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ControlDiarioProductoFiltro(filtro1, filtro2, filtro3);
            return tabla;
        }
        public DataTable NControlDiarioComidaFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ControlDiarioComidaFiltro(filtro1, filtro2, filtro3);
            return tabla;
        }
        //Sumador
        public string NControlDiarioProductoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ControlDiarioProductoFiltroSumador(filtro1, filtro2, filtro3);
            string tot2 = tabla.Rows[0]["Total"].ToString();
            return tot2;
        }
        public string NControlDiarioComidaFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ControlDiarioComidaFiltroSumador(filtro1, filtro2, filtro3);
            string tot1 = tabla.Rows[0]["Total"].ToString();
            return tot1;
        }
        /*    public string NMostrarTotalComanda(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTotalComanda(Convert.ToInt64(filtro));
            string tot=tabla.Rows[0]["montoTotal"].ToString();
            return tot;
        }*/
    }
}
