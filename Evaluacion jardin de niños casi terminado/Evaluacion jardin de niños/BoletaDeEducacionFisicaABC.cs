using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Evaluacion_jardin_de_niños
{
    class BoletaDeEducacionFisicaABC
    {
        public static int Agregar(BoletaDeEducacionFisica pBoletaedu)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Boletaeducacionfisica (Nombre, Grupo_y_Grado, Esperado, Desarrollo , Requiere_Apoyo, Resultado) values ('{0}','{1}','{2}', '{3}', '{4}','{5}')",
            pBoletaedu.Nombre, pBoletaedu.GradoyGrupo, pBoletaedu.Esperado, pBoletaedu.Desarrollo, pBoletaedu.RequiereApoyo, pBoletaedu.Resultado), BDConector.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        } 
    }
}
