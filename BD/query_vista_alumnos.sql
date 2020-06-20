
insert into usuarios (nombre,apellido)
values ('Andrea','Rodriguez');
insert into usuarios (nombre,apellido)
values ('Pablo','Morales');

alter table alumnos add id_materia int;

insert into alumnos(id_usuario,regular)
values (2,1);
insert into alumnos(id_usuario,regular)
values (3,1);

update alumnos set id_materia = 1
where id_alumno = 1;

update alumnos set id_materia = 2
where id_alumno = 2;


go
create view VIEW_ALUMNOS
as select alumnos.id_alumno,usuarios.nombre,usuarios.apellido,materias.nombre materia from usuarios 
join alumnos 
on usuarios.id_usuario = alumnos.id_usuario
join materias on alumnos.id_materia = materias.id_materia
where alumnos.regular = 1;
