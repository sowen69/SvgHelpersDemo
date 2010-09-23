<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	BasicShapes
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>BasicShapes In In-Line SVG</h2>
    <p></p>
    <%= Html.BeginSvg().xlink().X(0).Y(0).Width(960).Height(420) %>
        <%= Html.SvgLine().X1(50).Y1(50).X2(800).Y2(50).Presentation(new SvgPresentation().Stroke("black").StrokeWidth("2px")) %>   
        <%= Html.SvgRect().X(50).Y(75).Width(500).Height(50).Presentation(new SvgPresentation().Stroke("green").StrokeWidth("5px").Fill("pink")) %>
        <%= Html.SvgRect().X(50).Y(150).Width(500).Height(50).Style(new SvgStyle().Stroke("green").StrokeWidth("5px").Fill("pink")) %>
        <%= Html.SvgEllipse().CX(800).CY(150).RX(100).RY(50).Style(new SvgStyle().Stroke("grey").StrokeWidth("1px").Fill("white")) %>
    <%= Html.EndSvg() %>
    

</asp:Content>
