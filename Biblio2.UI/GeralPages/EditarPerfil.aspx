<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="Biblio2.UI.GeralPages.EditarPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Editar Perfil</title>
    <link href="../css/editarPerfil.css" rel="stylesheet" />
    <script src="../Scripts/Theme.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Editar Perfil</h1>
            <asp:TextBox ID="txtNomeUsuario" MaxLength="150" placeholder="Nome:" runat="server"></asp:TextBox>
            <asp:Label ID="lblNomeUsuario" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:TextBox ID="txtEmailUsuario" MaxLength="150" placeholder="Email:" runat="server"></asp:TextBox>
            <asp:Label ID="lblEmailUsuario" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <!-- Estes campos de senha são opcionais -->
            <!-- Se o usuário deseja alterar a senha, deve informar a senha atual -->
            <asp:TextBox ID="txtSenhaAtual" MaxLength="50" placeholder="Senha Atual (somente se alterar a senha):" TextMode="Password" runat="server"></asp:TextBox>
            <asp:Label ID="lblSenhaAtual" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <!-- Campo para nova senha (opcional) -->
            <asp:TextBox ID="txtNovaSenha" MaxLength="50" placeholder="Nova Senha (opcional):" TextMode="Password" runat="server"></asp:TextBox>
            <asp:Label ID="lblNovaSenha" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:FileUpload ID="fupFotoPerfil" runat="server" />
            <asp:Label ID="lblFupFotoPerfil" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Image ID="imgPerfil" runat="server" Width="200" Height="200" AlternateText="Foto de Perfil" />
            <br />

            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            <asp:Button ID="btnSairConta" runat="server" Text="Sair Da Conta" OnClick="sairdaconta_Click" />
            <!-- Novo botão para exclusão da conta, com confirmação -->
            <asp:Button ID="btnDeletarConta" runat="server" Text="Excluir Conta"
                OnClick="btnDeletarConta_Click"
                OnClientClick="return confirm('Você tem certeza que deseja deletar sua conta? Essa ação não pode ser desfeita.');"
                CssClass="delete-btn" />
            <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
