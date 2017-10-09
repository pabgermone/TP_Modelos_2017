using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Master.FindControl("pnlNavbar").Visible = false;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (password.Value != confirm.Value)
            {
                Helper.Javascript.jQueryNotify(this.Page, "Las contraseñas no coinciden", Convert.ToString(3));
                return;
            }
            
            if (password.Value.Count() < 6)
            {
                Helper.Javascript.jQueryNotify(this.Page, "La contraseña no puede tener menos de 6 caracteres", Convert.ToString(3));
                return;
            }

            string valor = Negocio.Usuario.RegistrarUsuario(name.Value, password.Value);

            if (valor == "")
            {
                Negocio.Bitacora.RegistrarBitacora(name.Value, "Se registro el Usuario: " + name.Value + " ");
                Helper.Javascript.jQueryNotify(this.Page, "Usuario creado con exito!", Convert.ToString(1));
                Response.Redirect("~/LogIn.aspx");
               
            }
            else { Helper.Javascript.jQueryNotify(this.Page, "Usuario NO creado, por favor revise", Convert.ToString(3)); }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LogIn.aspx");
        }
    }
}