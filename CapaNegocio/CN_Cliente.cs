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
   public class CN_Cliente
    {

        private CD_Cliente objetoCD = new CD_Cliente();

        public DataTable MostrarNCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarDCliente();
            return tabla;
        }

        public void InsertarNCliente( string nomCliente, string telCliente, string domCliente)
        {

            objetoCD.InsertarDCliente(nomCliente, telCliente, domCliente);
        }
        public void EditarNCliente(string codCliente, string nomCliente, string telCliente, string domCliente)
        {
            objetoCD.EditarDCliente(Convert.ToInt32(codCliente), nomCliente, telCliente, domCliente);
        }
        public void EliminarNCliente(string codCliente)
        {
            objetoCD.EliminarDCliente(Convert.ToInt32(codCliente));
        }
        public DataTable FiltrarNCliente(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarDCliente(filtro);
            return tabla;
        }
    }
}
