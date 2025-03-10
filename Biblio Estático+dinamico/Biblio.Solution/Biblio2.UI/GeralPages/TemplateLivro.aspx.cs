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
    public partial class TemplateLivro : System.Web.UI.Page
    {
        private LivroBLL livroBLL = new LivroBLL();
        private LivroFavoritoBLL favoritoBLL = new LivroFavoritoBLL();

        // Propriedade para capturar o idLivro da query string
        private int LivroId
        {
            get
            {
                int id;
                return int.TryParse(Request.QueryString["idLivro"], out id) ? id : 0;
            }
        }

        // Propriedade para verificar se o usuário está logado
        private bool IsUserLoggedIn => Biblio.BLL.Session.IdUsuario > 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (LivroId > 0)
                {
                    CarregarDetalhesLivro(LivroId);

                    if (IsUserLoggedIn)
                    {
                        bool isFavorito = favoritoBLL.IsLivroFavoritoBLL(Biblio.BLL.Session.IdUsuario, LivroId);
                        btnFavoritar.Visible = !isFavorito;
                        btnRemoverFavorito.Visible = isFavorito;
                    }
                }
                else
                {
                    Response.Write("Livro não encontrado.");
                }
            }
        }

        private void CarregarDetalhesLivro(int idLivro)
        {
            LivroDTO livro = livroBLL.SearchByIdLivroBLL(idLivro);
            if (livro != null)
            {
                lblTitulo.Text = livro.TituloLivro;
                lblAutor.Text = livro.AutorLivro;
                lblDataPublicacao.Text = livro.DataPublicacaoLivro.ToString("dd/MM/yyyy");
                lblSinopse.Text = livro.SinopseLivro;
                imgCover.ImageUrl = livro.UrlCapaLivro;

                // Converte o valor numérico para o nome do gênero
                var generos = livroBLL.GetGeneroLivroBLL();
                int idGenero;
                if (int.TryParse(livro.GeneroLivro, out idGenero))
                {
                    var generoEncontrado = generos.FirstOrDefault(g => g.IdGenero == idGenero);
                    lblGenero.Text = generoEncontrado != null ? generoEncontrado.DescricaoGenero : "Gênero não informado";
                }
                else
                {
                    lblGenero.Text = "Gênero não informado";
                }

                // Carrega o banner do livro, se disponível
                if (!string.IsNullOrEmpty(livro.UrlBannerLivro))
                {
                    imgBanner.ImageUrl = livro.UrlBannerLivro;
                }
                else
                {
                    imgBanner.Visible = false;
                }

                if (!string.IsNullOrEmpty(livro.UrlPDFLivro))
                {
                    hlDownloadPDF.NavigateUrl = livro.UrlPDFLivro;
                }
                else
                {
                    hlDownloadPDF.Visible = false;
                }
            }
            else
            {
                Response.Write("Detalhes do livro não encontrados.");
            }
        }

        protected void btnFavoritar_Click(object sender, EventArgs e)
        {
            if (LivroId <= 0)
            {
                ExibirMensagem("Livro inválido.", true);
                return;
            }

            if (!IsUserLoggedIn)
            {
                ExibirMensagem("Usuário não logado.", true);
                return;
            }

            int userId = Biblio.BLL.Session.IdUsuario;
            LivroFavoritoDTO favorito = new LivroFavoritoDTO
            {
                LivroId = LivroId,
                UsuarioId = userId
            };

            try
            {
                favoritoBLL.AddLivroFavoritoBLL(favorito);
                btnFavoritar.Visible = false;
                btnRemoverFavorito.Visible = true;
                Response.Redirect(Request.RawUrl);
                ExibirMensagem("Livro adicionado aos favoritos!", false);
            }
            catch (Exception ex)
            {
                ExibirMensagem("Erro ao adicionar aos favoritos: " + ex.Message, true);
            }
        }

        protected void btnRemoverFavorito_Click(object sender, EventArgs e)
        {
            if (LivroId <= 0)
            {
                ExibirMensagem("Livro inválido.", true);
                return;
            }

            if (!IsUserLoggedIn)
            {
                ExibirMensagem("Usuário não logado.", true);
                return;
            }

            int userId = Biblio.BLL.Session.IdUsuario;
            try
            {
                int idFavorito = favoritoBLL.GetIdFavoritoBLL(userId, LivroId);
                if (idFavorito > 0)
                {
                    favoritoBLL.DeleteLivroFavoritoBLL(idFavorito);
                    btnFavoritar.Visible = true;
                    btnRemoverFavorito.Visible = false;
                    Response.Redirect(Request.RawUrl);
                    ExibirMensagem("Livro removido dos favoritos!", false);
                }
                else
                {
                    ExibirMensagem("Livro não estava nos favoritos.", true);
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem("Erro ao remover dos favoritos: " + ex.Message, true);
            }
        }

        // Método auxiliar para exibir mensagens ao usuário
        private void ExibirMensagem(string mensagem, bool isError)
        {
            lblMessage.Text = mensagem;
            lblMessage.ForeColor = isError ? System.Drawing.Color.Red : System.Drawing.Color.Green;
        }
    }
}