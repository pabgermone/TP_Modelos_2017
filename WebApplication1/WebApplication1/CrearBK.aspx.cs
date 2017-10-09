using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CrearBK : System.Web.UI.Page
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
        }

        protected void BtnBKCrear_Click(object sender, EventArgs e)
        {
          
           string ruta = @"C:\BK\";
           string nombre = Nombre.Value;
           string Retorno = Negocio.Backup.CrearBackup(ruta, nombre);

           if (Retorno == string.Empty)
           {
               Negocio.Bitacora.RegistrarBitacora(Session["Usuario"].ToString(), "Creo el BackUp (" + nombre + ") ");
               Helper.Javascript.jQueryNotify(this.Page, "Backup creado correctamente", "1");
           }
           else
           {
               Negocio.Bitacora.RegistrarBitacora(Session["Usuario"].ToString(), "Fallo al crear un BackUp");
               Helper.Javascript.jQueryNotify(this.Page, "Error al crear el archivo", "2");
           }
        }


        protected void BtnRestaurarBK_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\BK\";
            string nombre = NombreRestaura.Value;
            string retorno = Negocio.Backup.RestaurarBackup(ruta, nombre);


            if (retorno == string.Empty)
            {
                Negocio.Bitacora.RegistrarBitacora(Session["Usuario"].ToString(), "Restauro el BackUp (" + nombre + ") ");
                Helper.Javascript.jQueryNotify(this.Page, "Restauro BackUp correctamente", "1");
            }
            else
            {
                Negocio.Bitacora.RegistrarBitacora(Session["Usuario"].ToString(), "Fallo restaurar un BackUp");
                Helper.Javascript.jQueryNotify(this.Page, "Error al Restaurar BackUp", "2");
            }
        }
    }
}