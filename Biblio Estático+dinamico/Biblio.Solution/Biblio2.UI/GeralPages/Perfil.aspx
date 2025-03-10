<%@ Page Title="" Language="C#" MasterPageFile="~/GeralPages/ManageUsers.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Biblio2.UI.GeralPages.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/perfil.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="perfil-container">
        <!-- Cabeçalho do perfil: Imagem à esquerda, Nome ao lado -->
        <div class="perfil-header">
            <asp:Image ID="imgPerfil2" runat="server" CssClass="profile-img" AlternateText="Imagem do Perfil" />
            <div class="perfil-info">
                <asp:Label ID="LblSession1" runat="server" CssClass="perfil-nome" />
                <p class="perfil-descricao">Bem-vindo à sua biblioteca pessoal!</p>
            </div>
            <div class="acoes-perfil">
                <asp:Button ID="btnEditarPerfil" runat="server" CssClass="btn-perfil" Text="Editar Perfil" OnClick="btnEditarPerfil_Click" />
                <asp:Button ID="btnSair" runat="server" CssClass="btn-perfil sair" Text="Sair" OnClick="btnSair_Click" />
            </div>
        </div>
    </div>

    <!-- Repeater para exibir os livros favoritos -->
    <div class="favoritos-container">
        <h2>Meus Livros Favoritos</h2>
        <asp:Repeater ID="rptLivrosFavoritos" runat="server">
            <HeaderTemplate>
                <ul class="lista-livros">
            </HeaderTemplate>
            <ItemTemplate>
                <li class="livro-item">
                    <asp:Image ID="imgCapaLivro" runat="server" CssClass="book-cover"
                        ImageUrl='<%# Eval("UrlCapaLivro") %>' AlternateText="Capa do Livro" />
                    <div class="livro-info">
                        <strong class="titulo-livro"><%# Eval("TituloLivro") %></strong>
                        <span class="autor-livro"><%# Eval("AutorLivro") %></span>
                        <a href='<%# "../GeralPages/TemplateLivro.aspx?idLivro=" + Eval("LivroId") %>' class="detalhes-livro">Ver detalhes</a>
                    </div>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>