using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class MateriaDAO
    {
        public static List<Materia> ObtenerMaterias(string connectionString)
        {
            List<Materia> materias = new List<Materia>();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "select id_materia,nombre from materias";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Materia m = new Materia(Convert.ToInt32(dr["id_materia"]), dr["nombre"].ToString());
                  
                    materias.Add(m);
                }
                con.Close();
            }
            return materias;
        }
    }
}
