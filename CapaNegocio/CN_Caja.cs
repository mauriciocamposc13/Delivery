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
    public class CN_Caja
    {

        private CD_Caja objetoCD = new CD_Caja();
        public DataTable NMostrarCaja()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCaja();
            return tabla;
        }
        public DataTable NFiltrarCaja(DateTime filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarCaja(filtro);
            return tabla;
        }
   
        public void NInsertarCaja(DateTime fecha,string nomEmpleado, string montoInicio, string montoCierre)
        {

            objetoCD.InsertarCaja(fecha, nomEmpleado,  Convert.ToDecimal(montoInicio), Convert.ToDecimal(montoCierre));
        }

        public void NEditarCaja(string codCaja, DateTime fecha, string nomEmpleado, string montoInicio, string montoCierre)
        {

            objetoCD.EditarCaja(Convert.ToInt64(codCaja), fecha, nomEmpleado, Convert.ToDecimal(montoInicio), Convert.ToDecimal(montoCierre));
        }
        public void NEliminarCaja(string codCaja)
        {
            objetoCD.EliminarCaja(Convert.ToInt64(codCaja));
        }

        public void NAtualizarCaja(string codCaja, string montoCierre)
        {

            objetoCD.AtualizarCaja(Convert.ToInt64(codCaja),  Convert.ToDecimal(montoCierre));
        }
        public void NAtualizarCaja2(string codCaja, string montoCierre)
        {
            Decimal valor = Convert.ToDecimal(montoCierre);
            Decimal invertido = valor * -1M;
            objetoCD.AtualizarCaja(Convert.ToInt64(codCaja),invertido);
        }
        public void NAtualizarCaja3(string codCaja, string montoCierre,string otro)
        {
            Decimal valorFin = Convert.ToDecimal(montoCierre);
            Decimal valorIni =  Convert.ToDecimal(otro);
            Decimal dif = valorFin - valorIni;
            objetoCD.AtualizarCaja(Convert.ToInt64(codCaja),dif );
        }

        ////////Detalle Caja

        public DataTable NFiltrarDetalleCaja(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarDetalleCaja(Convert.ToInt64(filtro));
            return tabla;
        }
        public void NInsertarDetalleCaja(string detalle, string montoEfectivo, string montoDebito, string codCaja)
        {

            objetoCD.InsetarDetalleCaja(detalle, Convert.ToDecimal(montoEfectivo), Convert.ToDecimal(montoDebito), Convert.ToInt64(codCaja));
        }

        public void NEditarDetalleCaja(string codDCaja, string detalle, string montoEfectivo, string montoDebito, string codCaja)
        {

            objetoCD.EditarDetalleCaja(Convert.ToInt64(codDCaja), detalle, Convert.ToDecimal(montoEfectivo), Convert.ToDecimal(montoDebito),Convert.ToInt64(codCaja));
        }
        public void NEliminarDetalleCaja(string codDCaja)
        {
            objetoCD.EliminarDetalleCaja(Convert.ToInt64(codDCaja));
        }

    }
}
