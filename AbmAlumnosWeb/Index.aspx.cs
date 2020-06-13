using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace AbmAlumnosWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Materia m1 = new Materia("PHP", "Programa de PHP");
            Materia m2 = new Materia("C#", "Programa de C#");
            List<Materia> materias = new List<Materia>();
            materias.Add(m1);
            materias.Add(m2);


            //Instructor i1 = new Instructor("Roberto","Perez",materias);
        }
    }
}