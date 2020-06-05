using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AbmAlumnosWeb
{
    public partial class Abm : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HyperLinkInicio_Load(object sender, EventArgs e)
        {
            HyperLinkInicio.NavigateUrl = "Index.aspx";
        }

        protected void manejadorDeEventoLoad(object sender, EventArgs e)
        {
            
        }

    }
}