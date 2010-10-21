<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Odd.Svg.SvgHelpers" %>
<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="col last span-9">
	<div class="col span-7 nudge-2">
		<h4>About</h4>
	</div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
	</div>
    <div class="post-content last span-9 nudge-2">
        <h3>Thanks to...</h3>
        <p>Qudos to <a href="http://stackoverflow.com/users/365526/buildstarted">BuildStarted</a> for his help with my question on <a href="http://stackoverflow.com/questions/3684751/how-to-create-a-fluent-style-mvc-2-html-helper">StackOverflow</a> which pointed me in the right direction in putting the svghelpers together, thanks man :)</p>
        <p>Also thanks to Chris for checking the project over to make sure I wasn't making a total twat of myself before showing the world my code, grassyarse amigo.</p>
        <h3>...and finally</h3>
        <p>Thanks to Rodrigo Galindez for his <a href="http://www.rodrigogalindez.com/wordpress-themes/" title="Free Wordpress Theme">Experimental</a> html theme which makes this site look pretty.</p>
    </div>
</div>
</asp:Content>
