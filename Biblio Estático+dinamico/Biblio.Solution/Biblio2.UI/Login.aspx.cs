using Biblio2.BLL;
using Biblio2.DTO;
using ExamePhobos.UI;
using ExamePhobos.UI.Utilities;
using System;

namespace ExamePhobos.UI
{
    public partial class Login : System.Web.UI.Page
    {
        UsuarioDTO user = new UsuarioDTO();
        UsuarioBLL userBLL = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Inicialização, caso necessário
                lblResult.Text = "Bem-vindo à nossa aplicação!";
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text.Trim();

            user = userBLL.AuthenticateUsuarioBLL(nome, senha);

            if (user != null)
            {
                // Armazenar informações do usuário na sessão
                Biblio.BLL.Session.nomeUsuario = user.NomeUsuario.Trim();
                Biblio.BLL.Session.IdUsuario = user.IdUsuario;
                Biblio.BLL.Session.UsuarioTipo = user.UsuarioTipo;

                // Redirecionamento com base no tipo de usuário
                switch (user.UsuarioTipo)
                {
                    case "1":  // Admin
                        lblResult.Text = "Usuário Admin. Acesso restrito.";
                        break;

                    case "2":  // Autor
                        Response.Redirect("/GeralPages/Catalogo.aspx");
                        break;

                    case "3":  // Usuário Comum
                        Response.Redirect("/GeralPages/Catalogo.aspx");
                        break;

                    default:
                        Clear.ClearControl(this);
                        txtNome.Focus();
                        lblResult.Text = "Tipo de usuário não reconhecido.";
                        break;
                }
            }
            else
            {
                Clear.ClearControl(this);
                txtNome.Focus();
                lblResult.Text = $"Usuário {nome.ToUpper()} não cadastrado.";
            }
        }

        // Ação de cancelar (limpar campos)
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            txtNome.Focus();
        }

        // Ação para redirecionar para a página de cadastro
        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }
    }
}