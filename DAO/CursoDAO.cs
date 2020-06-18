using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using Entidades;
using System.Data.SqlClient;

namespace DAO
{
    public class CursoDAO:ConexionBase
    {
        public List<Curso> ObtenerCursos()
        {
            List<Curso> cursos = new List<Curso>();
            string query = "select * from view_cursos";
            cmd.CommandText = query;
            try
            {
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Instructor i = new Instructor(
                            Convert.ToInt32(rd["id_instructor"]),
                            Convert.ToInt32(rd["id_usuario"]),
                            rd["nombre"].ToString(),
                            rd["apellido"].ToString()
                        );
                    Materia m = new Materia(
                            Convert.ToInt32(rd["id_materia"]),
                            rd["materia"].ToString(),
                            rd["programa"].ToString()
                        );
                    Aula a = new Aula(Convert.ToInt32(rd["codigo_aula"]), Convert.ToInt32(rd["capacidad"]));

                    Curso curso = new Curso(Convert.ToInt32(rd["id_curso"]), i, a, m);
                    cursos.Add(curso);
                }
                return cursos;
            }catch(Exception ex)
            {
                throw ex;
            }finally
            {
                conn.Close();
            }
        }
    }
}
