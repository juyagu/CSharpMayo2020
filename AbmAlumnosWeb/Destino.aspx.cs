using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AbmAlumnosWeb
{
    public partial class Destino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["nombre"] == null
                && Request.QueryString["apellido"] == null)
            {
                if (PreviousPage != null)
                {
                    TextBox txt_nombre_resp = null;
                    TextBox txt_ape_resp = null;
                    if (PreviousPage.Master.FindControl("ContentPlaceHolder1")
                           .FindControl("txt_nombre") != null)
                    {
                        txt_nombre_resp = (TextBox)PreviousPage.Master
                                                    .FindControl("ContentPlaceHolder1")
                                                    .FindControl("txt_nombre");
                    }
                    if (PreviousPage.Master.FindControl("ContentPlaceHolder1")
                           .FindControl("txt_apellido") != null)
                    {
                        txt_ape_resp = (TextBox)PreviousPage.Master
                                                    .FindControl("ContentPlaceHolder1")
                                                    .FindControl("txt_apellido");
                    }
                    if (txt_nombre_resp != null && txt_ape_resp != null)
                    {
                        lb_nombre.Text = txt_nombre_resp.Text;
                        lb_apellido.Text = txt_ape_resp.Text;
                    }
                }
            } else
            {
                lb_nombre.Text = Request.QueryString["nombre"].ToString();
                lb_apellido.Text = Request.QueryString["apellido"].ToString();
            }
        }
    }
}