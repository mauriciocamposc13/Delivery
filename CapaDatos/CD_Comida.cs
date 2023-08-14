using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Comida
    {                
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarComida()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarComida";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable FiltrarComida(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarComida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarComida(string codComida, string codBarraComida, string nomComida, Decimal pCosto,Decimal pVenta, string descComida)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarComida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codComida", codComida);
            comando.Parameters.AddWithValue("@codBarraComida", codBarraComida);
            comando.Parameters.AddWithValue("@nomComida", nomComida);
            comando.Parameters.AddWithValue("@pCosto", pCosto);
            comando.Parameters.AddWithValue("@pVenta", pVenta);
            comando.Parameters.AddWithValue("@descComida", descComida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarComida(Int32 numComida, string codComida, string codBarraComida, string nomComida, Decimal pCosto, Decimal pVenta, string descComida)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarComida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@numComida", numComida);
            comando.Parameters.AddWithValue("@codComida", codComida);
            comando.Parameters.AddWithValue("@codBarraComida", codBarraComida);
            comando.Parameters.AddWithValue("@nomComida", nomComida);
            comando.Parameters.AddWithValue("@pCosto", pCosto);
            comando.Parameters.AddWithValue("@pVenta", pVenta);
            comando.Parameters.AddWithValue("@descComida", descComida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarComida(Int32 numComida)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarComida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@numComida", numComida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public DataTable FiltrarComidaComanda(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarComidaComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
