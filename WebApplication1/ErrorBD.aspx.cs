using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ErrorBD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Error"] != null)
                {
                    List<Entidad.Producto> oListProd = Negocio.Producto.ObtenerProductos();
                    List<Entidad.Proveedores> oListProov = Negocio.Proveedores.ObtenerTodos();
                    List<Entidad.Producto> oListErrorProd = new List<Entidad.Producto>();
                    List<Entidad.Proveedores> oListErrorProveedores = new List<Entidad.Proveedores>();

                    foreach (Entidad.Producto item in oListProd)
                    {
                        string Total = item.idProducto + item.Descripcion + item.Valor + item.Cantidad;

                        using (MD5 md5Hash = MD5.Create())
                        {
                            string hash = Negocio.Encriptacion.GetMd5Hash(md5Hash, Total);

                            if (hash != item.DVH)
                            {
                                oListErrorProd.Add(item);
                            }
                        }
                    }

                    if (oListErrorProd.Count > 0)
                    {
                        RptProductosError.DataSource = oListErrorProd;
                        RptProductosError.DataBind();
                        prodError.Visible = true;
                    }
                   

                    foreach (Entidad.Proveedores item in oListProov)
                    {
                        string Total = item.idProveedor + item.Descripcion + item.Direccion;

                        using (MD5 md5Hash = MD5.Create())
                        {
                            string hash = Negocio.Encriptacion.GetMd5Hash(md5Hash, Total);

                            if (hash != item.DVH)
                            {
                                oListErrorProveedores.Add(item);
                            }
                        }
                    }

                    if (oListErrorProveedores.Count > 0)
                    {
                        Repeater1.DataSource = oListErrorProveedores;
                        Repeater1.DataBind();
                        ProveeError.Visible = true;
                    }
                    
                }
            }
        }

   

        protected void btnBK_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearBK.aspx");
        }
    }
}