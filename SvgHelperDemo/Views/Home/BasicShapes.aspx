<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	BasicShapes
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="col last span-9">
	<div class="col span-7 nudge-2">
		<h4>Basic SVG Shapes</h4>
	</div>
</div>
<div class="post span-9">
<div class="post-content last span-9 nudge-2">
<h3>Basic Shapes Overview</h3>
<p>SVG contains the following set of basic shape elements:</p>
<ul>
    <li>rectangles (including optional rounded corners), created with the ‘rect’ element,</li>
    <li>circles, created with the ‘circle’ element,</li>
    <li>ellipses, created with the ‘ellipse’ element,</li>
    <li>straight lines, created with the ‘line’ element,</li>
    <li>polylines, created with the ‘polyline’ element, and</li>
    <li>polygons, created with the ‘polygon’ element.</li>
</ul>
<p>Mathematically, these shape elements are equivalent to a ‘path’ element that would construct the same shape. The basic shapes may be stroked, filled and used as clip paths. All of the properties available for ‘path’ elements also apply to the basic shapes.</p>
</div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Line</span>
		<ul>
			<li>Presentation attributes</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.SvgLine().X1(0).Y1(150).X2(150).Y2(0).Presentation(new SvgPresentation().Stroke("#0F83DB").StrokeWidth("5px"))%>   
            <%= Html.EndSvg() %>
            </li>
            <li><a href="http://www.w3.org/TR/SVG/shapes.html#LineElement">WC3 Spec SVG Line</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgLine()</h3>
        <p>A simple line:</p>
