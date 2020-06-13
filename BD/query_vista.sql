reate view view_cursos as
  SELECT        dbo.cursos.id_curso, dbo.instructores.id_instructor, dbo.usuarios.id_usuario, 
  dbo.usuarios.nombre, dbo.usuarios.apellido, dbo.materias.id_materia, dbo.materias.nombre AS materia,
  dbo.materias.programa, aulas.codigo_aula, aulas.capacidad
FROM            dbo.cursos INNER JOIN
                         dbo.instructores ON dbo.cursos.id_instructor = dbo.instructores.id_instructor INNER JOIN
                         dbo.materias ON dbo.cursos.id_materia = dbo.materias.id_materia INNER JOIN
                         dbo.usuarios ON dbo.instructores.id_usuario = dbo.usuarios.id_usuario
						 join aulas on cursos.codigo_aula = aulas.codigo_aula;