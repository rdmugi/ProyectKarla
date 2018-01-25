using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Evaluacion_jardin_de_niños
{
    class EducacionFisicaABC
    {
        public static int Agregar(EducacionFisica pEducacionFisica)
        {

            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into EducacionFisica(ParteCuerpo, Cangrejos, Reptar, Salticar, Saltar1pie, Saltar2pies, LanzarYcachar, Botar,Equilibrio,Adelante,Atras,Derecha,Izquierda,Lejos,Cerca,ArribaDe,AbajoDe,Ritmo,Coordina,Promedio,Resultado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')",
            pEducacionFisica.ParteCuerpo, pEducacionFisica.Cangrejo, pEducacionFisica.Reptar, pEducacionFisica.Salticar, pEducacionFisica.Saltarunpie, pEducacionFisica.Saltardospies, pEducacionFisica.LanzaryCachar, pEducacionFisica.Botar, pEducacionFisica.Equilibrio, pEducacionFisica.Adelante, pEducacionFisica.Atras, pEducacionFisica.Derecha, pEducacionFisica.Izquierda,
            pEducacionFisica.Lejos, pEducacionFisica.Cerca, pEducacionFisica.Arribade, pEducacionFisica.Abajode, pEducacionFisica.Ritmo, pEducacionFisica.Coordinacion, pEducacionFisica.Promedio, pEducacionFisica.Nivel), BDConector.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
