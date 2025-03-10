<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Biblio2.UI.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="./css/cadastro.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro de Usuário</title>
    <script src="../Scripts/Theme.js"></script>
    <script type="text/javascript">
        function previewImage(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    document.getElementById('imgPerfil').src = e.target.result; // Atualiza a imagem
                }
                reader.readAsDataURL(input.files[0]); // Lê o arquivo como URL de dados
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="formulario">
                <div class="navbar">
                     <img src="../img/logocomnomebiblio.png" alt="Logo" class="navbar-logo" />
                </div>
                <h1>Cadastro de Usuário</h1>
                <div class="form-group">
                    <asp:TextBox ID="txtNomeUsuario" MaxLength="150" placeholder="Nome" runat="server"></asp:TextBox>
                    <asp:Label ID="lblNomeUsuario" runat="server" Text="" CssClass="error-message"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtEmailUsuario" MaxLength="150" placeholder="Email" runat="server"></asp:TextBox>
                    <asp:Label ID="lblEmailUsuario" runat="server" Text="" CssClass="error-message"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtSenhaUsuario" MaxLength="8" placeholder="Senha" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="lblSenhaUsuario" runat="server" Text="" CssClass="error-message"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtConfirmarSenha" MaxLength="8" placeholder="Confirme a Senha" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="lblConfirmarSenha" runat="server" Text="" CssClass="error-message"></asp:Label>
                </div>
                <div class="form-group">
                    <label for="fupFotoPerfil" class="file-upload-label">
                        Selecione uma imagem de perfil
                        <asp:FileUpload ID="fupFotoPerfil" runat="server" onchange="previewImage(this)" />
                    </label>
                    <asp:Label ID="lblFupFotoPerfil" runat="server" Text="" CssClass="error-message"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:Image ID="imgPerfil" runat="server" Width="100" Height="100" CssClass="profile-image" />
                </div>
                <div class="form-group checkbox">
                    <asp:CheckBox ID="chkAutor" runat="server" />
                    <label for="chkAutor">Quero ser um autor</label>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" OnClick="btnCadastro_Click" CssClass="btn btn-primary" />
                </div>
                <div class="form-group">
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" CssClass="btn btn-secondary" />
                    <asp:Button ID="btnGoToLogin" runat="server" Text="Voltar para Login" OnClick="btnGoToLogin_Click" CssClass="btn btn-link" />
                </div>
                <div class="form-group">
                    <asp:Label ID="lblResult" runat="server" Text="" CssClass="result-message"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblMessage" runat="server" Text="" CssClass="result-message"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
