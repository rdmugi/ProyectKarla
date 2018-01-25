using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Evaluacion_jardin_de_niños
{
    class LenguajeComunicacionABC
    {
        public static int Agregar(LenguajeComunicacion pLenguajeComunicacion)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into LenguajeYcomunicacion(UtilizaElConocimiento,LenguajeYcomunicacion,EscribeSunombre,Promedio,Resultado) values ('{0}','{1}','{2}','{3}','{4}')", pLenguajeComunicacion.UtilizaConocimiento,
                pLenguajeComunicacion.IdentificaTexto, pLenguajeComunicacion.EscribeNombre,pLenguajeComunicacion.Promedio, pLenguajeComunicacion.Nivel), BDConector.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
