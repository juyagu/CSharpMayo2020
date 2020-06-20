using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AbmAlumnosWeb
{
    public partial class Buttons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mensaje_boton.Text = "Mensaje on load";
        }

        protected void Boton_Loco_Presionado(object sender, EventArgs e)
        {
            mensaje_boton.Text = "Presionaste el boton de ASP";
        }

        protected void mensaje_boton_DataBinding(object sender, EventArgs e)
        {
            mensaje_boton.Text = "Mensaje modificado";
        }

        protected void Unnamed_TextChanged(object sender, EventArgs e)
        {
            mensaje_boton.Text = "Mensaje modificado";
        }
    }
}