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
   public class CN_IngresoEgreso
    {
        //INGRESO        
        private CD_IngresoEgreso objetoCD = new CD_IngresoEgreso();
        public DataTable NMostrarIngreso()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarIngreso();
            return tabla;
        }      
        public void NInsetarIngreso(DateTime fchIngreso, string montoIngreso, string descIngreso,string categoria)
        {
            objetoCD.InsetarIngreso(fchIngreso,Convert.ToDecimal(montoIngreso), descIngreso,categoria);
        }
        public void NEditarIngreso(string codIngreso,DateTime fchIngreso, string montoIngreso, string descIngreso,string categoria)
        {
            objetoCD.EditarIngreso(Convert.ToInt64(codIngreso),fchIngreso, Convert.ToDecimal(montoIngreso), descIngreso,categoria);
        }
        public void NEliminarIngreso(string codIngreso)
        {
            objetoCD.EliminarIngreso(Convert.ToInt64(codIngreso));
        }
        //EGRESO
        public DataTable NMostrarEgreso()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEgreso();
            return tabla;
        }

        public void NInsetarEgreso(DateTime fchEgreso, string montoEgreso, string descEgreso,string categoria)
        {
            objetoCD.InsetarEgreso(fchEgreso, Convert.ToDecimal(montoEgreso), descEgreso,categoria);
        }
        public void NEditarEgreso(string codEgreso, DateTime fchEgreso, string montoEgreso, string descEgreso,string categoria)
        {
            objetoCD.EditarEgreso(Convert.ToInt64(codEgreso), fchEgreso, Convert.ToDecimal(montoEgreso), descEgreso,categoria);
        }
        public void NEliminarEgreso(string codEgreso)
        {
            objetoCD.EliminarEgreso(Convert.ToInt64(codEgreso));
        }
        //Filtros
        public DataTable MostrarIngresoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarIngresoFiltro(filtro1, filtro2, filtro3);
            return tabla;
        }
        public string MostrarIngresoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarIngresoFiltroSumador(filtro1, filtro2, filtro3);
            string tot2 = tabla.Rows[0]["Total"].ToString();
            return tot2;
        }
        public DataTable MostrarEgresoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEgresoFiltro(filtro1, filtro2, filtro3);
            return tabla;
        }
        public string MostrarEgresoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEgresoFiltroSumador(filtro1, filtro2, filtro3);
            string tot1 = tabla.Rows[0]["Total"].ToString();
            return tot1;
        }
    }
}
