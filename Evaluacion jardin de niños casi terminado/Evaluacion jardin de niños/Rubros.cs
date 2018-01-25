using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluacion_jardin_de_niños
{
    class Rubros
    {
        public int id { get; set; }
        public string competencia { get; set; }
        public string subCompetencia { get; set; }

        public Rubros()
        {

        }
        public Rubros(int id, string competencia, string subCompetencia)
        {
            this.id = id;
            this.competencia = competencia;
            this.subCompetencia = subCompetencia;
        }
    }
}
