using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DAO;

namespace AbmAlumnosWeb
{
    public partial class ListadoAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarVistaAlumnos();
            ListarAlumnosConsulta();
        }

        private void ListarVistaAlumnos()
        {
            try
            {
                grid_alumnos_vista.DataSource = AlumnoDAO.GetAlumnosVista();
                grid_alumnos_vista.DataBind();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ListarAlumnosConsulta()
        {
            grid_alumnos_consulta.DataSource = AlumnoDAO.ObtenerAlumnos();
            grid_alumnos_consulta.DataBind();
        }
    }
}