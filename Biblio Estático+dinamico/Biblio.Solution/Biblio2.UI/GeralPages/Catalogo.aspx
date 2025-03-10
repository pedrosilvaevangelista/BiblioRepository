<%@ Page Title="" Language="C#" MasterPageFile="~/GeralPages/ManageUsers.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="Biblio2.UI.GeralPages.Catalogo" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
    <link href="../css/catalogo.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Catálogo 📖:</h1>

    <div class="page-container">
        <!-- Coluna dos Cards -->
        <div class="cards-section">
            <div class="card-container">
                <asp:Repeater ID="rptLivro" runat="server" OnItemCommand="rptLivro_ItemCommand">
                    <ItemTemplate>
                        <a href='<%# "../GeralPages/TemplateLivro.aspx?idLivro=" + Eval("IdLivro") %>' style="text-decoration: none; color: inherit;">
                            <div class="card">
                                <img class="card-img" src='<%# GetBookCoverUrl(Eval("UrlCapaLivro")) %>' alt="Capa do Livro" />
                            </div>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

        <!-- Coluna dos Filtros -->
        <div class="filters-section">
            <div class="filter-group">
                <asp:TextBox ID="txtNomeFiltro" runat="server" placeholder="Filtrar por nome" />
                <asp:Button ID="btnNomeFiltro" runat="server" Text="Filtrar" OnClick="btnNomeFiltro_Click" CssClass="btn-filtro" />
            </div>
            <div class="filter-group">
                <asp:DropDownList ID="ddlGenero" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlGenero_SelectedIndexChanged">
                    <asp:ListItem Text="Selecione um gênero" Value="" />
                </asp:DropDownList>
            </div>
            <div class="filter-group">
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" CssClass="btn-limpar" />
            </div>
        </div>
    </div>
</asp:Content>
