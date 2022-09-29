using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace CapaDatos
{
  public class CD_Proveedor
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarDProveedor()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarDProveedor(string nomProv, string nomEmpl, string telProv, string domProv)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nomProv", nomProv);
            comando.Parameters.AddWithValue("@nomEmpl", nomEmpl);
            comando.Parameters.AddWithValue("@telProv", telProv);
            comando.Parameters.AddWithValue("@domProv", domProv);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarDProveedor(Int32 codProveedor, string nomProv, string nomEmpl, string telProv, string domProv)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codProveedor", codProveedor);
            comando.Parameters.AddWithValue("@nomProv", nomProv);
            comando.Parameters.AddWithValue("@nomEmpl", nomEmpl);
            comando.Parameters.AddWithValue("@telProv", telProv);
            comando.Parameters.AddWithValue("@domProv", domProv);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarDProveedor(Int32 codProveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codProveedor", codProveedor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
