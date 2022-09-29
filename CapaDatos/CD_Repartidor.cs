using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace CapaDatos
{
   public class CD_Repartidor
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarDRepartidor()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarRepartidor";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarDRepartidor(string nomRepartidor, string telRepartidor, string domRepartidor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarRepartidor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nomRepartidor", nomRepartidor);
            comando.Parameters.AddWithValue("@telRepartidor", telRepartidor);
            comando.Parameters.AddWithValue("@domRepartidor", domRepartidor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarDRepartidor(int codRepartidor, string nomRepartidor, string telRepartidor, string domRepartidor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarRepartidor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codRepartidor", codRepartidor);
            comando.Parameters.AddWithValue("@nomRepartidor", nomRepartidor);
            comando.Parameters.AddWithValue("@telRepartidor", telRepartidor);
            comando.Parameters.AddWithValue("@domRepartidor", domRepartidor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarDRepartidor(int codRepartidor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarRepartidor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codRepartidor", codRepartidor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable FiltrarDRepartidor(string filtro)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltarRepartidor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


    }
}
