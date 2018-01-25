using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Evaluacion_jardin_de_niños
{
    class BoletaDePensamientoMatematicoABC
    {
        public static int Agregar(BoletaDePensamientoMatematico pBoletapm)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into BoletaPensamientoMatematico (Nombre, Grado_y_Grupo ,Esperado,Desarrollo,Requiere_Apoyo,Resultado) values ('{0}','{1}','{2}','{2}','{4}','{5}')",
            pBoletapm.Nombre, pBoletapm.GradoyGrupo, pBoletapm.Esperado, pBoletapm.Desarrollo, pBoletapm.RequiereApoyo, pBoletapm.Resultado), BDConector.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
