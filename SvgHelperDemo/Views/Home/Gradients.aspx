<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Gradients
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gradients</h2>
    <%= Html.BeginSvg().xlink().X(0).Y(0).Width(960).Height(200) %>
    <%= Html.BeginSvgDefs() %>
        <%= Html.SvgLinearGradient().Id("MyLinearGradient").HasChildNode(true) %>
            <%=Html.SvgGradientStop().Offset("0").Presentation(new SvgPresentation().StopColor("#A056C4")) %>
            <%=Html.SvgGradientStop().Offset("100%").Presentation(new SvgPresentation().StopColor("#FFFFFF")) %>
        <%= Html.EndSvgLinearGradient() %>
        <%= Html.SvgRadialGradient().Id("MyRadialGradient").HasChildNode(true) %>
            <%=Html.SvgGradientStop().Offset("5%").Presentation(new SvgPresentation().StopColor("#FFFFFF"))%>
            <%=Html.SvgGradientStop().Offset("95%").Presentation(new SvgPresentation().StopColor("#A056C4"))%>
        <%= Html.EndSvgRadialGradient() %>
    <%= Html.EndSvgDefs() %>
        <%= Html.SvgRect().X(50).Y(10).Width(500).Height(80).Presentation(new SvgPresentation().Stroke("green").StrokeWidth("5px").Fill("url(#MyLinearGradient)")) %>
        <%= Html.SvgRect().X(50).Y(110).Width(500).Height(80).Presentation(new SvgPresentation().Stroke("green").StrokeWidth("5px").Fill("url(#MyRadialGradient)")) %>
    <%= Html.EndSvg() %>
</asp:Content>