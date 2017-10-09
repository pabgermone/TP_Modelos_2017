<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="WebApplication1.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <header id="header">
    <div class="top-bar">
    <%--<div class="container">
    <div class="row">
    <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
      
    </div>

    </div>

    </div>--%>

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
<div class="container">
    <div class="row">
        <div class="col-md-8">
            <div class="well well-sm">
                <form>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="name">
                                Nombre</label>
                            <input type="text" class="form-control" id="name" placeholder="Ingrese Nombre" required="required" />
                        </div>
                        <div class="form-group">
                            <label for="email">
                                Email</label>
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span>
                                </span>
                                <input type="email" class="form-control" id="email" placeholder="Ingrese Email" required="required" /></div>
                        </div>
                        <div class="form-group">
                            <label for="subject">
                                Motivo: </label>
                            <select id="subject" name="subject" class="form-control" required="required">
                                <option value="na" selected="">Eliga uno:</option>
                                <option value="service">General</option>
                                <option value="suggestions">Sugerencias</option>
                                <option value="product">Soporte</option>
                            </select>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="name">
                                Mensaje</label>
                            <textarea name="message" id="message" class="form-control" rows="9" cols="25" required="required"
                                placeholder="Mensaje"></textarea>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <button type="submit" class="btn btn-primary pull-right" id="btnContactUs">
                            Enviar Mensaje</button>
                    </div>
                </div>
                </form>
            </div>
        </div>
        <div class="col-md-4">
            <form>
            <legend><span class="glyphicon glyphicon-globe"></span> Ubicación</legend>
            <address>
                <strong>Dirección</strong><br>
                Av. San Juan 960<br>
                <abbr title="Phone">
                    T:</abbr>
                (123) 456-7890
            </address>
            <address>
                <strong>Correo</strong><br>
                <a href="mailto:#">zapaterias.diamond@gmail.com</a>
            </address>
            </form>
        </div>
    </div>
</div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
