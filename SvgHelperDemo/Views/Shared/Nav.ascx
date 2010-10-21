<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
        <ul>
			<li><%= Html.ActionLink("Home", "Index", "Home")%></li>
            <li><%= Html.ActionLink("Structural", "Structural", "Home")%></li>
            <li><%= Html.ActionLink("Basic Shapes", "BasicShapes","Home") %></li>
            <li><%= Html.ActionLink("Gradients", "Gradients","Home") %></li>
            <%--<li><%= Html.ActionLink("Other Stuff", "OtherStuff","Home") %></li>--%>
            <li><%= Html.ActionLink("Download", "Download", "Home") %></li>
            <li>&nbsp;</li>
            <li><%= Html.ActionLink("About", "About", "Home")%></li>
		</ul>
