<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication1.LogIn" %>

<%@ Register Src="~/UserControl/ucLogin.ascx" TagPrefix="uc1" TagName="ucLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:ucLogin runat="server" id="ucLogin" />
</asp:Content>
