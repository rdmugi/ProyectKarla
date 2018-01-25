using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Evaluacion_jardin_de_niños
{
    class BoletaDeLenguajeComunicacionABC
    {
        public static int Agregar(BoletaDeLenguajeComunicacion pBoletacom)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into BoletaLenguajeYcomunicacion (Nombre, Grado_y_Grupo ,Esperado,Desarrollo,Requiere_Apoyo,Resultado) values ('{0}','{1}','{2}','{2}','{4}','{5}')",
            pBoletacom.Nombre, pBoletacom.GradoyGrupo, pBoletacom.Esperado, pBoletacom.Desarrollo, pBoletacom.RequiereApoyo, pBoletacom.Resultado), BDConector.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}