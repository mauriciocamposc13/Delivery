using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarDCliente()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarDCliente(string nomCliente, string telCliente, string domCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nomCliente", nomCliente);
            comando.Parameters.AddWithValue("@telCliente", telCliente);
            comando.Parameters.AddWithValue("@domCliente", domCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarDCliente(int codCliente, string nomCliente, string telCliente, string domCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codCliente", codCliente);
            comando.Parameters.AddWithValue("@nomCliente", nomCliente);
            comando.Parameters.AddWithValue("@telCliente", telCliente);
            comando.Parameters.AddWithValue("@domCliente", domCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarDCliente(int codCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codCliente", codCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public DataTable FiltrarDCliente(string filtro)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