<pre class="code">&lt;%= Html.SvgLine().X1(0).Y1(150).X2(150).Y2(0)&crarr;
    .Presentation(new SvgPresentation().Stroke(&quot;#0F83DB&quot;)&crarr;
    .StrokeWidth(&quot;5px&quot;)) %&gt;</pre>
        <p>Which produces the following SVG code:</p>
        <pre class="code">&#60;line x1="0" y1="150" x2="150" y2="0" stroke="#0F83DB"&crarr;
    stroke-width="5px"/></pre>
        
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Rectangle</span>
		<ul>
			<li>Presentation Attributes</li>
			<li class="svgBlock">
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.SvgRect().X(0).Y(0).Width(150).Height(150).Presentation(new SvgPresentation().Stroke("#0F83DB").StrokeWidth("5px").Fill("#fcfcfc"))%>    
            <%= Html.EndSvg() %>
            </li>
            <li><a href="http://www.w3.org/TR/SVG/shapes.html#RectElement">WC3 Spec SVG Rect</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgRectangle()</h3>
        <p>Using presentation element attributes:</p>
        <pre class="code">&#60;%= Html.SvgRect().X(0).Y(0).Width(150).Height(150)&crarr;
    .Presentation(new SvgPresentation().Stroke("#0F83DB")&crarr;
    .StrokeWidth("5px").Fill("#fcfcfc")) %></pre>
        <p>Which produces the following SVG code:</p>
        <pre class="code">&#60;rect x="0" y="0" width="150" height="150" stroke="#0F83DB" &crarr;
    stroke-width="5px" fill="#fcfcfc"/></pre>
        
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Rectangle</span>
		<ul>
			<li>CSS Styling</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.SvgRect().X(0).Y(0).Width(150).Height(150).Style(new SvgStyle().Stroke("#0F83DB").StrokeWidth("5px").Fill("#fcfcfc"))%>    
            <%= Html.EndSvg() %>
            </li>
            <li><a href="http://www.w3.org/TR/SVG/shapes.html#RectElement">WC3 Spec SVG Rect</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgRectangle()</h3>
        <p>Using CSS styling:</p>
        <pre class="code">&#60;%= Html.SvgRect().X(0).Y(0).Width(150).Height(150)&crarr;
    .Style(new SvgStyle().Stroke("#0F83DB")&crarr;
    .StrokeWidth("5px").Fill("#fcfcfc")) %></pre>
            <p>Which produces the following SVG code:</p>
        <pre class="code">&#60;rect x="0" y="0" width="150" height="150" style="stroke:#0F83DB;&crarr; 
    stroke-width:5px; fill:#fcfcfc;"/></pre>
        
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Circle</span>
		<ul>
			<li>CSS Styling</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.SvgCircle().CX(75).CY(75).R(75).Style(new SvgStyle().Stroke("#0F83DB").StrokeWidth("5px").Fill("#fcfcfc"))%>
            <%= Html.EndSvg() %>
            </li>
            <li><a href="http://www.w3.org/TR/SVG/shapes.html#CircleElement">WC3 Spec SVG Circle</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgCircle()</h3>
        <p>Using CSS styling:</p>
        <pre class="code">&#60;%= Html.SvgCircle().CX(75).CY(75).R(75).Style(new SvgStyle()&crarr;
    .Stroke("#0F83DB").StrokeWidth("5px").Fill("#fcfcfc")) %></pre>
            <p>Which produces the following SVG code:</p>
        <pre class="code">&#60;circle cx="75" cy="75" r="75" style="stroke:#0F83DB;&crarr; 
    stroke-width:5px; fill:#fcfcfc;"/></pre>
        
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Ellipse</span>
		<ul>
			<li>CSS Styling</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.SvgEllipse().CX(75).CY(75).RX(75).RY(50).Style(new SvgStyle().Stroke("#0F83DB").StrokeWidth("5px").Fill("#fcfcfc"))%>
            <%= Html.EndSvg() %>    
            </li>
            <li><a href="http://www.w3.org/TR/SVG/shapes.html#EllipseElement">WC3 Spec SVG Ellipse</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgEllipse()</h3>
        <p>Using CSS styling:</p>
        <pre class="code">&#60;%= Html.SvgEllipse().CX(75).CY(75).RX(75).RY(50).Style(new SvgStyle()&crarr;
    .Stroke("#0F83DB").StrokeWidth("5px").Fill("#fcfcfc")) %></pre>
            <p>Which produces the following SVG code:</p>
        <pre class="code">&#60;ellipse cx="75" cy="75" rx="75" ry="50" style="stroke:#0F83DB;&crarr;
    stroke-width:5px; fill:#fcfcfc;"/></pre>
        
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Polygon</span>
		<ul>
			<li>CSS Styling</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.SvgPolygon().Points("0,150 10,10 150,10 140,150").Style(new SvgStyle().Stroke("#0F83DB").StrokeWidth("5px").Fill("#fcfcfc"))%>
            <%= Html.EndSvg() %>    
            </li>
            <li><a href="http://www.w3.org/TR/SVG/shapes.html#PolygonElement">WC3 Spec SVG Polygon</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgPolygon()</h3>
        <p>Using CSS styling:</p>
        <pre class="code">&lt;%= Html.SvgPolygon().Points(&quot;0,150 10,10 150,10 140,150&quot;)&crarr;
    .Style(new SvgStyle().Stroke(&quot;#0F83DB&quot;).StrokeWidth(&quot;5px&quot;)&crarr;
    .Fill(&quot;#fcfcfc&quot;))%&gt;</pre>
            <p>Which produces the following SVG code:</p>
        <pre class="code">&lt;polygon points=&quot;0,150 10,10 150,10 140,150&quot; &crarr;
    style=&quot;stroke:#0F83DB; stroke-width:5px; fill:#fcfcfc;&quot;/&gt;</pre>
        
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Polyline</span>
		<ul>
			<li>CSS Styling</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.SvgPolyline().Points("10,10 130,10 130,130 10,130 10,30 110,30, 110,110 30,110 30,50").Style(new SvgStyle().Stroke("#0F83DB").StrokeWidth("5px").Fill("none"))%>
            <%= Html.EndSvg() %>    
            </li>
            <li><a href="http://www.w3.org/TR/SVG/shapes.html#PolylineElement">WC3 Spec SVG Polyline</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgPolyline()</h3>
        <p>Using CSS styling:</p>
        <pre class="code">&#60;%= Html.SvgPolyline().Points("10,10 130,10 130,130 10,130 10,30 &crarr;
    110,30, 110,110 30,110 30,50").Style(new SvgStyle().Stroke("#0F83DB")&crarr;
    .StrokeWidth("5px").Fill("none"))%></pre>
            <p>Which produces the following SVG code:</p>
        <pre class="code">&lt;polyline points=&quot;10,10 130,10 130,130 10,130 10,30 &crarr;
    110,30, 110,110 30,110 30,50&quot; style=&quot;stroke:#0F83DB;&crarr;
    stroke-width:5px; fill:none;&quot;/&gt;</pre>    
    </div>
</div>
</asp:Content>