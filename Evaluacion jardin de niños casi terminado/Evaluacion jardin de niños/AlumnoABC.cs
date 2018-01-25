using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Evaluacion_jardin_de_niños
{
    class AlumnoABC
    {
        public static int Agregar(Alumno pAlumno)
        {

            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Alumno (Curp, Nombre, Apellido_Paterno, Apellido_Materno, Genero, Edad , Grupo_y_Grado, Fecha_Nacimiento, Telefono, Fecha_Inscripcion, Numero_Lista, Nacionalidad, Nombre_Tutor, Domicilio_Tutor) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
            pAlumno.Curp, pAlumno.Nombre, pAlumno.ApellidoPaterno,pAlumno.ApellidoMaterno, pAlumno.Sexo, pAlumno.Edad, pAlumno.GradoyGrupo, pAlumno.Fecha_Nac,pAlumno.Telefono,pAlumno.Fecha_Ingre, pAlumno.Num_Lista, pAlumno.Nacionalidad, pAlumno.Nombre_Tutor, pAlumno.Domicilio_Tutor), BDConector.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Alumno> Buscar(string pNombre, string pApellido)
        {
            List<Alumno> _lista = new List<Alumno>();

            MySqlCommand _comando = new MySqlCommand(string.Format("SELECT IdAlumno, Curp, Nombre, Apellido_Paterno, Apellido_Materno, Genero, Edad, Grupo_Grado, Fecha_nacimiento, Tel_trabajo, Fecha_inscripcion, Numero, Nacionalidad, Nombre_tutor, Domicilio_tutor FROM Alumno where Nombre = '{0}' or Apellido_Paterno = '{1}'", pNombre, pApellido), BDConector.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Alumno pAlumno = new Alumno();
                pAlumno.Id = _reader.GetInt32(0);
                pAlumno.Curp = _reader.GetString(1);
                pAlumno.Nombre = _reader.GetString(2);
                pAlumno.ApellidoPaterno = _reader.GetString(3);
                pAlumno.ApellidoMaterno = _reader.GetString(4);
                pAlumno.Sexo = _reader.GetString(5);
                pAlumno.Edad = _reader.GetString(6);
                pAlumno.GradoyGrupo = _reader.GetString(7);
                pAlumno.Fecha_Nac = _reader.GetString(8);
                pAlumno.Telefono = _reader.GetString(9);
                pAlumno.Fecha_Ingre = _reader.GetString(10);
                pAlumno.Num_Lista = _reader.GetString(11);
                pAlumno.Nacionalidad = _reader.GetString(12);
                pAlumno.Nombre_Tutor = _reader.GetString(13);
                pAlumno.Domicilio_Tutor = _reader.GetString(14);
                _lista.Add(pAlumno);

            }
            return _lista;
        }
        public static List<Alumno> Buscargrupo(string pGradoyGrupo)
        {
            List<Alumno> _lista = new List<Alumno>();

            MySqlCommand _comando = new MySqlCommand(string.Format("SELECT IdAlumno, Curp, Nombre, Apellido_Paterno, Apellido_Materno, Genero, Edad, Grupo_y_Grado, Fecha_Nacimiento, Telefono FROM Alumno where Grupo_y_Grado = '{0}'", pGradoyGrupo), BDConector.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Alumno pAlumno = new Alumno();
                pAlumno.Id = _reader.GetInt32(0);
                pAlumno.Curp = _reader.GetString(1);
                pAlumno.Nombre = _reader.GetString(2);
                pAlumno.ApellidoPaterno = _reader.GetString(3);
                pAlumno.ApellidoMaterno = _reader.GetString(4);
                pAlumno.Sexo = _reader.GetString(5);
                pAlumno.Edad = _reader.GetString(6);
                pAlumno.GradoyGrupo = _reader.GetString(7);
                pAlumno.Fecha_Nac = _reader.GetString(8);
                pAlumno.Telefono = _reader.GetString(9);

                _lista.Add(pAlumno);

            }
            return _lista;
        }
        public static Alumno ObtenerAlumno(int pId)
        {
            Alumno pAlumno = new Alumno();
            MySqlConnection conexion = BDConector.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(string.Format("SELECT IdAlumno, Curp, Nombre, Apellido_Paterno, Apellido_Materno, Genero, Edad, Grupo_y_Grado, Fecha_Nacimiento, Telefono FROM Alumno where idAlumno = {0}",pId),conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pAlumno.Id = _reader.GetInt32(0);
                pAlumno.Curp = _reader.GetString(1);
                pAlumno.Nombre = _reader.GetString(2);
                pAlumno.ApellidoPaterno = _reader.GetString(3);
                pAlumno.ApellidoMaterno = _reader.GetString(4);
                pAlumno.Sexo = _reader.GetString(5);
                pAlumno.Edad = _reader.GetString(6);
                pAlumno.GradoyGrupo = _reader.GetString(7);
                pAlumno.Fecha_Nac = _reader.GetString(8);
                pAlumno.Telefono = _reader.GetString(9);
       

            }
            return pAlumno;
        }
        
    }
}
