<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarNovoLivro.aspx.cs" Inherits="Biblio2.UI.Author.AdicionarNovoLivro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../css/adicionarNovoLivro.css" rel="stylesheet" />
    <script src="../Scripts/Theme.js"></script>

    <script>
        // Função para pré-visualizar imagens
        function previewImage(input, imageId) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                var imgElement = document.getElementById(imageId);

                reader.onload = function (e) {
                    imgElement.src = e.target.result;
                    imgElement.style.display = 'block';
                };

                reader.onerror = function (error) {
                    console.error('Erro ao ler a imagem:', error);
                };

                reader.readAsDataURL(input.files[0]);
            } else {
                document.getElementById(imageId).src = '';
            }
        }

        // Limpar pré-visualizações ao clicar em Limpar
        document.getElementById('<%= btnLimpar.ClientID %>').onclick = function () {
            document.querySelectorAll('.preview-img').forEach(img => {
                img.src = '';
            });
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="formulario">
            <ul class="CadastroRequisicao">
                <li>
                    <h1>Cadastro de Livro</h1>
                </li>
                <li>
                    <asp:TextBox ID="txtTitulo" MaxLength="150" placeholder="Título:" runat="server"></asp:TextBox>
                    <asp:Label ID="lblTitulo" runat="server" Text="" ForeColor="Red" />
                </li>
                <li>
                    <asp:DropDownList ID="ddlGenero" runat="server">
                        <asp:ListItem Text="Selecione um gênero" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblGenero" runat="server" Text="" ForeColor="Red" />
                </li>
                <li>
                    <asp:TextBox ID="txtSinopse" MaxLength="150" placeholder="Sinopse:" TextMode="MultiLine" runat="server"></asp:TextBox>
                    <asp:Label ID="lblSinopse" runat="server" Text="" ForeColor="Red" />
                </li>
                <li>
                    <asp:TextBox ID="txtAutor" MaxLength="150" placeholder="Autor:" runat="server"></asp:TextBox>
                    <asp:Label ID="lblAutor" runat="server" Text="" ForeColor="Red" />
                </li>
                <!-- Campo de data de publicação removido, pois a data será definida automaticamente -->
                <li>
                    <asp:Label ID="lblImgCapa" runat="server" Text="Selecione a imagem de capa:" />
                </li>
                <li>
                    <asp:FileUpload ID="fupCapa" runat="server" onchange="previewImage(this, 'imgCapa')" />
                    <asp:Label ID="lblFupCapa" runat="server" Text="" ForeColor="Red" />
                </li>
                <li>
                    <asp:Image ID="imgCapa" runat="server" Width="200" Height="200" />
                </li>
                <li>
                    <asp:Label ID="lblImgIcon" runat="server" Text="Selecione a imagem do ícone:" />
                </li>
                <li>
                    <asp:FileUpload ID="fupIcon" runat="server" onchange="previewImage(this, 'imgIcon')" />
                    <asp:Label ID="lblFupIcon" runat="server" Text="" ForeColor="Red" />
                </li>
                <li>
                    <asp:Image ID="imgIcon" runat="server" Width="100" Height="100" />
                </li>
                <li>
                    <asp:Label ID="lblImgBanner" runat="server" Text="Selecione a imagem do banner:" />
                </li>
                <li>
                    <asp:FileUpload ID="fupBanner" runat="server" onchange="previewImage(this, 'imgBanner')" />
                    <asp:Label ID="lblFupBanner" runat="server" Text="" ForeColor="Red" />
                </li>
                <li>
                    <asp:Image ID="imgBanner" runat="server" Width="300" Height="150" />
                </li>
                <li>
                    <asp:Label ID="lblPDF" runat="server" Text="Selecione o arquivo PDF:" />
                </li>
                <li>
                    <asp:FileUpload ID="fupPDF" runat="server" />
                    <asp:Label ID="lblFupPDF" runat="server" Text="" ForeColor="Red" />
                </li>
                <li>
                    <asp:Button ID="btnCadastroRequisicao" runat="server" Text="Cadastrar" OnClick="btnCadastroRequisicao_Click" />
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                </li>
                <li>
                    <asp:Label ID="lblResult" runat="server" Text="" />
                </li>
            </ul>
        </div>
        <!-- Controlador de Tema no canto inferior direito -->
        <div class="theme-selector">
            <label for="ddlDarkMode">Tema:</label>
            <select id="ddlDarkMode" onchange="setTheme(this.value)">
                <option value="default">Padrão</option>
                <option value="light">Claro</option>
                <option value="dark">Escuro</option>
                <option value="contrast">Alto Contraste</option>
                <option value="miope">Visão Ampliada</option>
            </select>
        </div>
    </form>
</body>
</html>

