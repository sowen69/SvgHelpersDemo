<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	BasicShapes
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>BasicShapes In In-Line SVG</h2>
    <p></p>
    
    <h3>Line</h3>
    <p>A simple line:
    <pre>
    &#60;%= Html.SvgLine().X1(50).Y1(10).X2(550).Y2(10).Presentation(new SvgPresentation().Stroke("black").StrokeWidth("2px")) %>    
    </pre>
    Which produces the following SVG code:
    <pre>
    &#60;line x1="50" y1="10" x2="550" y2="10" stroke="black" stroke-width="2px"/>
    </pre></p>
    <%= Html.BeginSvg().xlink().X(0).Y(0).Width(960).Height(100) %>
        <%= Html.SvgLine().X1(50).Y1(10).X2(550).Y2(10).Presentation(new SvgPresentation().Stroke("black").StrokeWidth("2px")) %>   
    <%= Html.EndSvg() %>
    
    <h3>Rectancle 1</h3>
    <p>Using presentation element attributes:
    <pre>
    &#60;%= Html.SvgRect().X(50).Y(10).Width(500).Height(50).Presentation(new SvgPresentation().Stroke("green").StrokeWidth("5px").Fill("pink")) %>    
    </pre>Which produces the following SVG code:
    <pre>
    &#60;rect x="50" y="10" width="500" height="50" stroke="green" stroke-width="5px" fill="pink"/>
    </pre></p>
    <%= Html.BeginSvg().xlink().X(0).Y(0).Width(960).Height(100) %>
        <%= Html.SvgRect().X(50).Y(10).Width(500).Height(50).Presentation(new SvgPresentation().Stroke("green").StrokeWidth("5px").Fill("pink")) %>    
    <%= Html.EndSvg() %>
    
    <h3>Rectangle 2</h3>
    <p>Using CSS styling:
    <pre>
    &#60;%= Html.SvgRect().X(50).Y(10).Width(500).Height(50).Style(new SvgStyle().Stroke("green").StrokeWidth("5px").Fill("pink")) %>    
    </pre>
        Which produces the following SVG code:
    <pre>
    &#60;rect x="50" y="10" width="500" height="50" style="stroke:green; stroke-width:5px; fill:pink;"/>
    </pre></p>
    <%= Html.BeginSvg().xlink().X(0).Y(0).Width(960).Height(100) %>
        <%= Html.SvgRect().X(50).Y(10).Width(500).Height(50).Style(new SvgStyle().Stroke("green").StrokeWidth("5px").Fill("pink")) %>    
    <%= Html.EndSvg() %>
    
    <h3>Ellipse</h3>
    <p>Using CSS styling:
    <pre>
    &#60;%= Html.SvgEllipse().CX(200).CY(50).RX(100).RY(50).Style(new SvgStyle().Stroke("grey").StrokeWidth("5px").Fill("blue")) %>    
    </pre>
        Which produces the following SVG code:
    <pre>
    &#60;ellipse cx="200" cy="50" rx="100" ry="50" style="stroke:grey; stroke-width:5px; fill:blue;"/>
    </pre></p>
    <%= Html.BeginSvg().xlink().X(0).Y(0).Width(960).Height(100) %>
        <%= Html.SvgEllipse().CX(200).CY(50).RX(100).RY(50).Style(new SvgStyle().Stroke("grey").StrokeWidth("5px").Fill("blue")) %>
    <%= Html.EndSvg() %>
    
        

</asp:Content>
