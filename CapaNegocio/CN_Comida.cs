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
    public class CN_Comida
    {
        private CD_Comida objetoCD = new CD_Comida();
        public DataTable NMostrarComida()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarComida();
            return tabla;
        }
        public DataTable NFiltrarComida(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarComida(filtro);
            return tabla;
        }
        public void NInsertarComida(string codComida, string codBarraComida, string nomComida, string pCosto, string pVenta, string descComida)
        {
            objetoCD.InsertarComida(codComida, codBarraComida, nomComida, Convert.ToDecimal(pCosto), Convert.ToDecimal(pVenta), descComida);
        }
        public void NEditarComida(string numComida,string codComida, string codBarraComida, string nomComida, string pCosto, string pVenta, string descComida)
        {
            objetoCD.EditarComida(Convert.ToInt32(numComida), codComida, codBarraComida, nomComida, Convert.ToDecimal(pCosto), Convert.ToDecimal(pVenta), descComida);
        }
        public void NEliminarComida(string numComida)
        {
            objetoCD.EliminarComida(Convert.ToInt32(numComida));
        }

        public DataTable NFiltrarComidaComanda(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarComidaComanda(filtro);
            return tabla;
        }
    }
}
