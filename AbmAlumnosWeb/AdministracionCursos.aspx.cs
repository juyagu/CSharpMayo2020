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
        }

        protected void obtenerMaterias()
        {
            List<Materia> materias = MateriaDAO.ObtenerMaterias(connectionString);
            DropMaterias.DataSource = materias;
            DropMaterias.DataTextField = "Nombre";
            DropMaterias.DataValueField = "Id_Materia";
            DropMaterias.DataBind();
        }
    }
}