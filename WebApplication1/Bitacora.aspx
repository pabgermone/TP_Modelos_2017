<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bitacora.aspx.cs" Inherits="WebApplication1.Bitacora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <header id="header">
    <div class="top-bar">
    <div class="container">
    <div class="row">
    <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
      
    </div>
     <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
      <div class="social">
     <ul class="social-share">
       <%-- <li><a href="#"><i class="fa fa-facebook"></i></a></li>
        <li><a href="#"><i class="fa fa-twitter"></i></a></li>
        <li><a href="#"><i class="fa fa-linkedin"></i></a></li>        
        <li><a href="#"><i class="fa fa-skype"></i></a></li>--%>
     </ul>     
       
    </div>
    </div>
    </div>
      </div><%--container--%>
        </div><%--/top-bar--%>
     
    
    </header>
    
    <div class="jumbotron jumbotron-sm">
    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-lg-12">
                
            </div>
        </div>
    </div>
</div>
           
        <hr />

        <div class="row">
            <div class="container wow fadeInDown">
                <asp:Panel ID="Panel1" runat="server">
                    <table class="table table-hover table-bordered"  id="BandejaBitacora">
                        <thead>
                            <tr>
                                <th title="Incidencia">Numero Registro</th>
                                <th class="col-lg-6" title="Fecha">Descripcion</th>
                                <th title="Fecha">Usuario</th>
                                <th title="Fecha">Fecha</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="rptBandeja" >
                                <ItemTemplate>
                                    <tr>
                                         <td>
                                            <asp:Label ID="rptBandeja_lblSector" runat="server" Text='<%# Eval("idRegistro")%>'></asp:Label>
                                        </td>
                                          <td>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Descripcion")%>'></asp:Label>
                                        </td>
                                          <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Usuario")%>'></asp:Label>
                                        </td>
                                          <td>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Fecha")%>'></asp:Label>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>                        
                    </table>
                </asp:Panel>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
        <script type="text/javascript" src="js/custom.datatables.js"></script>
</asp:Content>
