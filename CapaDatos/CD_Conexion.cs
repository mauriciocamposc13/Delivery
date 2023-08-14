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
        //Aca se configura la cadena de conexion desde la instancia de base de datos local en una Base de datos llamada Delivery con las credeciales de Windows
       private SqlConnection Conexion = new SqlConnection("Server=.;DataBase=Delivery;integrated security= true");
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
