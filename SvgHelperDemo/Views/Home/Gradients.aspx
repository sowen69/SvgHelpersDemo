<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Gradients
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="col last span-9">
	<div class="col span-7 nudge-2">
		<h4>Gradients & Gradient Stops</h4>
	</div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
    </div>
    <div class="post-content last span-9 nudge-2">
        <h3>SVG Gradients Overview</h3>
        <p>Gradients consist of continuously smooth color transitions along a vector from one color to another, possibly followed by additional transitions along the same vector to other colors. SVG provides for two types of gradients: linear gradients and radial gradients.</p>
                <blockquote>
            <p>SVG uses the general notion of a paint server. Gradients and patterns are just specific types of built-in paint servers. Paint servers are referenced using a URI reference on a ‘fill’ or ‘stroke’ property.</p>
        </blockquote>
        <p>Once defined, gradients are then referenced using ‘fill’ or ‘stroke’ properties on a given graphics element to indicate that the given element shall be filled or stroked with the referenced gradient.</p>
        <p>The angle of the color transitions along the gradient vector is defined by the gradient normal. Before any transforms are applied to the gradient or its referencing graphics element, the gradient normal is perpendicular with the gradient vector. </p>
        <p>If a graphics element references a gradient, conceptually the graphics element should take a copy of the gradient vector and gradient normal and treat it as part of its own geometry. Any transformations applied to the graphics element geometry also apply to the copied gradient vector and gradient normal. Any gradient transforms that are specified on the reference gradient are applied before any graphics element transformations are applied to the gradient.</p>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Linear</span>
		<ul>
			<li>Presentation attributes</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.BeginSvgDefs() %>
                    <%= Html.SvgLinearGradient().Id("MyLinearGradient").HasChildNode(true) %>
                        <%=Html.SvgGradientStop().Offset("0").Presentation(new SvgPresentation().StopColor("#0F83DB"))%>
                        <%=Html.SvgGradientStop().Offset("100%").Presentation(new SvgPresentation().StopColor("#FFFFFF")) %>
                    <%= Html.EndSvgLinearGradient() %>
                <%= Html.EndSvgDefs() %>
                <%= Html.SvgRect().X(0).Y(0).Width(150).Height(150).Presentation(new SvgPresentation().Stroke("#0F83DB").StrokeWidth("5px").Fill("url(#MyLinearGradient)"))%>
            <%= Html.EndSvg() %>
            </li>
            <li><a href="http://www.w3.org/TR/SVG/pservers.html">WC3 Spec: Gradients</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgLinearGradient()</h3>
        <p>‘linearGradient’ elements are never rendered directly; their only usage is as something that can be referenced using the ‘fill’ and ‘stroke’ properties. The ‘display’ property does not apply to the ‘linearGradient’ element; thus, ‘linearGradient’ elements are not directly rendered even if the ‘display’ property is set to a value other than none, and ‘linearGradient’ elements are available for referencing even when the ‘display’ property on the ‘linearGradient’ element or any of its ancestors is set to none.</p>
