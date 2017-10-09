<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavBar.ascx.cs" Inherits="WebApplication1.UserControl.NavBar" %>


        <nav class="navbar navbar-inverse" runat="server" role="banner">
          <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="Default.aspx">Zapatos Diamond</a>
                </div>
				
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="Default.aspx"><i class="fa fa-home" aria-hidden="true"></i> Inicio</a></li>
                        <%--<li runat="server" id="NavBitacora" visible="false"><a href="Bitacora.aspx"><i class="fa fa-file-text-o" aria-hidden="true"></i> Bitacora</a></li>--%>
                        <li><a href="Productos.aspx" runat="server" id="NavProductos"><i class="fa fa-shopping-cart" aria-hidden="true"></i> Productos</a></li>                        
                        <li><a href="Contacto.aspx" runat="server" id="NavContacto"><i class="fa fa-inbox" aria-hidden="true"></i> Contacto</a></li>

                         <li class="dropdown">
                    <a href="#" class="dropdown-toggle" runat="server" id="NavBitacora" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><i class="fa fa-gear" aria-hidden="true"></i> Administrar <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="Bitacora.aspx"><i class="fa fa-cube" aria-hidden="true"></i>  Bitacora</a></li>
                        <li><a href="AdministrarUsuarios.aspx"><i class="fa fa-users" aria-hidden="true"></i> Usuarios</a></li>
                        <li><a href="Proveedores.aspx"><i class="fa fa-align-justify" aria-hidden="true"></i> Proveedores</a></li>
                        <li><a href="CrearBK.aspx"><i class="fa fa-th-large" aria-hidden="true"></i>  Crear Backup</a></li>
                    </ul>
                </li> 
           
                    </ul>


                    
                     <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a>
                            <i class="fa fa-user-o" aria-hidden="true"></i> Bienvenido: <strong><asp:Label ID="lblUsername" runat="server" /></strong> | <strong><asp:Label ID="lblRol" runat="server" /></strong> 
                        </a>
                    </li>
                         <li>
                            <asp:LinkButton ID="btnCerrarSesion" OnClick="btnCerrarSesion_Click" runat="server"><i class="fa fa-sign-out" aria-hidden="true"></i> Cerrar Sesión</asp:LinkButton>
                        </li>
                    
                </ul>
                    
                </div>
            </div><!--/.container-->

              

        </nav>
         
   