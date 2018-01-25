using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluacion_jardin_de_niños
{
    class PensamientoMatematico
    {
        public int Id { get; set; }
        public string Identifica { get; set; }
        public string Usaestrategia { get; set; }
        public string UsayNombra { get; set; }
        public string Usaobjetos { get; set; }
        public string Usaprocesos { get; set; }
        public string Comprendeproblemas { get; set; }
        public string Explicar { get; set; }
        public string Promedio { get; set; }
        public string Nivel { get; set; }

        public PensamientoMatematico() { }

        public PensamientoMatematico(int pId, string pIdentifica, string pUsaestrategia, string pUsayNombra, string pUsaobjetos, string pUsaprocesos, string pComprendeproblemas, string pExplicar, string pPromedio, string pNivel)
        {
            this.Id = pId;
            this.Identifica = pIdentifica;
            this.Usaestrategia = pUsaestrategia;
            this.UsayNombra = pUsayNombra;
            this.Usaobjetos = pUsaobjetos;
            this.Usaprocesos = pUsaprocesos;
            this.Comprendeproblemas = pComprendeproblemas;
            this.Explicar = pExplicar;
            this.Promedio = pPromedio;
            this.Nivel = pNivel;
        }
    }
}
