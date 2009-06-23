<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Infoboard.Web.Infrastructure.Extensions"%>
<%@ Import Namespace="Infoboard.Web.Controllers" %>

<asp:Content ID="BoardContent" ContentPlaceHolderID="_mainContentPlaceHolder" runat="server">
    asdasdasd
</asp:Content>

<asp:Content ID="RightSideContent" ContentPlaceHolderID="_rightsideContentPlaceHolder" runat="server">
    <h3>Menu Title:</h3>
    <ul>
          <li><a href="#">Opret Opslagstavle</a></li>
    </ul>
    <a href="#" title="RSS Feed"><img src="<%= Html.ImagePath("rss.jpg") %>" alt="RSS Feed" /></a>
</asp:Content>

