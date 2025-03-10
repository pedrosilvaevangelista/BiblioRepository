<%@ Page Title="" Language="C#" MasterPageFile="~/GeralPages/ManageUsers.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Biblio2.UI.GeralPages.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Certifique-se de que o Bootstrap esteja incluído no MasterPage ou aqui -->
    <link href="../css/inicio.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Container da logo com 100% da largura, alinhada à esquerda e com sombra -->
    <div class="logo-container">
        <img class="logo-img" src="../img/logobibliosemfundo.png" alt="Logo" />
    </div>

    <h1>Sugestões 🔥:</h1>

    <!-- Botão de recarregar sugestões usando classes do Bootstrap -->
    <asp:Button ID="BtnRecarregarSugestoes" runat="server" OnClick="BtnRecarregarSugestoes_Click" 
        CssClass="btn btn-primary" Text="Recarregar Sugestões" />

    <div class="card-container">
        <asp:Repeater ID="rptSugestoes" runat="server">
            <ItemTemplate>
                <a href='<%# "../GeralPages/TemplateLivro.aspx?idLivro=" + Eval("IdLivro") %>' style="text-decoration: none; color: inherit;">
                    <div class="card">
                        <!-- Imagem da Capa -->
                        <img class="card-img" src='<%# ResolveUrl(Eval("UrlCapaLivro").ToString()) %>' alt="Capa do Livro" />
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>