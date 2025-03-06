<%@ Page Title="" Language="C#" MasterPageFile="~/GeralPages/ManageUsers.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Biblio2.UI.GeralPages.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
         <link href="../css/inicio.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Sugestões de Livros</h1>
    <asp:Button ID="BtnRecarregarSugestoes" runat="server" Text="Recarregar sugestões" OnClick="BtnRecarregarSugestoes_Click" />

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
