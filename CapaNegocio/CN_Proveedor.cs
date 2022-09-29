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
   public class CN_Proveedor
    {
        private CD_Proveedor objetoCD = new CD_Proveedor();
        public DataTable MostrarNProveedores()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarDProveedor();
            return tabla;
        }
        public void InsertarNProveedor(string nomProv, string nomEmpl, string telProv, string domProv)
        {

            objetoCD.InsertarDProveedor( nomProv, nomEmpl, telProv, domProv);
        }
        public void EditarNProveedor(string codProveedor, string nomProv, string nomEmpl, string telProv, string domProv)
        {
            objetoCD.EditarDProveedor(Convert.ToInt32(codProveedor), nomProv, nomEmpl, telProv, domProv);
        }
        public void EliminarNProveedor(string codProveedor)
        {
            objetoCD.EliminarDProveedor(Convert.ToInt32(codProveedor));
        }


    }
}
