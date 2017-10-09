using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.UserControl
{
    public partial class ucLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Page.Master.FindControl("pnlNavbar").Visible = false;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                Entidad.Usuario Usuario = Negocio.Usuario.Login(name.Value, password.Value);

                if (Usuario.Nombre != null || Usuario.Contraseña != null)
                {
                    Session["Usuario"] = Usuario.Nombre;
                    Session["Rol"] = Usuario.Rol;
                    Negocio.Bitacora.RegistrarBitacora(Usuario.Nombre, "Inicio de sesión");
                    Response.Redirect("~/Default");
                }
                else
                {
                    Helper.Javascript.jQueryNotify(this.Page, "Usuario no valido", "3");
                }
            }
            catch (Exception)
            {
                Helper.Javascript.jQueryNotify(this.Page, "Algo salio mal", "3");
                throw;
            }
        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registro");
        }
    }
}