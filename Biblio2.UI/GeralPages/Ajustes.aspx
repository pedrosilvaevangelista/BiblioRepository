<%@ Page Title="" Language="C#" MasterPageFile="~/GeralPages/ManageUsers.Master" AutoEventWireup="true" CodeBehind="Ajustes.aspx.cs" Inherits="Biblio2.UI.GeralPages.Ajustes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Caso não esteja na Master Page, inclua o script aqui -->
    <script src="../Scripts/darkmode.js"></script>
    <link href="../css/ajustes.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ajustes</h1>
    
    <div class="ajustes">
        <label for="ddlDarkMode">Selecione o tema:</label>
        <asp:DropDownList 
            ID="ddlDarkMode" 
            runat="server" 
            ClientIDMode="Static" 
            AutoPostBack="false" 
            onchange="setTheme(this.value)">
            <asp:ListItem Value="default" Text="Rosa" />
            <asp:ListItem Value="dark" Text="Dark" />
            <asp:ListItem Value="light" Text="Light" />
        </asp:DropDownList>
    </div>
</asp:Content>