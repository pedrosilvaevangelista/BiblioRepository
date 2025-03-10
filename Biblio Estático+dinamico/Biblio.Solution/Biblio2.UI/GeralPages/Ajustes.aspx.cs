using Biblio2.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblio2.UI.GeralPages
{
    public partial class Ajustes : System.Web.UI.Page
    {
        private UsuarioBLL userBLL = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GeralPages/EditarPerfil.aspx");
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }

        protected void btnSairConta_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("../Login.aspx");
        }

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
    }
}