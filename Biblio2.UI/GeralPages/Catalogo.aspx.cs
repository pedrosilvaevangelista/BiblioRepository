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
    public partial class Catalogo : System.Web.UI.Page
    {
        private UsuarioBLL _userBLL = new UsuarioBLL();
        private LivroBLL _livroBLL = new LivroBLL();
        private LivroDTO _livroDTO = new LivroDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGeneros();
                LoadLivroRepeater();
            }
        }
     
        /// Carrega os gêneros disponíveis no DropDownList.
        private void LoadGeneros()
        {
            var generos = _livroBLL.GetGeneroLivroBLL();
            ddlGenero.DataSource = generos;
            ddlGenero.DataTextField = "DescricaoGenero";
            ddlGenero.DataValueField = "IdGenero";
            ddlGenero.DataBind();
            ddlGenero.Items.Insert(0, new ListItem("Selecione um gênero", ""));
        }

        /// Carrega o repeater com a lista de livros.
        public void LoadLivroRepeater()
        {
            rptLivro.DataSource = _livroBLL.GetLivroBLL();
            rptLivro.DataBind();
        }

        /// Método auxiliar que verifica e formata o caminho da imagem do livro.
        /// Se o caminho não estiver no formato esperado (iniciando com "~/", "http://", ou "https://"), 
        /// ele adiciona "~/", garantindo que o ResolveUrl processe corretamente.
        public string GetBookCoverUrl(object url)
        {
            if (url == null)
                return string.Empty;

            string urlStr = url.ToString().Trim();
            // Verifica se o caminho não é absoluto nem já está formatado
            if (!urlStr.StartsWith("~/") && !urlStr.StartsWith("http://") && !urlStr.StartsWith("https://"))
            {
                urlStr = "~/" + urlStr.TrimStart('/');
            }
            return ResolveUrl(urlStr);
        }

        /// Filtra os livros pelo gênero selecionado.
        private void FilterLivrosByGenero()
        {
            string generoSelecionado = ddlGenero.SelectedValue;
            if (!string.IsNullOrEmpty(generoSelecionado))
            {
                var livrosFiltrados = _livroBLL.FilterByGeneroBLL(generoSelecionado);
                rptLivro.DataSource = livrosFiltrados;
                rptLivro.DataBind();
            }
            else
            {
                LoadLivroRepeater();
            }
        }

        protected void rptLivro_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int idLivro = int.Parse(e.CommandArgument.ToString());
                var livroSelecionado = _livroBLL.SearchByIdLivroBLL(idLivro);
            }
        }
        protected void ddlGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLivrosByGenero();
        }

        protected void btnNomeFiltro_Click(object sender, EventArgs e)
        {
            string nomeFiltro = txtNomeFiltro.Text.Trim();
            if (!string.IsNullOrEmpty(nomeFiltro))
            {
                var livrosFiltrados = _livroBLL.GetLivroBLL()
                    .Where(l => l.TituloLivro.IndexOf(nomeFiltro, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
                rptLivro.DataSource = livrosFiltrados;
                rptLivro.DataBind();
            }
            else
            {
                LoadLivroRepeater();
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFiltro.Text = string.Empty;
            LoadLivroRepeater();
        }
    }
}