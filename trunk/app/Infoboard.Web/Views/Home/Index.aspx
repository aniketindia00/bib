<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Infoboard.Web.Controllers" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="_mainContentPlaceHolder" runat="server">
    
    <h2>Title</h2>
    
    <h3>Sub-Title</h3>
    
    <p>Content</p>
        
    <ol class="code">
        <li class="t0">private void ClapYourHands() {</li>
        <li class="t1"><code>if (youre_happy && you_know_it) {</code></li>
        <li class="t2"><code>ClapYourHands();</code></li>
        <li class="t1"><code>}</code></li>
        <li class="t0">}</li>
    </ol>
    
    <blockquote>
        <p>Blockquote</p>
    </blockquote>
    
    <div class="date">
        <a href="#" title="#">Bottom</a>
    </div>
</asp:Content>
