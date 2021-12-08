using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BackEnd
{
    public class Conexion
    {
        public static MySqlConnection abrirConexion()
        {

            MySqlConnection conectar = new MySqlConnection
                ("server=127.0.0.1;uid=root;pwd=reptiles12;database=nwind");

            conectar.Open();

            return conectar;
        }

        public static MySqlConnection CerrarConexion()
        {

            MySqlConnection conectar = new MySqlConnection
                ("server=127.0.0.1;uid=root;pwd=reptiles12;database=nwind");

            conectar.Close();

            return conectar;
        }
    }
}
