<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearBK.aspx.cs" Inherits="WebApplication1.CrearBK" %>
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
    <div class="col-md-4">
      <div class="form-group">
    

     <div class="input-group">
       <span class="input-group-btn">
        <button class="btn btn-default" type="button">Nombre del Archivo: </button>
      </span>
      <input type="text" runat="server" id="Nombre" name="Nombre" class="form-control" placeholder="Nombre">
     
    </div><!-- /input-group -->
          <br />
    <asp:Button runat="server" ID="BtnBKCrear" Text="Crear Backup" CssClass="btn btn-primary" OnClick="BtnBKCrear_Click" />
    </div>
        </div>


        <div class="col-md-4">
      <div class="form-group">
    

     <div class="input-group">
       <span class="input-group-btn">
        <button class="btn btn-default" type="button">Nombre del Archivo: </button>
      </span>
      <input type="text" runat="server" id="NombreRestaura" name="NombreRestaura" class="form-control" placeholder="Nombre">
     
    </div><!-- /input-group -->
          <br />
    <asp:Button runat="server" ID="BtnRestaurarBK" OnClick="BtnRestaurarBK_Click" Text="Restaurar Backup"  CssClass="btn btn-warning" />
    </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
