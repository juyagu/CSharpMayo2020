using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using Entidades;
using DAO;

namespace AbmAlumnosWeb
{
    public partial class AdministracionCursos : System.Web.UI.Page
    {
        protected string connectionString = WebConfigurationManager.ConnectionStrings["ABM_BD"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            obtenerMaterias();
            obtenerAulas();
            obtenerInstructores();
        }

        protected void obtenerMaterias()
        {
            List<Materia> materias = MateriaDAO.ObtenerMaterias(connectionString);
            DropMaterias.DataSource = materias;
            DropMaterias.DataTextField = "Nombre";
            DropMaterias.DataValueField = "Id_Materia";
            DropMaterias.DataBind();
        }

        protected void obtenerAulas()
        {
            List<Aula> aulas = AulaDAO.ObtenerAulas(connectionString);
            DropAula.DataSource = aulas;
            DropAula.DataTextField = "Nombre_Aula";
            DropAula.DataValueField = "Codigo_Aula";
            DropAula.DataBind();
        }

        protected void obtenerInstructores()
        {
            try
            {
                InstructorDAO instructorDAO = new InstructorDAO();
                DropInstructor.DataSource = instructorDAO.ObtenerInstructores(connectionString);
                DropInstructor.DataTextField = "Apellido";
                DropInstructor.DataValueField = "Id_Instructor";
                DropInstructor.DataBind();
            }
            catch(Exception e)
            {
                //label_error.Text = e.Message;
                label_error.Text = "Estamos ocupados, vuelva mas tarde";
            }
        }
    }
}