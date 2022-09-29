using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace CapaDatos
{
    class CD_Conexion
    {

       private SqlConnection Conexion = new SqlConnection(@"Server=DESKTOP-F6G0EHJ;DataBase=Delivery;integrated security= true");
      // private SqlConnection Conexion = new SqlConnection("Server=.;DataBase=Delivery;integrated security= true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }
    }
}
