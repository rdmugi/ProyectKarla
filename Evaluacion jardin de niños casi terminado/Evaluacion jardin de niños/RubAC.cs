using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Evaluacion_jardin_de_niños
{
    class RubAC
    {
        public static int Agregar(Rubros pRubro, string op)
        {

            int retorno = 0;
            switch (op)
            {
                case "Lenguaje y Comunicación.":

                    MySqlCommand LenguajeYcomunicacion = new MySqlCommand(string.Format("Insert into LenguajeYcomunicacion (Competencias, SubCompetencia) values ('{0}','{1}')", pRubro.competencia, pRubro.subCompetencia), BDConector.ObtenerConexion());
                    retorno = LenguajeYcomunicacion.ExecuteNonQuery();
                    break;
                case "Pensamiento Matemático.":
                    MySqlCommand PensamientoMatematico = new MySqlCommand(string.Format("Insert into PensamientoMatematico (Competencias, SubCompetencia) values ('{0}','{1}')", pRubro.competencia, pRubro.subCompetencia), BDConector.ObtenerConexion());
                    retorno = PensamientoMatematico.ExecuteNonQuery();
                    break;
                case "Exploración y Conocimiento del Mundo.":
                    MySqlCommand Exploracion = new MySqlCommand(string.Format("Insert into Exploracion (Competencias, SubCompetencia) values ('{0}','{1}')", pRubro.competencia, pRubro.subCompetencia), BDConector.ObtenerConexion());
                    retorno = Exploracion.ExecuteNonQuery();
                    break;
                case "Desarrollo Físico y Salud.":
                    MySqlCommand EducacionFisica = new MySqlCommand(string.Format("Insert into EducacionFisica (Competencias, SubCompetencia) values ('{0}','{1}')", pRubro.competencia, pRubro.subCompetencia), BDConector.ObtenerConexion());
                    retorno = EducacionFisica.ExecuteNonQuery();
                    break;
                case "Desarrollo Personal y Social.":
                    MySqlCommand DesarrolloPersonal = new MySqlCommand(string.Format("Insert into DesarrolloPersonal (Competencias, SubCompetencia) values ('{0}','{1}')", pRubro.competencia, pRubro.subCompetencia), BDConector.ObtenerConexion());
                    retorno = DesarrolloPersonal.ExecuteNonQuery();
                    break;
                case "Expresion y Apreciación Artístiscas.":
                    MySqlCommand ExpresionYAprecicacion = new MySqlCommand(string.Format("Insert into ExpresionYAprecicacion (Competencias, SubCompetencia) values ('{0}','{1}')", pRubro.competencia, pRubro.subCompetencia), BDConector.ObtenerConexion());
                    retorno = ExpresionYAprecicacion.ExecuteNonQuery();
                    break;
            }
            return retorno;
        }
    }
}
