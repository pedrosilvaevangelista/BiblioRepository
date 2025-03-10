<%@ Page Title="" Language="C#" MasterPageFile="~/GeralPages/ManageUsers.Master" AutoEventWireup="true" CodeBehind="TemplateLivro.aspx.cs" Inherits="Biblio2.UI.GeralPages.TemplateLivro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/templateLivro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <!-- Banner do Usuário -->
        <asp:Image ID="imgBanner" runat="server" CssClass="user-banner" AlternateText="Banner do Usuário" />
        <div class="book-details">
            <h2>
                <asp:Label ID="lblTitulo" runat="server" />
            </h2>
            <asp:Image ID="imgCover" runat="server" CssClass="book-cover" AlternateText="Capa do Livro" /><br />
            <br />
            <p>
                <strong>Autor:</strong>
                <asp:Label ID="lblAutor" runat="server" />
            </p>
            <p>
                <strong>Gênero:</strong>
                <asp:Label ID="lblGenero" runat="server" />
            </p>
            <p>
                <strong>Data de Publicação:</strong>
                <asp:Label ID="lblDataPublicacao" runat="server" />
            </p>
            <p><strong>Sinopse:</strong></p>
            <p>
                <asp:Label ID="lblSinopse" runat="server" />
                <!-- Botões para manipulação dos favoritos -->
                <asp:Button ID="btnFavoritar" runat="server" Text="Adicionar aos Favoritos" OnClick="btnFavoritar_Click" CssClass="download-btn" Visible="false" />
                <asp:Button ID="btnRemoverFavorito" runat="server" Text="Remover dos Favoritos" OnClick="btnRemoverFavorito_Click" CssClass="download-btn" Visible="false" />
                <br />
                <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
            </p>
            <asp:HyperLink ID="hlDownloadPDF" runat="server" CssClass="download-btn" Target="_blank" Text="Baixar PDF" />
        </div>
    </div>
</asp:Content>
