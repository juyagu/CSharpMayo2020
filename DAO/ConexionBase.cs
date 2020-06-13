using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConexionBase
    {
        protected SqlConnection conn = new SqlConnection();
        protected SqlCommand cmd = new SqlCommand();
        protected string Query;

        public ConexionBase()
        {
            try
            {
                conn.ConnectionString = Properties.Settings.Default.ABM_BD;
                // SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
