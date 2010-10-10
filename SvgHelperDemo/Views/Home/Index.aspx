<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= ViewData["Message"] %></h2>
    <p>With the arrival of the latest wave of browsers SVG can be included inline in your Html markup. 
    </p>
    <p>
        To learn more about SVG Graphics visit <a href="http://www.w3.org/TR/SVG/" title="SVG 1.1 Working Draft">http://www.w3.org/TR/SVG/</a>.
    </p>
</asp:Content>
