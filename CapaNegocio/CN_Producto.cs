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
    public class CN_Producto
    {
        private CD_Producto objetoCD = new CD_Producto();
        public DataTable NMostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProducto();
            return tabla;
        }
        public DataTable NFiltrarProducto(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarProducto(filtro);
            return tabla;
        }
        public void NInsertarProducto(string codProd, string codBarra, string nomProd, string marca, string pCosto, string pVenta, string descProd, string stockMin, string stockExis, DateTime fchVto,string categoria)
        {
            objetoCD.InsertarProducto(codProd, codBarra, nomProd, marca,Convert.ToDecimal(pCosto), Convert.ToDecimal(pVenta), descProd, Convert.ToDecimal(stockMin), Convert.ToDecimal(stockExis),fchVto, categoria);
        }
        public void NEditarProducto(string codProducto, string codProd, string codBarra, string nomProd, string marca, string pCosto, string pVenta, string descProd, string stockMin, string stockExis, DateTime fchVto,string categoria)
        {
            objetoCD.EditarProducto (Convert.ToInt32(codProducto), codProd, codBarra, nomProd, marca, Convert.ToDecimal(pCosto), Convert.ToDecimal(pVenta), descProd, Convert.ToDecimal(stockMin), Convert.ToDecimal(stockExis), fchVto,categoria);
        }
        public void NEliminarProducto(string codProducto)
        {
            objetoCD.EliminarProducto(Convert.ToInt32(codProducto));
        }
        public DataTable NMostrarProductoFaltante()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProductoFaltante();
            return tabla;
        }

        public DataTable NFiltrarProductoComanda(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarProductoComanda(filtro);
            return tabla;
        }

        public void NActualizarProducto(string codProducto,string cantidad)
        {
            objetoCD.ActualizarProducto(Convert.ToInt32(codProducto),Convert.ToDecimal(cantidad));
        }
        public string NFiltrarProductoSumador(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarProductoSumador(filtro);
            string tot1 = tabla.Rows[0]["Totalcosto"].ToString();
            return tot1;
        }
        public string NFiltrarProductoSumador2(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarProductoSumador(filtro);
            string tot2 = tabla.Rows[0]["Totalventa"].ToString();
            return tot2;
        }
    }
}
