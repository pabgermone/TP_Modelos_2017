using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["Usuario"] == null)
                {
                    Response.Redirect("~/LogIn.aspx");
                }


                if (Convert.ToInt32(Session["Rol"]) == 1)
                {
                    List<Entidad.Producto> oListProd = Negocio.Producto.ObtenerProductos();

                    foreach (Entidad.Producto item in oListProd)
                    {
                        string Total = item.idProducto + item.Descripcion + item.Valor + item.Cantidad;

                        using (MD5 md5Hash = MD5.Create())
                        {
                            string hash = Negocio.Encriptacion.GetMd5Hash(md5Hash, Total);

                            if (hash != item.DVH)
                            {
                                Response.Redirect("ErrorBD.aspx?Error=" + 1);
                            }
                        }
                    }

                    List<Entidad.Proveedores> oListProov = Negocio.Proveedores.ObtenerTodos();

                    foreach (Entidad.Proveedores item in oListProov)
                    {
                        string Total = item.idProveedor + item.Descripcion + item.Direccion;

                        using (MD5 md5Hash = MD5.Create())
                        {
                            string hash = Negocio.Encriptacion.GetMd5Hash(md5Hash, Total);

                            if (hash != item.DVH)
                            {
                                Response.Redirect("ErrorBD.aspx?Error=" + 1);
                            }
                        }
                    }
                }

            }
        }


       
    }
}