<pre class="code">&lt;%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %&gt;
    &lt;%= Html.BeginSvgDefs() %&gt;
        &lt;%= Html.SvgLinearGradient().Id(&quot;MyLinearGradient&quot;).HasChildNode(true) %&gt;
            &lt;%=Html.SvgGradientStop().Offset(&quot;0&quot;).Presentation(new SvgPresentation().StopColor(&quot;#0F83DB&quot;)) %&gt;
            &lt;%=Html.SvgGradientStop().Offset(&quot;100%&quot;).Presentation(new SvgPresentation().StopColor(&quot;#FFFFFF&quot;)) %&gt;
        &lt;%= Html.EndSvgLinearGradient() %&gt;
    &lt;%= Html.EndSvgDefs() %&gt;
    &lt;%= Html.SvgRect().X(0).Y(0).Width(150).Height(150).Presentation(new SvgPresentation().Stroke(&quot;green&quot;).StrokeWidth(&quot;5px&quot;).Fill(&quot;url(#MyLinearGradient)&quot;)) %&gt;
&lt;%= Html.EndSvg() %&gt;</pre>
<pre class="code">&lt;svg xmlns=&quot;http://www.w3.org/2000/svg&quot; xmlns:xlink=&quot;http://www.w3.org/1999/xlink&quot; x=&quot;0&quot; y=&quot;0&quot; width=&quot;150&quot; height=&quot;150&quot;&gt;
    &lt;defs&gt;
        &lt;linearGradient id=&quot;MyLinearGradient&quot;&gt;
            &lt;stop offset=&quot;0&quot; stop-color=&quot;#A056C4&quot;/&gt;
            &lt;stop offset=&quot;100%&quot; stop-color=&quot;#FFFFFF&quot;/&gt;
        &lt;/linearGradient&gt;
    &lt;/defs&gt;
    &lt;rect x=&quot;0&quot; y=&quot;0&quot; width=&quot;150&quot; height=&quot;150&quot; stroke=&quot;#0F83DB&quot; stroke-width=&quot;5px&quot; fill=&quot;url(#MyLinearGradient)&quot;/&gt;
&lt;/svg&gt;</pre>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Radial</span>
		<ul>
			<li>Presentation attributes</li>
			<li>
            <%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %>
                <%= Html.BeginSvgDefs() %>
                    <%= Html.SvgRadialGradient().Id("MyRadialGradient").HasChildNode(true) %>
                        <%=Html.SvgGradientStop().Offset("5%").Presentation(new SvgPresentation().StopColor("#FFFFFF"))%>
                        <%=Html.SvgGradientStop().Offset("95%").Presentation(new SvgPresentation().StopColor("#0F83DB"))%>
                    <%= Html.EndSvgRadialGradient() %>
                <%= Html.EndSvgDefs() %>
                <%= Html.SvgRect().X(0).Y(0).Width(150).Height(150).Presentation(new SvgPresentation().Stroke("#0F83DB").StrokeWidth("5px").Fill("url(#MyRadialGradient)"))%>
            <%= Html.EndSvg() %>
            </li>
            <li><a href="http://www.w3.org/TR/SVG/pservers.html">WC3 Spec: Gradients</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgRadialGradient()</h3>
        <p>‘radialGradient’ elements are never rendered directly; their only usage is as something that can be referenced using the ‘fill’ and ‘stroke’ properties. The ‘display’ property does not apply to the ‘radialGradient’ element; thus, ‘radialGradient’ elements are not directly rendered even if the ‘display’ property is set to a value other than none, and ‘radialGradient’ elements are available for referencing even when the ‘display’ property on the ‘radialGradient’ element or any of its ancestors is set to none.</p>
        <p>If the point defined by ‘fx’ and ‘fy’ lies outside the circle defined by ‘cx’, ‘cy’ and ‘r’, then the user agent shall set the focal point to the intersection of the line from (‘cx’, ‘cy’) to (‘fx’, ‘fy’) with the circle defined by ‘cx’, ‘cy’ and ‘r’.</p>
        <pre class="code">&lt;%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %&gt;
    &lt;%= Html.BeginSvgDefs() %&gt;
        &lt;%= Html.SvgRadialGradient().Id(&quot;MyRadialGradient&quot;).HasChildNode(true) %&gt;
            &lt;%=Html.SvgGradientStop().Offset(&quot;5%&quot;).Presentation(new SvgPresentation().StopColor(&quot;#FFFFFF&quot;))%&gt;
            &lt;%=Html.SvgGradientStop().Offset(&quot;95%&quot;).Presentation(new SvgPresentation().StopColor(&quot;#0F83DB&quot;))%&gt;
        &lt;%= Html.EndSvgRadialGradient() %&gt;
    &lt;%= Html.EndSvgDefs() %&gt;
    &lt;%= Html.SvgRect().X(0).Y(0).Width(150).Height(150).Presentation(new SvgPresentation().Stroke(&quot;green&quot;).StrokeWidth(&quot;5px&quot;).Fill(&quot;url(#MyRadialGradient)&quot;))%&gt;
&lt;%= Html.EndSvg() %&gt;</pre>
<pre class="code">&lt;svg xmlns=&quot;http://www.w3.org/2000/svg&quot; xmlns:xlink=&quot;http://www.w3.org/1999/xlink&quot; x=&quot;0&quot; y=&quot;0&quot; width=&quot;150&quot; height=&quot;150&quot;&gt;
    &lt;defs&gt;
        &lt;radialGradient id=&quot;MyRadialGradient&quot;&gt;
            &lt;stop offset=&quot;5%&quot; stop-color=&quot;#FFFFFF&quot;/&gt;
            &lt;stop offset=&quot;95%&quot; stop-color=&quot;#A056C4&quot;/&gt;
        &lt;/radialGradient&gt;
    &lt;/defs&gt;
    &lt;rect x=&quot;0&quot; y=&quot;0&quot; width=&quot;150&quot; height=&quot;150&quot; stroke=&quot;#0F83DB&quot; stroke-width=&quot;5px&quot; fill=&quot;url(#MyRadialGradient)&quot;/&gt;
&lt;/svg&gt;</pre>
    </div>
</div>
</asp:Content>