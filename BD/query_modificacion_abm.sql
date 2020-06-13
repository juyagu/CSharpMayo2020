
  alter table cursos add codigo_aula int;
  alter table cursos add id_instructor int;
  alter table cursos add habilitado int default 1;


  insert into materias(nombre,programa)
  values('C#','Programa de C#');
  insert into materias(nombre,programa)
  values('PHP','Programa de PHP');
  insert into materias(nombre,programa)
  values('Python','Programa de Python');


  insert into aulas(capacidad)
  values(15);
  insert into aulas(capacidad)
  values(20);
  insert into aulas(capacidad)
  values(10);


  insert into usuarios(nombre,apellido)
  values('Jose','Perez');

  insert into instructores(id_usuario)
  values(1);