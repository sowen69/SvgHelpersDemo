<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="col last span-9">
	<div class="col span-7 nudge-2">
		<h4>ASP.NET MVC HtmlHelpers for SVG Graphics</h4>
	</div>
</div>
<div class="post span-9">
    <div class="post-content last span-9 nudge-2">
        <h3>Time for SVG</h3>
            <p>With the latest round of browsers comes the ability to render inline SVG. Using a fluent syntax, svghelpers allows you to define SVG mark-up in ASP.NET MVC views.</p>
            <blockquote>
            <p>SVG offers many distinct advantages over other formats. SVG images scale up with little increase in file size and with no loss of fidelity.</p>
            </blockquote>
            <p>There are a few basic examples of how to use the Svghelpers library on this site; however, it’s pretty much a one-to-one mapping of the SVG 1.1 spec (with a few notable omissions) so the best documentation you could have is the WC3’s Spec itself.</p>
            <p>There is no swapping in PNG images happening for the samples on the site - would be kind of pointless don't you think :-) - if you don’t see the samples then your browser doesn’t support inline SVG. </p>
            <h3>Downloads & Comments</h3>
            <p>The binary can be downloaded <a href="/download">here</a>, the source at <a href="http://github.com/sowen69/SvgHelpers">http://github.com/sowen69/SvgHelpers</a> where you can also leave comments, suggestions and/or issues. </p>
            <h3>Installation & Usage</h3>
            <p>Unzip the binary, reference the Odd.Svg.dll in your project and you are good to go.</p>
            <p>The svghelpers are compiled against the 3.5 Framework.</p>
            <h3>Help!</h3>
            <p>At the moment the syntax for the Svghelpers is:</p>
            <pre class="code">&lt;%= Html.SvgCircle().CX(50).CY(50) %&gt;</pre>
            <p>What I <em>want</em> the syntax to be, but don't have the knowledge to do is:</p>
            <pre class="code">&lt;%= Svg.Circle().CX(50).CY(50) %&gt;</pre>
            <p>If you can help in pointing me in the right direction please get in touch or <a href="http://github.com/sowen69/SvgHelpers ">comment on the github repository</a>. Thanks :)</p>
            <h3>Final Comment</h3>
            <p>I wrote this for my own amusement/usage, programming is a hobby not a job and it’s all self-taught – please bare that in mind and be nice with your comments :) </p>
            <p>To learn more about SVG Graphics visit <a href="http://www.w3.org/TR/SVG/" title="SVG 1.1 Working Draft">http://www.w3.org/TR/SVG/</a>.</p>
    </div>
</div>
</asp:Content>
