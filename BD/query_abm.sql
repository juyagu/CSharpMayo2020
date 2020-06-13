create database ABM_Alumnos;
use ABM_Alumnos;

create table usuarios
(
id_usuario int not null primary key identity,
nombre varchar(50) not null,
apellido varchar(50) not null
);
create table alumnos
(
id_alumno int not null primary key identity,
id_usuario int FOREIGN KEY REFERENCES usuarios(id_usuario),
regular int not null default 1
);

create table instructores
(
id_instructor int not null primary key identity,
id_usuario int FOREIGN KEY REFERENCES usuarios(id_usuario)
);

create table materias
(
id_materia int not null primary key identity,
nombre varchar(100) not null,
programa varchar(100) not null
);

create table aulas
(
codigo_aula int not null primary key identity,
capacidad int not null
);

create table clases
(
id_clase int not null primary key identity,
inicio DATETIME  not null,
fin DATETIME  not null,
codigo_aula int FOREIGN KEY REFERENCES aulas(codigo_aula)
);

create table cursos
(
	id_curso int not null primary key identity,
	id_materia int FOREIGN KEY REFERENCES materias(id_materia)
);

create table materiasxinstructor
(
id_instructor int FOREIGN KEY REFERENCES instructores(id_instructor),
id_materia int FOREIGN KEY REFERENCES materias(id_materia),
primary key(id_instructor,id_materia)
);

create table alumnosxcurso
(
id_alumno int FOREIGN KEY REFERENCES alumnos(id_alumno),
id_curso int FOREIGN KEY REFERENCES cursos(id_curso),
primary key(id_alumno,id_curso),
);

create table clasesxcurso
(
id_clase int FOREIGN KEY REFERENCES clases(id_clase),
id_curso int FOREIGN KEY REFERENCES cursos(id_curso),
primary key(id_clase,id_curso)
);


CREATE PROCEDURE [dbo].[INS_NUEVO_ALUMNO]
    @Nombre varchar(50),
    @Apellido varchar(50),
    @New_MEM_BASIC_ID int OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO usuarios(nombre,apellido)
    VALUES (@Nombre, @Apellido)

    SELECT @New_MEM_BASIC_ID = SCOPE_IDENTITY()

	insert into alumnos(id_usuario)values
	(@New_MEM_BASIC_ID);
END;