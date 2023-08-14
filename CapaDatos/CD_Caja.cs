using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Caja
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarCaja()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCaja";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable FiltrarCaja(DateTime filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarCaja(DateTime fecha, string nomEmpleado,Decimal montoInicio,Decimal montoCierre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@nomEmpleado", nomEmpleado);
            comando.Parameters.AddWithValue("@montoInicio", montoInicio);
            comando.Parameters.AddWithValue("@montoCierre", montoCierre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarCaja(Int64 codCaja,DateTime fecha, string nomEmpleado, Decimal montoInicio, Decimal montoCierre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codCaja", codCaja);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@nomEmpleado", nomEmpleado);
            comando.Parameters.AddWithValue("@montoInicio", montoInicio);
            comando.Parameters.AddWithValue("@montoCierre", montoCierre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminarCaja(Int64 codCaja)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codCaja", codCaja);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //DETALLE CAJA
        public DataTable FiltrarDetalleCaja(Int64 filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "FiltrarDetalleCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsetarDetalleCaja(string detalle, Decimal montoEfectivo, Decimal montoDebito,Int64 codCaja)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarDetalleCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@detalle", detalle);
            comando.Parameters.AddWithValue("@montoEfectivo", montoEfectivo);
            comando.Parameters.AddWithValue("@montoDebito", montoDebito);
            comando.Parameters.AddWithValue("@codCaja", codCaja);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarDetalleCaja(Int64 codDCaja,string detalle, Decimal montoEfectivo, Decimal montoDebito, Int64 codCaja)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDetalleCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codDCaja", codDCaja);
            comando.Parameters.AddWithValue("@detalle", detalle);
            comando.Parameters.AddWithValue("@montoEfectivo", montoEfectivo);
            comando.Parameters.AddWithValue("@montoDebito", montoDebito);
            comando.Parameters.AddWithValue("@codCaja", codCaja);
            comando.ExecuteNonQuery();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarDetalleCaja(Int64 codDCaja)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDetalleCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codDCaja", codDCaja);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void AtualizarCaja(Int64 codCaja, Decimal montoCierre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AtualizarCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codCaja", codCaja);
            comando.Parameters.AddWithValue("@montoCierre", montoCierre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
