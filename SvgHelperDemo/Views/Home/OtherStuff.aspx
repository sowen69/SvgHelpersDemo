<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	OtherStuff
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Other Stuff</h2>

    <%= Html.BeginSvg().xlink().X(0).Y(0).Width(960).Height(700) %>
    <%= Html.BeginSvgDefs() %>
        <%= Html.BeginSvgSymbol().Id("line1")%>
        <%= Html.SvgLine().X1(0).Y1(0).X2(100).Y2(0).Presentation(new SvgPresentation().Stroke("red").StrokeWidth("2px"))%>   
    <%= Html.EndSvgSymbol() %>
    <%= Html.EndSvgDefs() %>
        <% for (int x = 1; x <= 10; x++)
           { %>
        <%= Html.SvgLine().X1(100).Y1(50).X2(200).Y2(50).Transforms(new SvgTransform().Rotate(x*36,150,50)).Presentation(new SvgPresentation().Stroke("black").StrokeWidth("2px"))%>   
        <% } %>
        <% for (int x = 1; x <= 10; x++)
           { %>
        <%= Html.SvgUse().XlinkHref("#line1").Transforms(new SvgTransform().Translate(300, 50).Rotate(x*36,50,0))%>
        <% } %>  
    <%= Html.EndSvg() %>
</asp:Content>
