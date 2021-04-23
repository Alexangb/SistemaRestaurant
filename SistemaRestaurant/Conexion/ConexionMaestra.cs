using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaRestaurant.Conexion
{
    class ConexionMaestra
    {
        public static string conexion =Convert.ToString(Librerias.Desencryptacion.checkServer());
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State==System.Data.ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void cerrar()
        {
            if (conectar.State==System.Data.ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
