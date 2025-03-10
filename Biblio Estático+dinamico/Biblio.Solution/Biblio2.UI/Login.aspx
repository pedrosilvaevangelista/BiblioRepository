<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ExamePhobos.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="./css/login.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/Style.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <img src="../img/logocomnomebiblio.png" alt="Logo" class="navbar-logo" />
        </div>
        <ul class="Login">
            <li>
                <h1>Autenticação</h1>
            </li>
            <li>
                <asp:TextBox ID="txtNome" runat="server" Placeholder="Nome:" MaxLength="150"></asp:TextBox>
            </li>
            <li>
                <asp:TextBox ID="txtSenha" runat="server" Placeholder="Senha:" MaxLength="8"></asp:TextBox>
            </li>
            <li>
                <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            </li>
            <li>
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </li>
            <li>
                <asp:Button ID="BtnCadastro" runat="server" Text="Cadastrar-se" OnClick="BtnCadastro_Click" />
            </li>
        </ul>
    </form>
</body>
</html>
