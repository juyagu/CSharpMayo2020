using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class AlumnoDAO
    {
        public static List<VIEW_ALUMNOS> GetAlumnosVista()
        {
            List<VIEW_ALUMNOS> alumnos = new List<VIEW_ALUMNOS>();
            try
            {
                ABMEntities db = new ABMEntities();
                alumnos = db.VIEW_ALUMNOS.OrderBy(o => o.apellido).ToList();
                return alumnos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (ABMEntities db = new ABMEntities())
                {
                    alumnos = (
                        from u in db.usuarios
                        join a in db.alumnos
                        on u.id_usuario equals a.id_usuario
                        join m in db.materias
                        on a.id_materia equals m.id_materia
                        where a.regular == 1
                        orderby u.apellido
                        select new Alumno
                        {
                            Id_Alumno = a.id_alumno,
                            Nombre = u.nombre,
                            Apellido = u.apellido,
                            Materia = m.nombre
                        }).ToList();
                }
                return alumnos;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
