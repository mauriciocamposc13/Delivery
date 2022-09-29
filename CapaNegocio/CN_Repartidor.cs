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
   public class CN_Repartidor
    {


        private CD_Repartidor objetoCD = new CD_Repartidor();

        public DataTable MostrarNRepartidor()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarDRepartidor();
            return tabla;
        }

        public void InsertarNRepartidor(string nomRepartidor, string telRepartidor, string domRepartidor)
        {

            objetoCD.InsertarDRepartidor(nomRepartidor, telRepartidor, domRepartidor);
        }
        public void EditarNRepartidor(string codRepartidor, string nomRepartidor, string telRepartidor, string domRepartidor)
        {
            objetoCD.EditarDRepartidor(Convert.ToInt32(codRepartidor), nomRepartidor, telRepartidor, domRepartidor);
        }
        public void EliminarNRepartidor(string codRepartidor)
        {
            objetoCD.EliminarDRepartidor(Convert.ToInt32(codRepartidor));
        }
        public DataTable FiltrarNRepartidor(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.FiltrarDRepartidor(filtro);
            return tabla;
        }

    }
}
