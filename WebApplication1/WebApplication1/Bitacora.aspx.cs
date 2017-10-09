using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Bitacora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/LogIn.aspx");
            }


            if (Convert.ToInt32(Session["Rol"]) != 1)
            {
                Response.Redirect("~/Default.aspx");
            }

            rptBandeja.DataSource = Negocio.Bitacora.ObtenerBitacora();
            rptBandeja.DataBind();
        }
    }
}