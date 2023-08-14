using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Comanda
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarComanda(Int64 filtro)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsetarComanda(DateTime fechaComanda,string nomCliente, string nomRepartiodor, string observacion, Decimal montoTotal, Decimal montoEfectivo, Decimal montoDebito, Int64 codCaja)
        {

            //@fechaComanda,@nomCliente,@nomRepartiodor,@observacion,@montoTotal,@montoEfectivo,@montoDebito,@codCaja
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaComanda", fechaComanda);
            comando.Parameters.AddWithValue("@nomCliente", nomCliente);
            comando.Parameters.AddWithValue("@nomRepartiodor", nomRepartiodor);
            comando.Parameters.AddWithValue("@observacion", observacion);
            comando.Parameters.AddWithValue("@montoTotal", montoTotal);
            comando.Parameters.AddWithValue("@montoEfectivo", montoEfectivo);
            comando.Parameters.AddWithValue("@montoDebito", montoDebito);
            comando.Parameters.AddWithValue("@codCaja", codCaja);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarComanda(Int64 codComanda, DateTime fechaComanda, string nomCliente, string nomRepartiodor, string observacion, Decimal montoTotal, Decimal montoEfectivo, Decimal montoDebito, Int64 codCaja)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codComanda", codComanda);
            comando.Parameters.AddWithValue("@fechaComanda", fechaComanda);
            comando.Parameters.AddWithValue("@nomCliente", nomCliente);
            comando.Parameters.AddWithValue("@nomRepartiodor", nomRepartiodor);
            comando.Parameters.AddWithValue("@observacion", observacion);
            comando.Parameters.AddWithValue("@montoTotal", montoTotal);
            comando.Parameters.AddWithValue("@montoEfectivo", montoEfectivo);
            comando.Parameters.AddWithValue("@montoDebito", montoDebito);
            comando.Parameters.AddWithValue("@codCaja", codCaja);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarComanda(Int64 codComanda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codComanda", codComanda);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void ActualizarMontoComanda(Int64 codComanda,Decimal cantidad, Decimal precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarMontoComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codComanda", codComanda);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable MostrarTotalComanda(Int64 filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTotalComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //DETALLE COMANDA
        public DataTable MostrarDetalleComanda(Int64 filtro)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDetalleComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void InsertarDetalleComanda(string codigo,string nombre, string descrip,Decimal cantidad,Decimal precioUnidad,Int64 codComanda, string tipo)
        {
            comando.Connection = conexion.AbrirConexion();
                               
            comando.CommandText = "InsetarDetalleComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", descrip);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precioUnidad", precioUnidad);
            comando.Parameters.AddWithValue("@codComanda", codComanda);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminarDetalleComanda(Int64 codDComanda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDetalleComanda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codDComanda", codDComanda);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable ControlDiarioProducto(DateTime filtro )
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ControlDiarioProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ControlDiarioComida(DateTime filtro)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ControlDiarioComida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro", filtro);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ControlDiarioProductoFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ControlDiarioProductoFiltro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro1", filtro1);
            comando.Parameters.AddWithValue("@filtro2", filtro2);
            comando.Parameters.AddWithValue("@filtro3", filtro3);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ControlDiarioComidaFiltro(DateTime filtro1, DateTime filtro2, String filtro3)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ControlDiarioComidaFiltro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro1", filtro1);
            comando.Parameters.AddWithValue("@filtro2", filtro2);
            comando.Parameters.AddWithValue("@filtro3", filtro3);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        //Sumador
        public DataTable ControlDiarioProductoFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ControlDiarioProductoFiltroSumador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtro1", filtro1);
            comando.Parameters.AddWithValue("@filtro2", filtro2);
            comando.Parameters.AddWithValue("@filtro3", filtro3);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ControlDiarioComidaFiltroSumador(DateTime filtro1, DateTime filtro2, String filtro3)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ControlDiarioComidaFiltroSumador";
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
