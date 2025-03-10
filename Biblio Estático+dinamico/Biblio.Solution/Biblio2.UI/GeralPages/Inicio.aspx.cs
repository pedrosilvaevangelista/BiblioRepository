using Biblio2.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblio2.UI.GeralPages
{
    public partial class Inicio : System.Web.UI.Page
    {
        LivroBLL livroBLL = new LivroBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSugestoes();
            }
        }

        private void LoadSugestoes()
        {
            // Recupera todos os livros do banco
            var todosLivros = livroBLL.GetLivroBLL();

            if (todosLivros != null && todosLivros.Count > 0)
            {
                // Embaralha os livros e pega os 10 primeiros
                var livrosAleatorios = todosLivros.OrderBy(x => Guid.NewGuid()).Take(8).ToList();
                rptSugestoes.DataSource = livrosAleatorios;
                rptSugestoes.DataBind();
            }
        }

        protected void BtnRecarregarSugestoes_Click(object sender, EventArgs e)
        {
            // Recarrega a página para atualizar as sugestões
            Response.Redirect(Request.RawUrl);
        }
    }
}