CREATE DATABASE if not exists JardinBonifacioDiaz;
USE JardinBonifacioDiaz;

/*Tablas de la base de datos*/

CREATE TABLE Alumno (
    IdAlumno INT NOT NULL AUTO_INCREMENT,
    Curp VARCHAR(20) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido_Paterno VARCHAR(45) NOT NULL,
    Apellido_Materno VARCHAR(45) NOT NULL,
    Genero VARCHAR(1) NOT NULL,
    Edad INT(1) NOT NULL,
    Grupo_y_Grado VARCHAR(2) NOT NULL,
    Fecha_Nacimiento date NOT NULL,
    Telefono varchar (15) not null,
    Fecha_Inscripcion varchar (45) not null,
    Numero_Lista INT NOT NULL,
    Nacionalidad Varchar (45) not null,
    Nombre_Tutor varchar(45) not null,
    Domicilio_Tutor varchar(45) not null,
    PRIMARY KEY (IdAlumno)
 );

CREATE TABLE IF NOT EXISTS EducacionFisica (
    ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Competencias VARCHAR(100) NOT NULL,
    SubCompetencia VARCHAR(50) NOT NULL,
    Calificacion INT(1)
);

CREATE TABLE IF NOT EXISTS PensamientoMatematico (
    ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Competencias VARCHAR(100) NOT NULL,
    SubCompetencia VARCHAR(50) NOT NULL,
    Calificacion INT(1)
);

CREATE TABLE IF NOT EXISTS LenguajeYcomunicacion (
    ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Competencias VARCHAR(100) NOT NULL,
    SubCompetencia VARCHAR(50) NOT NULL,
    Calificacion INT(1)
);

CREATE TABLE IF NOT EXISTS Login (
    idlogin INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Usuario VARCHAR(50) NOT NULL,
    Contraseña VARCHAR(50) NOT NULL
);


CREATE TABLE IF NOT EXISTS Exploracion (
    ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Competencias VARCHAR(100) NOT NULL,
    SubCompetencia VARCHAR(50) NOT NULL,
    Calificacion INT(1)
);

CREATE TABLE IF NOT EXISTS DesarrolloPersonal (
    ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Competencias VARCHAR(100) NOT NULL,
    SubCompetencia VARCHAR(50) NOT NULL,
    Calificacion INT(1)
);

CREATE TABLE IF NOT EXISTS ExpresionYAprecicacion (
    ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Competencias VARCHAR(100) NOT NULL,
    SubCompetencia VARCHAR(50) NOT NULL,
    Calificacion INT(1)
);

/*Boletas de alumnos por asignatura*/

CREATE TABLE IF NOT EXISTS Boletaeducacionfisica (
    Idboletaeducacionfisica INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Competencias VARCHAR(100) NOT NULL,
    SubCompetencia VARCHAR(50) NOT NULL,
    Calificacion INT(1)
);


CREATE TABLE IF NOT EXISTS BoletaLenguajeYcomunicacion(
	IdboletaLenguajeYcomunicacion INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Grado_y_Grupo VARCHAR(2) NOT NULL,
    Esperado INT(2) NOT NULL,
    Desarrollo INT(2) NOT NULL,
    Requiere_Apoyo INT(2) NOT NULL,
    Resultado varchar (20) not null
);

CREATE TABLE IF NOT EXISTS BoletaPensamientoMatematico(
	IdboletaPensamientoMatematico INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Grado_y_Grupo VARCHAR(2) NOT NULL,
    Esperado INT(2) NOT NULL,
    Desarrollo INT(2) NOT NULL,
    Requiere_Apoyo INT(2) NOT NULL,
    Resultado varchar (20) not null
);

INSERT INTO Login VALUES (0,'admin','contraseña');

  select * from alumno;
  select * from EducacionFisica;
  select * from PensamientoMatematico;
  select * from LenguajeYcomunicacion;
  select * from Boletaeducacionfisica;
  select * from BoletaLenguajeYcomunicacion;
  select * from Boletaeducacionfisica where Grupo_y_Grado = '1A';
  drop database JardinBonifacioDiaz;
  SELECT * FROM LOGIN;
  
  
  
  
  SELECT * FROM ExpresionYAprecicacion;
  
  
