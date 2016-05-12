using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CalculadoraGrafica
{
    class DataBases
    {


        public MySqlConnection ObtenerConexion() {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=calculadora;uid=root;pwd=;");
            conectar.Open();
            return conectar;
        }


    }
}
