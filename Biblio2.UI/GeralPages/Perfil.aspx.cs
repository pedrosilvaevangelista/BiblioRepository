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
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verifica se o nome do usuário está armazenado na sessão
                if (!string.IsNullOrEmpty(Biblio.BLL.Session.nomeUsuario))
                {
                    string nomeUsuario = Biblio.BLL.Session.nomeUsuario.ToUpper();
                    // Exibe o nome do usuário
                    LblSession1.Text = nomeUsuario;

                    // Verifica se o ID do usuário está definido na sessão
                    if (Biblio.BLL.Session.IdUsuario != 0)
                    {
                        int userId = Biblio.BLL.Session.IdUsuario;
                        UsuarioBLL userBLL = new UsuarioBLL();
                        UsuarioDTO usuario = userBLL.SearchByIdUsuarioBLL(userId);

                        if (usuario != null)
                        {
                            // Define a imagem de perfil utilizando a URL armazenada
                            imgPerfil2.ImageUrl = usuario.UrlFotoPerfil;
                            // Vincula os livros favoritos do usuário ao repeater
                            BindFavoritos(userId);
                        }
                        else
                        {
                            LblSession1.Text += " - Usuário não encontrado!";
                        }
                    }
                    else
                    {
                        LblSession1.Text += " - ID do usuário não encontrado na sessão!";
                    }
                }
                else
                {
                    LblSession1.Text = "Usuário não logado!";
                }
            }
        }

        private void BindFavoritos(int userId)
        {
            try
            {
                LivroFavoritoBLL favoritoBLL = new LivroFavoritoBLL();
                List<LivroFavoritoDTO> favoritos = favoritoBLL.GetLivroFavoritosBLL(userId);
                rptLivrosFavoritos.DataSource = favoritos;
                rptLivrosFavoritos.DataBind();
            }
            catch (Exception ex)
            {
                LblSession1.Text += " - Erro ao carregar favoritos: " + ex.Message;
            }
        }

        protected void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GeralPages/EditarPerfil.aspx");
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
    }
}