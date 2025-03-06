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
    public partial class frmLivros : Form
    {
        //Objetos globais
        LivroDTO livroDTO = new LivroDTO();
        LivroBLL livroBLL = new LivroBLL();

        public frmLivros()
        {
            InitializeComponent();
        }

        public void LoadCboxGeneroLivro()
        {
            cboxGeneroLivro.Items.Clear();
            cboxGeneroLivro.DisplayMember = "DescricaoGenero";
            cboxGeneroLivro.ValueMember = "IdGenero";
            cboxGeneroLivro.DataSource = livroBLL.GetGeneroLivroBLL();
            cboxGeneroLivro.SelectedIndex = -1;
        }

        private void LoadDgvLivro()
        {
            dgvLivro.DataSource = livroBLL.GetLivroBLL();

            dgvLivro.Columns["IdLivro"].HeaderText = "ID";
            dgvLivro.Columns["TituloLivro"].HeaderText = "Título";
            dgvLivro.Columns["GeneroLivro"].HeaderText = "Gênero";
            dgvLivro.Columns["SinopseLivro"].HeaderText = "Sinopse";
            dgvLivro.Columns["AutorLivro"].HeaderText = "AutorLivro";
            dgvLivro.Columns["DataPublicacaoLivro"].HeaderText = "Data de Publicação";
            dgvLivro.Columns["UrlCapaLivro"].HeaderText = "Capa";
            dgvLivro.Columns["UrlIconLivro"].HeaderText = "Ícone";
            dgvLivro.Columns["UrlBannerLivro"].HeaderText = "Banner";
            dgvLivro.Columns["UrlPDFLivro"].HeaderText = "PDF";
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            LoadDgvLivro();
        }



        private void btnUrlCapaLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione a capa do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Caminho da imagem selecionada
                string caminhoImagem = ofd.FileName;

                //Exibe a imagem no PictureBox
                pbUrlCapaLivro.Image = Image.FromFile(caminhoImagem);

                //Salvao o caminho da imagem no TextBox
                txtUrlCapaLivro.Text = caminhoImagem;
            }
        }

        private void btnUrlBannerLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione o banner do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Caminho da imagem selecionada
                string caminhoImagem = ofd.FileName;

                //Exibe a imagem no PictureBox
                pbUrlBannerLivro.Image = Image.FromFile(caminhoImagem);

                //Salvao o caminho da imagem no TextBox
                txtUrlBannerLivro.Text = caminhoImagem;
            }
        }

        private void btnUrlIconLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione o ícone do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Caminho da imagem selecionada
                string caminhoImagem = ofd.FileName;

                //Exibe a imagem no PictureBox
                pbUrlIconLivro.Image = Image.FromFile(caminhoImagem);

                //Salvao o caminho da imagem no TextBox
                txtUrlIconLivro.Text = caminhoImagem;
            }
        }

        private void btnUrlPDFLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.pdf;";
            ofd.Title = "Selecione o PDF do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Caminho da imagem selecionada
                string caminhoImagem = ofd.FileName;

                //Salvao o caminho da imagem no TextBox
                txtUrlPDFLivro.Text = caminhoImagem;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            livroDTO.TituloLivro = txtTituloLivro.Text;
            livroDTO.GeneroLivro = cboxGeneroLivro.SelectedValue.ToString();
            livroDTO.SinopseLivro = txtSinopseLivro.Text;
            livroDTO.AutorLivro = txtAutorLivro.Text;
            livroDTO.DataPublicacaoLivro = DateTime.Parse(txtDataPublicacaoLivro.Text);
            livroDTO.UrlCapaLivro = txtUrlCapaLivro.Text;
            livroDTO.UrlIconLivro = txtUrlIconLivro.Text;
            livroDTO.UrlBannerLivro = txtUrlBannerLivro.Text;
            livroDTO.UrlPDFLivro = txtUrlPDFLivro.Text;

            livroBLL.CreateLivroBLL(livroDTO);

            LoadDgvLivro();

            MessageBox.Show($"Livro {livroDTO.TituloLivro.ToUpper()} cadastrado com sucesso!!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            livroDTO.TituloLivro = txtTituloLivro.Text;
            livroDTO.GeneroLivro = cboxGeneroLivro.SelectedValue.ToString();
            livroDTO.SinopseLivro = txtSinopseLivro.Text;
            livroDTO.AutorLivro = txtAutorLivro.Text;
            livroDTO.DataPublicacaoLivro = DateTime.Parse(txtDataPublicacaoLivro.Text);
            livroDTO.UrlCapaLivro = txtUrlCapaLivro.Text;
            livroDTO.UrlIconLivro = txtUrlIconLivro.Text;
            livroDTO.UrlBannerLivro = txtUrlBannerLivro.Text;
            livroDTO.UrlPDFLivro = txtUrlPDFLivro.Text;

            livroDTO.IdLivro = int.Parse(txtIdLivro.Text);

            livroBLL.UpdateLivroBLL(livroDTO);

            LoadDgvLivro();

            MessageBox.Show($"Livro {livroDTO.TituloLivro.ToUpper()} editado com sucesso !!");
        }
    }
}
