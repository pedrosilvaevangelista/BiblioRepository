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
    public partial class mdiAdministrador : Form
    {
        //Objetos auxiliares
        private Form formAtivo = null; // Adicionado para controlar o formulário ativo

        public mdiAdministrador()
        {
            InitializeComponent();
        }

        private void mdiAdministrador_Load(object sender, EventArgs e)
        {
            // Obtém a área de trabalho disponível (sem a barra de tarefas)
            Rectangle tamanhoTela = Screen.PrimaryScreen.WorkingArea;

            // Define a posição e o tamanho do formulário
            this.Location = new Point(tamanhoTela.X, tamanhoTela.Y);
            this.Size = new Size(tamanhoTela.Width, tamanhoTela.Height);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Se o formulário ativo for o mesmo, não abre outro
            if (formAtivo is frmUsuarios)
                return;

            // Fecha o formulário ativo antes de abrir um novo
            formAtivo?.Close();

            frmUsuarios usuarios = new frmUsuarios();

            Rectangle tamanhoTela = Screen.PrimaryScreen.WorkingArea;
            int larguraMenuEsquerda = 252;

            usuarios.Size = new Size(tamanhoTela.Width - larguraMenuEsquerda, tamanhoTela.Height);
            usuarios.Location = new Point(larguraMenuEsquerda, 0);

            formAtivo = usuarios; // Atualiza o formulário ativo
            usuarios.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            if (formAtivo is frmLivros)
                return;

            formAtivo?.Close();

            frmLivros livros = new frmLivros();

            Rectangle tamanhoTela = Screen.PrimaryScreen.WorkingArea;
            int larguraMenuEsquerda = 252;

            livros.Size = new Size(tamanhoTela.Width - larguraMenuEsquerda, tamanhoTela.Height);
            livros.Location = new Point(larguraMenuEsquerda, 0);

            formAtivo = livros;
            livros.Show();
        }

        private void btnRequisicoes_Click(object sender, EventArgs e)
        {
            if (formAtivo is frmLivrosRequisicao)
                return;

            formAtivo?.Close();

            frmLivrosRequisicao livrosRequisicao = new frmLivrosRequisicao();

            Rectangle tamanhoTela = Screen.PrimaryScreen.WorkingArea;
            int larguraMenuEsquerda = 252;

            livrosRequisicao.Size = new Size(tamanhoTela.Width - larguraMenuEsquerda, tamanhoTela.Height);
            livrosRequisicao.Location = new Point(larguraMenuEsquerda, 0);

            formAtivo = livrosRequisicao;
            livrosRequisicao.Show();
        }
    }
}
