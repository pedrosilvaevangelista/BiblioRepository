using Biblio2.BLL;
using Biblio2.DTO;
using ExamePhobos.UI.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblio2.UI
{
    public partial class Cadastro : System.Web.UI.Page
    {

        UsuarioBLL _userBLL = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Inicializações necessárias (se houver)
            }
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            LimparMensagens();

            if (!CamposValidos())
                return;

            string nomeUsuario = txtNomeUsuario.Text.Trim();

            if (_userBLL.VerificaUsuarioExistenteBLL(nomeUsuario))
            {
                lblResult.Text = "Erro: Já existe um usuário com esse nome.";
                return;
            }

            var novoUsuario = CriarUsuarioDTO();

            try
            {
                _userBLL.CreateUsuarioBLL(novoUsuario);
                LimparCampos();
                lblResult.Text = $"Usuário {novoUsuario.NomeUsuario.ToUpper()} cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Erro ao cadastrar usuário: " + ex.Message;
            }
        }

        private UsuarioDTO CriarUsuarioDTO()
        {
            return new UsuarioDTO
            {
                NomeUsuario = txtNomeUsuario.Text.Trim(),
                EmailUsuario = txtEmailUsuario.Text.Trim(),
                SenhaUsuario = txtSenhaUsuario.Text.Trim(),
                UsuarioTipo = chkAutor.Checked ? "2" : "3",
                UrlFotoPerfil = ProcessarUploadImagem()
            };
        }

        private string ProcessarUploadImagem()
        {
            if (fupFotoPerfil.HasFile)
            {
                string fileName = Path.GetFileName(fupFotoPerfil.FileName);
                string filePath = Server.MapPath($"~/img/FotoPerfilUsuario/{fileName}");

                try
                {
                    fupFotoPerfil.SaveAs(filePath);
                    return $"~/img/FotoPerfilUsuario/{fileName}";
                }
                catch (Exception ex)
                {
                    lblFupFotoPerfil.Text = "Erro ao salvar a imagem: " + ex.Message;
                    return "~/img/FotoPerfilUsuario/FotoPerfilDefault.jpg"; // Retorna imagem padrão em caso de erro
                }
            }
            return "~/img/FotoPerfilUsuario/FotoPerfilDefault.jpg";
        }

        private bool CamposValidos()
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                lblNomeUsuario.Text = "Nome é obrigatório.";
                valid = false;
            }

            // Validação de e-mail
            if (string.IsNullOrWhiteSpace(txtEmailUsuario.Text) || !Regex.IsMatch(txtEmailUsuario.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailUsuario.Text = "Email inválido.";
                valid = false;
            }

            // Validação de senha
            if (string.IsNullOrWhiteSpace(txtSenhaUsuario.Text) || txtSenhaUsuario.Text.Length < 6)
            {
                lblSenhaUsuario.Text = "A senha deve ter pelo menos 6 caracteres.";
                valid = false;
            }

            // Validação de confirmação de senha
            if (txtSenhaUsuario.Text != txtConfirmarSenha.Text)
            {
                lblConfirmarSenha.Text = "As senhas não coincidem.";
                valid = false;
            }

            // Validação da imagem
            if (fupFotoPerfil.HasFile)
            {
                string fileExtension = Path.GetExtension(fupFotoPerfil.FileName).ToLower();
                string[] extensoesValidas = { ".jpg", ".jpeg", ".png" };

                if (!extensoesValidas.Contains(fileExtension))
                {
                    lblFupFotoPerfil.Text = "Por favor, selecione uma imagem válida (JPG ou PNG).";
                    valid = false;
                }
            }

            return valid;
        }

        private void LimparMensagens()
        {
            lblNomeUsuario.Text = string.Empty;
            lblEmailUsuario.Text = string.Empty;
            lblSenhaUsuario.Text = string.Empty;
            lblConfirmarSenha.Text = string.Empty; // Limpa a mensagem de confirmação de senha
            lblFupFotoPerfil.Text = string.Empty;
            lblResult.Text = string.Empty;
        }

        private void LimparCampos()
        {
            Clear.ClearControl(this);
            txtNomeUsuario.Focus();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        protected void btnGoToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}