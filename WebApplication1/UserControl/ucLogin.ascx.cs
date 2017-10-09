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
        private Int32 CantidadLogin
        {
            get
            {
                return (Int32)ViewState["Login-CantidadLogin"];

            }
            set
            {
                ViewState["Login-CantidadLogin"] = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CantidadLogin = 0;
                Page.Master.FindControl("pnlNavbar").Visible = false;
            }
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            if (CantidadLogin == 3)
            { 
                if (Negocio.Usuario.UsuarioBloqueado(name.Value, 1))
                {
                    Helper.Javascript.jQueryNotify(this.Page, "Limite alcanzado de intentos de conexión, usuario bloqueado", "3");
                    Negocio.Bitacora.RegistrarBitacora(name.Value, "Usuario Bloqueado");
                    CantidadLogin = 0;
                    return;
                }
            }

            try
            {
                Entidad.Usuario Usuario = Negocio.Usuario.Login(name.Value, password.Value);

                if (Usuario.Nombre != null || Usuario.Contraseña != null)
                {

                    if (Usuario.Bloqueado)
                    {
                      Helper.Javascript.jQueryNotify(this.Page, "Su usuario se encuentra bloqueado, por favor contacte al Administrador", "3");
                      return;
                    }

                    Session["Usuario"] = Usuario.Nombre;
                    Session["Rol"] = Usuario.Rol;
                    Negocio.Bitacora.RegistrarBitacora(Usuario.Nombre, "Inicio de sesión");
                    Response.Redirect("~/Default");
                }
                else
                {
                    Helper.Javascript.jQueryNotify(this.Page, "Usuario no valido", "3");
                    CantidadLogin = CantidadLogin + 1;
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