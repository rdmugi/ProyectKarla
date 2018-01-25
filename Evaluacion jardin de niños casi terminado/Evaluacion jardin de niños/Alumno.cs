using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluacion_jardin_de_niños
{
    public class Alumno
    {
       public int Id { get; set; }
       public string Curp {get; set;}
       public string Nombre { get; set; } 
       public string ApellidoPaterno { get; set; }
       public string ApellidoMaterno{get; set;}
       public string Sexo{get; set;}
       public string Edad{get; set;}
       public string GradoyGrupo{get; set;}
       public string Fecha_Nac { get; set; }
       public string Telefono { get; set; }
       public string Fecha_Ingre { get; set; }
       public string Num_Lista { get; set; }
       public string Nacionalidad { get; set; }
       public string Nombre_Tutor { get; set; }
       public string Domicilio_Tutor { get; set; }
      

       public Alumno() { }

       public Alumno(int pId, string pCurp, string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pSexo, string pEdad, string pGradoyGrupo, string pFecha_nac, string pTelefono, string pFecha_Ingre, string pNum_Lista,
           string pNacionalidad, string pNombre_Tutor, string pDomicilio_Tutor)

       {
           this.Id = pId;
           this.Curp = pCurp;
           this.Nombre = pNombre;
           this.ApellidoPaterno = pApellidoPaterno;
           this.ApellidoMaterno = pApellidoMaterno;
           this.Sexo = pSexo;
           this.Edad = pEdad;
           this.GradoyGrupo = pGradoyGrupo;
           this.Fecha_Nac = pFecha_nac;
           this.Telefono = pTelefono;
           this.Fecha_Ingre = pFecha_Ingre;
           this.Num_Lista = pNum_Lista;
           this.Nacionalidad = pNacionalidad;
           this.Nombre_Tutor = pNombre_Tutor;
           this.Domicilio_Tutor = pDomicilio_Tutor;
           
       }
    }
}
