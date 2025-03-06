using Biblio2.BLL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblio2.UI.GeralPages
{
    public partial class ManageUsers : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Se o tipo do usuário estiver salvo na sessão e for "2" (Autor), exibe o link
                if (!string.IsNullOrEmpty(Biblio.BLL.Session.UsuarioTipo) && Biblio.BLL.Session.UsuarioTipo == "2")
                {
                    addlivro.Visible = true;
                }
                else
                {
                    addlivro.Visible = false;
                }
                ExibirInformacoesUsuario();
            }
        }

        private void ExibirInformacoesUsuario()
        {
            // Verifica se o usuário está logado
            if (string.IsNullOrEmpty(Biblio.BLL.Session.nomeUsuario))
            {
                LblSession.Text = "Usuário não logado!";
                return;
            }

            string nomeUsuario = Biblio.BLL.Session.nomeUsuario.ToUpper();
            LblSession.Text = nomeUsuario;

            // Verifica se o ID do usuário foi definido na sessão
            if (Biblio.BLL.Session.IdUsuario == 0)
            {
                LblSession.Text += " - ID do usuário não encontrado na sessão!";
                return;
            }

            int userId = Biblio.BLL.Session.IdUsuario;
            UsuarioBLL userBLL = new UsuarioBLL();
            UsuarioDTO usuario = userBLL.SearchByIdUsuarioBLL(userId);

            if (usuario == null)
            {
                LblSession.Text += " - Usuário não encontrado!";
                return;
            }

            // Atualiza a imagem de perfil e exibe os livros favoritos
            imgPerfil.ImageUrl = usuario.UrlFotoPerfil;
            BindFavoritosIcon(userId);
        }

        // Método auxiliar para vincular os livros favoritos
        private void BindFavoritosIcon(int userId)
        {
            try
            {
                LivroFavoritoBLL favoritoBLL = new LivroFavoritoBLL();
                var favoritos = favoritoBLL.GetLivroFavoritosBLL(userId);
                rptFavoritosIcon.DataSource = favoritos;
                rptFavoritosIcon.DataBind();
            }
            catch (Exception ex)
            {
                LblSession.Text += " - Erro ao carregar favoritos: " + ex.Message;
            }
        }
    }
}