using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Evaluacion_jardin_de_niños
{
    class PensamientoMatematicoABC
    {
        public static int Agregar(PensamientoMatematico pPensamientoMatematico)
        {

            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into PensamientoMatematico(Identifica, Utiliza, UsaYnombra, UtilizaObj, UsaProcedimientos, Comprende, ExplicaQue,Promedio,Resultado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
            pPensamientoMatematico.Identifica, pPensamientoMatematico.Usaestrategia, pPensamientoMatematico.UsayNombra, pPensamientoMatematico.Usaobjetos, pPensamientoMatematico.Usaprocesos, pPensamientoMatematico.Comprendeproblemas, pPensamientoMatematico.Explicar,
            pPensamientoMatematico.Promedio, pPensamientoMatematico.Nivel), BDConector.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
