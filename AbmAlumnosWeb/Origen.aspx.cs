using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AbmAlumnosWeb
{
    public partial class Origen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_get_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string apellido = this.txt_apellido.Text;

            Response.Redirect("Destino.aspx?nombre=" + nombre + "&apellido=" + apellido);
        }
    }
}