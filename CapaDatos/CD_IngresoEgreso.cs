using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_IngresoEgreso
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        //INGRESOS
        public DataTable MostrarIngreso()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarIngreso";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    
        public void InsetarIngreso(DateTime fchIngreso, Decimal montoIngreso, string descIngreso, string categoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarIngreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fchIngreso", fchIngreso);
            comando.Parameters.AddWithValue("@montoIngreso", montoIngreso);
            comando.Parameters.AddWithValue("@descIngreso", descIngreso);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarIngreso(Int64 codIngreso, DateTime fchIngreso, Decimal montoIngreso, string descIngreso, string categoria)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarIngreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codIngreso", codIngreso);
            comando.Parameters.AddWithValue("@fchIngreso", fchIngreso);
            comando.Parameters.AddWithValue("@montoIngreso", montoIngreso);
            comando.Parameters.AddWithValue("@descIngreso", descIngreso);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarIngreso(Int64 codIngreso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarIngreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codIngreso", codIngreso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //EGRESOS
        public DataTable MostrarEgreso()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEgreso";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsetarEgreso(DateTime fchEgreso, Decimal montoEgreso, string descEgreso, string categoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarEgreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fchEgreso", fchEgreso);
            comando.Parameters.AddWithValue("@montoEgreso", montoEgreso);
            comando.Parameters.AddWithValue("@descEgreso", descEgreso);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarEgreso(Int64 codEgreso, DateTime fchEgreso, Decimal montoEgreso, string descEgreso, string categoria)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEgreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codEgreso", codEgreso);
            comando.Parameters.AddWithValue("@fchEgreso", fchEgreso);
            comando.Parameters.AddWithValue("@montoEgreso", montoEgreso);
            comando.Parameters.AddWithValue("@descEgreso", descEgreso);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarEgreso(Int64 codEgreso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEgreso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codEgreso", codEgreso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        //Filtros
        public DataTable MostrarIngresoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarIngresoFiltro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro1", filtro1);
            comando.Parameters.AddWithValue("@filtro2", filtro2);
            comando.Parameters.AddWithValue("@filtro3", filtro3);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarIngresoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarIngresoFiltroSumador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro1", filtro1);
            comando.Parameters.AddWithValue("@filtro2", filtro2);
            comando.Parameters.AddWithValue("@filtro3", filtro3);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarEgresoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEgresoFiltro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro1", filtro1);
            comando.Parameters.AddWithValue("@filtro2", filtro2);
            comando.Parameters.AddWithValue("@filtro3", filtro3);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarEgresoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEgresoFiltroSumador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro1", filtro1);
            comando.Parameters.AddWithValue("@filtro2", filtro2);
            comando.Parameters.AddWithValue("@filtro3", filtro3);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


    }
}
