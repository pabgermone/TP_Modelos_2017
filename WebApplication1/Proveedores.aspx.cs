using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Proveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("~/LogIn.aspx");
                }

                rptBandeja.DataSource = Negocio.Proveedores.ObtenerTodos();
                rptBandeja.DataBind();
            }
        }
    }
}