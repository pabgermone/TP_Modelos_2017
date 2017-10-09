<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorBD.aspx.cs" Inherits="WebApplication1.ErrorBD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
                <h3 style="color:red;">Atención!!! Hay registros que fueron modificados a mano, por favor restaure un Backup</h3>

                <asp:Button runat="server" id="btnBK" CssClass="btn btn-primary" Text="Restaurar Backup" OnClick="btnBK_Click" />
            </div>
        </div>
    </div>
</div>

   
    <div class="row">
    
    <asp:Panel runat="server" ID="prodError" Visible="false">
       <label class="control-label">Productos Modificados</label><br />
     <div class="col-md-4">
      <div class="form-group">

           
                    <div class="col-lg-12">
                         <table class="table table-hover table-bordered" id="BandejaDT">
                        <thead>
                            <tr>
                                <th title="Incidencia">Nro Producto</th>
                                <th title="Fecha" class="col-lg-1">Descripcion</th>
                                <th title="Incidencia">Valor</th>
                                <th title="Incidencia">Cantidad</th>
                      
                            </tr>
                        </thead>
                        <tbody>
                         <asp:Repeater runat="server" ID="RptProductosError">
                               <ItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:Label ID="rptBandeja_lblIDticket" runat="server"><%#Eval("idProducto") %></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="rptBandeja_lblSector" runat="server" Text='<%# Eval("Descripcion")%>'></asp:Label>
                                        </td>
                                            <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Valor")%>'></asp:Label>
                                        </td>
        
                                            <td>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Cantidad")%>'></asp:Label>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                         </asp:Repeater>
                          
                            </tbody>                        
                    </table>
                      </div>
                 </div>
            </div>
   
   </asp:Panel>
    </div>
  
    <div class="row">
    <asp:Panel runat="server" ID="ProveeError" Visible="false">
       <label class="control-label">Proveedores Modificados</label><br />
     <div class="col-md-4">
      <div class="form-group">

         
                    <div class="col-lg-12">
                         <table class="table table-hover table-bordered" id="Table1">
                        <thead>
                            <tr>
                                <th title="Incidencia">Nro Proveedor</th>
                                <th title="Fecha" class="col-lg-1">Descripcion</th>
                                <th title="Incidencia">Dirección</th>
                            
                      
                            </tr>
                        </thead>
                        <tbody>
                         <asp:Repeater runat="server" ID="Repeater1">
                               <ItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:Label ID="rptBandeja_lblIDticket" runat="server"><%#Eval("IdProveedor") %></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="rptBandeja_lblSector" runat="server" Text='<%# Eval("Descripcion")%>'></asp:Label>
                                        </td>
                                            <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Direccion")%>'></asp:Label>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                         </asp:Repeater>
                          
                            </tbody>                        
                    </table>
                      </div>
                 </div>
          
   </div>
   </asp:Panel>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
