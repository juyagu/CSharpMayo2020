using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class AulaDAO
    {
        public static List<Aula> ObtenerAulas(string connectionString)
        {
            List<Aula> aulas = new List<Aula>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "select codigo_aula, capacidad from aulas";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Aula a = new Aula(Convert.ToInt32(dr["codigo_aula"]), Convert.ToInt32(dr["capacidad"]));
                    aulas.Add(a);
                }
            }
            return aulas;
        }
    }
}
