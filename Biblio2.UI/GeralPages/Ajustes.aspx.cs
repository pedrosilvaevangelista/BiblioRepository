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
    }
}