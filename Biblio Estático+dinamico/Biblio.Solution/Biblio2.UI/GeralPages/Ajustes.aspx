<%@ Page Title="" Language="C#" MasterPageFile="~/GeralPages/ManageUsers.Master" AutoEventWireup="true" CodeBehind="Ajustes.aspx.cs" Inherits="Biblio2.UI.GeralPages.Ajustes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Caso não esteja na Master Page, inclua o script aqui -->
    <script src="../Scripts/darkmode.js"></script>
    <link href="../css/ajustes.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ajustes ⚙️</h1>

    <select id="ddlDarkMode" onchange="setTheme(this.value)">
        <option value="default">Padrão</option>
        <option value="light">Claro</option>
        <option value="dark">Escuro</option>
        <option value="contrast">Alto Contraste</option>
        <option value="miope">Visão Ampliada</option>
    </select>

    <asp:Button ID="btnSairConta" runat="server" Text="Sair Da Conta" OnClick="btnSairConta_Click" CssClass="btn-sair" />
    <asp:Button ID="btnDeletarConta" runat="server" Text="Excluir Conta"
        OnClick="btnDeletarConta_Click"
        OnClientClick="return confirm('Você tem certeza que deseja deletar sua conta? Essa ação não pode ser desfeita.');"
        CssClass="delete-btn" />
    <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Green"></asp:Label>
</asp:Content>
