using Biblio2.BLL;
using Biblio2.DTO;
using ExamePhobos.UI.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblio2.UI.GeralPages
{
    public partial class EditarPerfil : System.Web.UI.Page
    {
        private UsuarioBLL userBLL = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Biblio.BLL.Session.IdUsuario == 0)
                {
                    lblResult.Text = "Usuário não logado!";
                    Response.Redirect("../Login.aspx");
                    return;
                }

                int userId = Biblio.BLL.Session.IdUsuario;
                UsuarioDTO usuario = userBLL.SearchByIdUsuarioBLL(userId);

                if (usuario != null)
                {
                    txtNomeUsuario.Text = usuario.NomeUsuario;
                    txtEmailUsuario.Text = usuario.EmailUsuario;
                    // Os campos de senha permanecem vazios para evitar exposição dos dados
                    txtSenhaAtual.Text = string.Empty;
                    txtNovaSenha.Text = string.Empty;
                    imgPerfil.ImageUrl = usuario.UrlFotoPerfil;
                }
                else
                {
                    lblResult.Text = "Usuário não encontrado!";
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (!ValidaCampos())
                return;

            int userId = Biblio.BLL.Session.IdUsuario;
            UsuarioDTO usuarioAtual = userBLL.SearchByIdUsuarioBLL(userId);

            // Verifica se o usuário deseja alterar a senha
            string novaSenha;
            if (!string.IsNullOrWhiteSpace(txtNovaSenha.Text))
            {
                // Se estiver alterando a senha, a senha atual deve ser informada e validada
                if (string.IsNullOrWhiteSpace(txtSenhaAtual.Text))
                {
                    lblSenhaAtual.Text = "Para alterar a senha, informe sua senha atual.";
                    return;
                }
                if (txtSenhaAtual.Text.Trim() != usuarioAtual.SenhaUsuario)
                {
                    lblSenhaAtual.Text = "Senha atual inválida.";
                    return;
                }
                novaSenha = txtNovaSenha.Text.Trim();
            }
            else
            {
                // Se não for alterar a senha, mantém a senha atual
                novaSenha = usuarioAtual.SenhaUsuario;
            }

            // Cria o objeto com as informações atualizadas
            UsuarioDTO usuario = new UsuarioDTO
            {
                IdUsuario = userId,
                NomeUsuario = txtNomeUsuario.Text.Trim(),
                EmailUsuario = txtEmailUsuario.Text.Trim(),
                SenhaUsuario = novaSenha,
                UsuarioTipo = Biblio.BLL.Session.UsuarioTipo
            };

            // Processa o upload de imagem, se houver
            if (fupFotoPerfil.HasFile)
            {
                string fileName = Path.GetFileName(fupFotoPerfil.FileName);
                string filePath = Server.MapPath($"~/img/{fileName}");
                fupFotoPerfil.SaveAs(filePath);
                usuario.UrlFotoPerfil = $"~/img/{fileName}";
            }
            else
            {
                usuario.UrlFotoPerfil = usuarioAtual.UrlFotoPerfil;
            }

            // Atualiza os dados no banco
            userBLL.UpdateUsuarioBLL(usuario);

            lblResult.Text = "Perfil atualizado com sucesso! Você será deslogado para que as novas informações sejam carregadas.";

            // Realiza o logout para que as novas informações entrem em vigor
            Session.Clear();
            Session.Abandon();
            Response.Redirect("../Login.aspx");
        }

        /// <summary>
        /// Evento para exclusão da conta do usuário.
        /// </summary>
        protected void btnDeletarConta_Click(object sender, EventArgs e)
        {
            int userId = Biblio.BLL.Session.IdUsuario;
            try
            {
                // Chama o método do BLL para deletar o usuário (certifique-se de que esse método esteja implementado)
                userBLL.DeleteUsuarioBLL(userId);
                lblResult.Text = "Conta deletada com sucesso!";
                // Efetua logout e redireciona para a página de login
                Session.Clear();
                Session.Abandon();
                Response.Redirect("../Login.aspx");
            }
            catch (Exception ex)
            {
                lblResult.Text = "Erro ao deletar a conta: " + ex.Message;
            }
        }

        private bool ValidaCampos()
        {
            bool valid = true;

            // Limpa mensagens de validação anteriores
            lblNomeUsuario.Text = "";
            lblEmailUsuario.Text = "";
            lblSenhaAtual.Text = "";
            lblNovaSenha.Text = "";
            lblFupFotoPerfil.Text = "";

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                lblNomeUsuario.Text = "Nome é obrigatório.";
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailUsuario.Text))
            {
                lblEmailUsuario.Text = "Email é obrigatório.";
                valid = false;
            }

            // Se o usuário deseja alterar a senha (campo nova senha preenchido), a senha atual passa a ser obrigatória
            if (!string.IsNullOrWhiteSpace(txtNovaSenha.Text) && string.IsNullOrWhiteSpace(txtSenhaAtual.Text))
            {
                lblSenhaAtual.Text = "Informe sua senha atual para alterar a senha.";
                valid = false;
            }

            if (fupFotoPerfil.HasFile)
            {
                string fileExtension = Path.GetExtension(fupFotoPerfil.FileName).ToLower();
                string[] validExtensions = { ".jpg", ".jpeg", ".png" };

                if (!validExtensions.Contains(fileExtension))
                {
                    lblFupFotoPerfil.Text = "Selecione uma imagem válida (JPG ou PNG).";
                    valid = false;
                }
            }

            return valid;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
        }

        protected void sairdaconta_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("../Login.aspx");
        }
    }
}