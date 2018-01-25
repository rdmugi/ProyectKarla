using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Evaluacion_jardin_de_niños
{
    public class BDConector
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; port=3305; database=JardinBonifacioDiaz; Uid=root; pwd=root;");
            conectar.Open();
            return conectar;
        }
    }
}
