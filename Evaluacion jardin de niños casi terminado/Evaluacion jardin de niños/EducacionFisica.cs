using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluacion_jardin_de_niños
{
    class EducacionFisica
    {
        public int Id { get; set; }
        public string ParteCuerpo { get; set; }
        public string Cangrejo { get; set; }
        public string Reptar { get; set; }
        public string Salticar { get; set; }
        public string Saltarunpie { get; set; }
        public string Saltardospies { get; set; }
        public string LanzaryCachar { get; set; }
        public string Botar { get; set; }
        public string Equilibrio { get; set; }
        public string Adelante { get; set; }
        public string Atras { get; set; }
        public string Derecha { get; set; }
        public string Izquierda { get; set; }
        public string Lejos { get; set; }
        public string Cerca { get; set; }
        public string Arribade { get; set; }
        public string Abajode { get; set; }
        public string Ritmo { get; set; }
        public string Coordinacion { get; set; }
        public string Promedio { get; set; }
        public string Nivel { get; set; }
        public EducacionFisica() { }

       public EducacionFisica(int pId, string pParteCuerpo, string pCangrejo, string pReptar, string pSalticar, string pSaltarunpie, string pSaltardospies, string pLanzaryCachar, 
           string pBotar, string pEquilibrio, string pAdelante, string pAtras, string pDerecha, string pIzquierda, string pLejos, string pCerca, string pArribade, string pAbajode,
           string pRitmo, string pCoordinacion, string pPromedio, string pNivel)

       {
           this.Id = pId;
           this.ParteCuerpo = pParteCuerpo;
           this.Cangrejo = pCangrejo;
           this.Reptar = pReptar;
           this.Salticar = pSalticar;
           this.Saltarunpie = pSaltarunpie;
           this.Saltardospies = pSaltardospies;
           this.LanzaryCachar = pLanzaryCachar;
           this.Botar = pBotar;
           this.Equilibrio = pEquilibrio;
           this.Adelante = pAdelante;
           this.Atras = pAtras;
           this.Derecha = pDerecha;
           this.Izquierda = pIzquierda;
           this.Lejos = pLejos;
           this.Cerca = pCerca;
           this.Arribade = pArribade;
           this.Abajode = pAbajode;
           this.Ritmo = pRitmo;
           this.Coordinacion = pCoordinacion;
           this.Promedio = pPromedio;
           this.Nivel = pNivel;
       }
    }
}
