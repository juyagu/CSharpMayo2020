using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace AbmAlumnosWeb
{
    public partial class CapturaErrores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sincaptura_Click(object sender, EventArgs e)
        {
            Errores.Generar();
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Session["Error"] = ex;
            Server.ClearError();
            Server.Transfer("~/MostrarError.aspx");
        }

        protected void btn_concaptura_Click(object sender, EventArgs e)
        {
            try
            {
                Errores.Generar();
            } catch (Exception ex)
            {
                Server.Transfer("~/MostrarError.aspx?Ex="+ex);
            }
        }

        protected void btn_global_Click(object sender, EventArgs e)
        {
            Response.Redirect("paginaquenoexiste.aspx");
        }
    }
}