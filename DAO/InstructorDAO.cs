using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class InstructorDAO
    {
        private SqlConnection conn = null;
        public List<Instructor> ObtenerInstructores(string connectionString)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                //conn.ConnectionString = connectionString;
                string query = "select usuarios.nombre, usuarios.apellido, instructores.id_instructor from instructores " +
                    "join usuarios on " +
                    "instructores.id_usuario = usuarios.id_usuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                List<Instructor> instructores = new List<Instructor>();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Instructor i = new Instructor(
                            Convert.ToInt32(rd["id_instructor"]),
                            rd["nombre"].ToString(),
                            rd["apellido"].ToString()
                        );
                    instructores.Add(i);
                }

                return instructores;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }finally
            {
                conn.Close(); 
            }
        }
    }
}
