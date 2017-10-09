<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebApplication1.Productos" %>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="css/bootstrap-toggle.min.css" rel="stylesheet" />

    	 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <header id="header">
    <div class="top-bar">

    </div>

    
 
    </header>

<div class="jumbotron jumbotron-sm">
    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-lg-12">
                
            </div>
        </div>
    </div>
</div>


        <div class="container wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
            <asp:Panel runat="server" ID="pnlBandeja" Visible="true">
    <div class="container-fluid">

        <hr />

        <div class="row">
            <div class="col-lg-12">
                <asp:Panel ID="Panel1" runat="server">
                    <table class="table table-hover table-bordered"  id="BandejaProductos">
                        <thead>
                            <tr>
                                <th title="Incidencia">Nro Producto</th>
                                <th title="Fecha">Descripcion</th>
                                <th title="Fecha">Stock Disponible</th>
                                <th title="Fecha">Valor</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="rptBandeja" >
                                <ItemTemplate>
                                    <tr>
                                         <td>
                                            <asp:Label ID="rptBandeja_lblSector" runat="server" Text='<%# Eval("IdProducto")%>'></asp:Label>
                                        </td>
                                          <td>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Descripcion")%>'></asp:Label>
                                        </td>
                                          <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Cantidad")%>'></asp:Label>
                                        </td>
                                          <td>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Valor")%>'></asp:Label>
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
</asp:Panel>
            
        </div>




</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
    <script type="text/javascript" src="js/custom.datatables.js"></script>
</asp:Content>