<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Infoboard.Web.Controllers" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    
    <div id="BoardView">
    
        <div class="Table">
            <div style=" height: 400px;" class="InfoBox"></div>
            <div style=" height: 100px;" class="InfoBox"></div>
            <div style=" height: 150px;" class="InfoBox"></div>
        </div>
        <div class="Table">
        
            <div style=" height: 250px;" class="InfoBox"></div>
            <div style=" height: 350px;" class="InfoBox"></div>
            <div style=" height: 100px;" class="InfoBox"></div>
            
        </div>
        <div class="Table">
        
            <div style=" height: 400px;" class="InfoBox"></div>
            <div style=" height: 200px;" class="InfoBox"></div>
        
            
        </div>
                
       
     

    
    </div>
    

</asp:Content>
<asp:Content ID="RightsideContentPlaceHolder" ContentPlaceHolderID="RightsideContentPlaceHolder" runat="server">

    

</asp:Content>