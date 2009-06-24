<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Infoboard.Web.Infrastructure.Extensions"%>
<%@ Import Namespace="Infoboard.Web.Controllers" %>

<asp:Content ID="BoardContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    
    <div id="MyBoardContent">
        <h2>Mine Opslagstavler</h2>
    </div>
</asp:Content>

<asp:Content ID="RightSideContent" ContentPlaceHolderID="RightsideContentPlaceHolder" runat="server">
    <h3>Muligheder:</h3>
    <ul>
          <li><a href="#">Opret Opslagstavle</a></li>
          <li><a href="#">Sorter Opslagstavle</a></li>
    </ul>
</asp:Content>

