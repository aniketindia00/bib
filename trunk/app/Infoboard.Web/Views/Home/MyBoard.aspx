<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Infoboard.Web.Infrastructure.Extensions"%>
<%@ Import Namespace="Infoboard.Web.Controllers" %>

<asp:Content ID="BoardContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    
    <div class="MyBoardContent">
        <h2>Personlige Opslagstavler</h2>
        <div class="BoardItem">     
            <h3>Dette er overskriften</h3>
            <p>Beskrivelse af opslagsetavlen</p>    
        </div>
        <div class="BoardItem">     
            <h3>Dette er overskriften</h3>
            <p>Beskrivelse af opslagsetavlen</p>    
        </div>
        <div class="BoardItem">     
            <h3>Dette er overskriften</h3>
            <p>Beskrivelse af opslagsetavlen</p>    
        </div>
    </div>
    
    <div class="MyBoardContent">
        <h2>Templates</h2>
        <div class="BoardItem">     
            <h3>Dette er overskriften</h3>
            <p>Beskrivelse af opslagsetavlen</p>    
        </div>
        <div class="BoardItem">     
            <h3>Dette er overskriften</h3>
            <p>Beskrivelse af opslagsetavlen</p>    
        </div>
        <div class="BoardItem">     
            <h3>Dette er overskriften</h3>
            <p>Beskrivelse af opslagsetavlen</p>    
        </div>
    </div>
</asp:Content>


