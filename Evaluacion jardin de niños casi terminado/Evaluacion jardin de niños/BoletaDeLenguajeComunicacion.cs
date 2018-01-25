using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluacion_jardin_de_niños
{
    class BoletaDeLenguajeComunicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string GradoyGrupo { get; set; }
        public string Esperado { get; set; }
        public string Desarrollo { get; set; }
        public string RequiereApoyo { get; set; }
        public string Resultado { get; set; }

        public BoletaDeLenguajeComunicacion() { }

        public BoletaDeLenguajeComunicacion(int pId, string pNombre, string pGradoyGrupo, string pEsperado, string pDesarrollo, string pRequiereApoyo, string pResultado)

       {
           this.Id = pId;
           this.Nombre = pNombre;
           this.GradoyGrupo = pGradoyGrupo;
           this.Esperado = pEsperado;
           this.Desarrollo = pDesarrollo;
           this.RequiereApoyo = pRequiereApoyo;
           this.Resultado = pResultado;
            
       }
    }
}
