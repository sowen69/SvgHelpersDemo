<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Structural
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
        <h3>SVG Structural Elements Overview</h3>
        <p>An SVG document fragment consists of any number of SVG elements contained within an ‘svg’ element.</p>
        <p>An SVG document fragment can range from an empty fragment (i.e., no content inside of the ‘svg’ element), to a very simple SVG document fragment containing a single SVG graphics element such as a ‘rect’, to a complex, deeply nested collection of container elements and graphics elements.</p>
        <p>An SVG document fragment can stand by itself as a self-contained file or resource, in which case the SVG document fragment is an SVG document, or it can be embedded inline as a fragment within a parent XML document.</p>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>SVG</span>
		<ul>
            <li><a href="http://www.w3.org/TR/SVG/struct.html#SVGElement">WC3 Spec: SVG</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgElement()</h3>
        <p></p>
        <pre class="code">&lt;%= Html.BeginSvg().xlink().X(0).Y(0).Width(150).Height(150) %&gt;
&lt;%= Html.EndSvg() %&gt;</pre>
        <p>Produces the following SVG:</p>
        <pre class="code">&lt;svg xmlns=&quot;http://www.w3.org/2000/svg&quot; xmlns:xlink=&quot;http://www.w3.org/1999/xlink&quot; x=&quot;0&quot; y=&quot;0&quot; width=&quot;150&quot; height=&quot;150&quot;&gt;
&lt;/svg&gt;</pre>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Defs</span>
		<ul>
            <li><a href="http://www.w3.org/TR/SVG/struct.html#DefsElement">WC3 Spec: Defs</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgDefs()</h3>
        <p></p>
        <pre class="code">&lt;%= Html.BeginSvgDefs() %&gt;
   // some SVG here
&lt;%= Html.EndSvgDefs() %&gt;</pre>
        <p>Produces the following SVG:</p>
        <pre class="code">&lt;defs&gt;
    // some SVG here
&lt;/defs&gt;</pre>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Group</span>
		<ul>
            <li><a href="http://www.w3.org/TR/SVG/struct.html#Groups">WC3 Spec: Group</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgGroup()</h3>
        <p></p>
        <pre class="code">&lt;%= Html.BeginSvgGroup().id(&quot;group1&quot;) %&gt;
    // some SVG here
&lt;%= Html.EndSvgGroup %&gt;</pre>
        <p>Produces the following SVG:</p>
        <pre class="code">&lt;g id=&quot;group1&quot;&gt;
    // some SVG here
&lt;/g&gt;</pre>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Symbol</span>
		<ul>
            <li><a href="http://www.w3.org/TR/SVG/struct.html#SymbolElement">WC3 Spec: Symbol</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgSymbol()</h3>
        <p></p>
        <pre class="code">&lt;%= Html.BeginSvgSymbol().Id(&quot;line1&quot;)%&gt;
    // some SVG here
&lt;%= Html.EndSvgSymbol %&gt;</pre>
        <p>Produces the following SVG:</p>
        <pre class="code">&lt;symbol id=&quot;line1&quot;&gt;
    // some SVG here
&lt;/symbol&gt;</pre>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Use</span>
		<ul>
            <li><a href="http://www.w3.org/TR/SVG/struct.html#UseElement">WC3 Spec: Use</a></li>
		</ul>
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>SvgUse()</h3>
        <p></p>
        <pre class="code">&lt;%= Html.BeginSvg().xlink().X(0).Y(0).Width(&quot;10cm&quot;).Height(&quot;3cm&quot;) %&gt;
   &lt;%= Html.SvgDefs() %&gt;
      &lt;%= Html.SvgRect().Id(&quot;MyRect&quot;).Width(60).Height(10) %&gt;
   &lt;%= Html.EndSvgDefs() %&gt;
   &lt;%= Html.SvgUse().X(20).Y(10).XlinkHref(&quot;#MyRect&quot;)
&lt;%= Html.EndSvg() %&gt;</pre>
        <p>Produces the following SVG:</p>
        <pre class="code">&lt;svg width=&quot;10cm&quot; height=&quot;3cm&quot; viewBox=&quot;0 0 100 30&quot; version=&quot;1.1&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot; xmlns:xlink=&quot;http://www.w3.org/1999/xlink&quot;&gt;
  &lt;defs&gt;
    &lt;rect id=&quot;MyRect&quot; width=&quot;60&quot; height=&quot;10&quot;/&gt;
  &lt;/defs&gt;
  &lt;use x=&quot;20&quot; y=&quot;10&quot; xlink:href=&quot;#MyRect&quot; /&gt;
&lt;/svg&gt;</pre>
    </div>
</div>
</asp:Content>
