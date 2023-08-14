using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Producto
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarProducto()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable FiltrarProducto(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarProducto(string codProd, string codBarra, string nomProd, string marca,Decimal pCosto,Decimal pVenta,string descProd, decimal stockMin, decimal stockExis,DateTime  fchVto,string categoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codProd", codProd);
            comando.Parameters.AddWithValue("@codBarra", codBarra);
            comando.Parameters.AddWithValue("@nomProd", nomProd);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@pCosto", pCosto);
            comando.Parameters.AddWithValue("@pVenta", pVenta);
            comando.Parameters.AddWithValue("@descProd", descProd);
            comando.Parameters.AddWithValue("@stockMin", stockMin);
            comando.Parameters.AddWithValue("@stockExis", stockExis);
            comando.Parameters.AddWithValue("@fchVto", fchVto);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarProducto(Int32 codProducto, string codProd, string codBarra, string nomProd, string marca, Decimal pCosto, Decimal pVenta, string descProd, decimal stockMin, decimal stockExis, DateTime fchVto,string categoria)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codProducto", codProducto);
            comando.Parameters.AddWithValue("@codProd", codProd);
            comando.Parameters.AddWithValue("@codBarra", codBarra);
            comando.Parameters.AddWithValue("@nomProd", nomProd);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@pCosto", pCosto);
            comando.Parameters.AddWithValue("@pVenta", pVenta);
            comando.Parameters.AddWithValue("@descProd", descProd);
            comando.Parameters.AddWithValue("@stockMin", stockMin);
            comando.Parameters.AddWithValue("@stockExis", stockExis);
            comando.Parameters.AddWithValue("@fchVto", fchVto);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarProducto(Int32 codProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codProducto", codProducto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable MostrarProductoFaltante()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductoFaltante";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable FiltrarProductoComanda(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarProductoComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void ActualizarProducto(Int32 codProducto, Decimal cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codProducto", codProducto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable FiltrarProductoSumador(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarProductoSumador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
