using Biblio2.BLL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio2.Desktop
{
    public partial class frmLogin: Form
    {
        UsuarioBLL userBLL = new UsuarioBLL();
        UsuarioDTO userDTO = new UsuarioDTO();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear(); // Limpa as TextBox
                }
                else if (ctrl is Label label && label.ForeColor == Color.Red)
                {
                    label.Text = ""; // Limpa apenas Labels vermelhas
                }
            }

            lblResult.Visible = false;
        }

        private bool ValidaPageLogin()
        {
            string msg = "Preencha o campo";

            bool valid;

            if (string.IsNullOrEmpty(txtNomeUsuario.Text))
            {
                lblNomeUsuarioErro.Text = msg;

                lblSenhaUsuarioErro.Text = string.Empty;

                txtNomeUsuario.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtSenhaUsuario.Text))
            {
                lblSenhaUsuarioErro.Text = msg;

                lblNomeUsuarioErro.Text = string.Empty;

                txtSenhaUsuario.Focus();
                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidaPageLogin())
            {
                userDTO = userBLL.AuthenticateUsuarioBLL(txtNomeUsuario.Text, txtSenhaUsuario.Text);

                if (userDTO.UsuarioTipo == "1")
                {
                    mdiAdministrador mdi = new mdiAdministrador();

                    mdi.Show();

                    this.Hide();
                }
                else
                {
                    lblResult.Visible = true;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
