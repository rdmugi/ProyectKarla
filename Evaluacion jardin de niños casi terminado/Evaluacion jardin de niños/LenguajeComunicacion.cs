using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluacion_jardin_de_niños
{
    class LenguajeComunicacion
    {
        public int Id { get; set; }
        public string UtilizaConocimiento { get; set; }
        public string IdentificaTexto { get; set; }
        public string EscribeNombre { get; set; }
        public string Promedio { get; set; }
        public string Nivel { get; set; }

        public LenguajeComunicacion() { }

        public LenguajeComunicacion(int pId, string pUtilizaConocimiento, string pIdentificaTexto, string pEscribeNombre,string pPromedio, string pNivel)
        {
            this.Id = pId;
            this.UtilizaConocimiento = pUtilizaConocimiento;
            this.IdentificaTexto = pIdentificaTexto;
            this.EscribeNombre = pEscribeNombre;
            this.Promedio = pPromedio;
            this.Nivel = pNivel;
        }
    }
}
