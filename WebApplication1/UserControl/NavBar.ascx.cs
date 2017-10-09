using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.UserControl
{
    public partial class NavBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Session["Rol"]) != 1)
            {
                NavBitacora.Visible = false;
                NavProductos.Visible = true;
                NavContacto.Visible = true;
            }
            else { 
                NavBitacora.Visible = true;
                NavProductos.Visible = false;
                NavContacto.Visible = false;
            }

            if (Session["Usuario"] != null)
            {
                string Rol = "";

                if (Convert.ToInt32(Session["Rol"]) == 1)
                { Rol = "WebMaster"; }

                 if (Convert.ToInt32(Session["Rol"]) == 2)
                { Rol = "Usuario"; }

                lblUsername.Text = Session["Usuario"].ToString();
                lblRol.Text = "Rol Actual: " + Rol + "";
            }

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            Negocio.Bitacora.RegistrarBitacora(Session["Usuario"].ToString(), "Cerrar sesión");

            Session.Abandon();
            Response.Redirect("~/LogIn.aspx");
        }
    }
}