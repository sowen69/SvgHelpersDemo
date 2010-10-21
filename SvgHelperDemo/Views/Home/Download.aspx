<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Download
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="col last span-9">
	<div class="col span-7 nudge-2">
		<h4>Downloads</h4>
	</div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Binaries</span>
	</div>
    <div class="post-content last span-9 nudge-2">
        <p>Download the dll and help file by clicking the button below. </p>
        <div>
            <p><span class="dlButton"><a href="/Download/SvgHelpers.zip">DOWNLOAD</a></span></p>
        </div>
    </div>
</div>
<div class="post span-9">
    <div class="post-meta col span-2">
		<span>Source</span>
	</div>
    <div class="post-content last span-9 nudge-2">
        <p>The project source can be downloaded at <a href="http://github.com/sowen69/SvgHelpers">http://github.com/sowen69/SvgHelpers</a> where you can also leave comments, suggestions and/or issues. </p>
    </div>
</div>
</asp:Content>
