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

namespace Biblio2.UI.Author
{
    public partial class AdicionarNovoLivro : System.Web.UI.Page
    {
        LivroRequisicaoDTO livroRequisicaoDTO = new LivroRequisicaoDTO();
        LivroRequisicaoBLL livroRequisicaoBLL = new LivroRequisicaoBLL();
        LivroBLL livroBLL = new LivroBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGeneros();
                // A data de publicação não é mais um campo selecionável, será definida automaticamente.
            }
        }

        private void CarregarGeneros()
        {
            var generos = livroBLL.GetGeneroLivroBLL();
            ddlGenero.DataSource = generos;
            ddlGenero.DataTextField = "DescricaoGenero";
            ddlGenero.DataValueField = "IdGenero";
            ddlGenero.DataBind();
            ddlGenero.Items.Insert(0, new ListItem("Selecione um gênero", ""));
        }

        protected void btnCadastroRequisicao_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                livroRequisicaoDTO.TituloLivroRequisicao = txtTitulo.Text.Trim();
                livroRequisicaoDTO.GeneroLivroRequisicao = ddlGenero.SelectedValue;
                livroRequisicaoDTO.SinopseLivroRequisicao = txtSinopse.Text.Trim();
                livroRequisicaoDTO.AutorLivroRequisicao = txtAutor.Text.Trim();
                // Atribuição da data de publicação como data atual
                livroRequisicaoDTO.DataPublicacaoLivroRequisicao = DateTime.Now;

                // Upload da imagem de capa
                if (fupCapa.HasFile)
                {
                    string fileName = Path.GetFileName(fupCapa.FileName);
                    string filePath = Server.MapPath($"~/img/ImagensLivroRequisicao/{fileName}");
                    fupCapa.SaveAs(filePath);
                    livroRequisicaoDTO.UrlCapaLivroRequisicao = $"~/img/ImagensLivroRequisicao/{fileName}";
                }
                else
                {
                    livroRequisicaoDTO.UrlCapaLivroRequisicao = "~/img/ImagensLivroRequisicao/DefaultCapa.jpg";
                }

                // Upload do ícone
                if (fupIcon.HasFile)
                {
                    string fileName = Path.GetFileName(fupIcon.FileName);
                    string filePath = Server.MapPath($"~/img/ImagensLivroRequisicao/{fileName}");
                    fupIcon.SaveAs(filePath);
                    livroRequisicaoDTO.UrlIconLivroRequisicao = $"~/img/ImagensLivroRequisicao/{fileName}";
                }
                else
                {
                    livroRequisicaoDTO.UrlIconLivroRequisicao = "~/img/ImagensLivroRequisicao/DefaultIcon.jpg";
                }

                // Upload do banner
                if (fupBanner.HasFile)
                {
                    string fileName = Path.GetFileName(fupBanner.FileName);
                    string filePath = Server.MapPath($"~/img/ImagensLivroRequisicao/{fileName}");
                    fupBanner.SaveAs(filePath);
                    livroRequisicaoDTO.UrlBannerLivroRequisicao = $"~/img/ImagensLivroRequisicao/{fileName}";
                }
                else
                {
                    livroRequisicaoDTO.UrlBannerLivroRequisicao = null;
                }

                // Upload do PDF
                if (fupPDF.HasFile)
                {
                    string fileName = Path.GetFileName(fupPDF.FileName);
                    string filePath = Server.MapPath($"~/pdf/ArquivoLivroRequisicao/{fileName}");
                    fupPDF.SaveAs(filePath);
                    livroRequisicaoDTO.UrlPDFLivroRequisicao = $"~/pdf/ArquivoLivroRequisicao/{fileName}";
                }
                else
                {
                    livroRequisicaoDTO.UrlPDFLivroRequisicao = "";
                }

                livroRequisicaoBLL.CreateLivroRequisicaoBLL(livroRequisicaoDTO);

                Clear.ClearControl(this);
                txtTitulo.Focus();
                lblResult.Text = $"Livro '{livroRequisicaoDTO.TituloLivroRequisicao.ToUpper()}' requisitado com sucesso!";
            }
        }

        private bool ValidaCampos()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                lblTitulo.Text = "Título é obrigatório.";
                valid = false;
            }

            if (string.IsNullOrEmpty(ddlGenero.SelectedValue))
            {
                lblGenero.Text = "Gênero é obrigatório.";
                valid = false;
            }

            if (string.IsNullOrEmpty(txtSinopse.Text))
            {
                lblSinopse.Text = "Sinopse é obrigatória.";
                valid = false;
            }

            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                lblAutor.Text = "Autor é obrigatório.";
                valid = false;
            }

            return valid;
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
        }
    }
}