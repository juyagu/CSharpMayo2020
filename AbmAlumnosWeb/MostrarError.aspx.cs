using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AbmAlumnosWeb
{
    public partial class MostrarError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["Ex"] != null)
            {
                this.lbMensaje.Text = Request.QueryString["Ex"];
            }else
            {
                if (Session["Error"] != null)
                {
                    Exception ex = (Exception)Session["Error"];
                    this.lbMensaje.Text = ex.Message;
                    Session["Error"] = null;
                }
            }
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CapturaErrores.aspx");
        }
    }
}