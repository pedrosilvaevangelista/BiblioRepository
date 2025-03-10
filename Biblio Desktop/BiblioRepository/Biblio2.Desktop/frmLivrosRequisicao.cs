using Biblio2.BLL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio2.Desktop
{
    public partial class frmLivrosRequisicao : Form
    {
        //Objetos globais
        LivroRequisicaoDTO livroRequisicaoDTO = new LivroRequisicaoDTO();
        LivroRequisicaoBLL livroRequisicaoBLL = new LivroRequisicaoBLL();

        bool dgvLivroRequisicao_CellMouseClick_Ativo = true;

        public frmLivrosRequisicao()
        {
            InitializeComponent();
        }

        public void LoadCboxGeneroLivroRequisicao()
        {
            cboxGeneroLivroRequisicao.Items.Clear();
            cboxGeneroLivroRequisicao.DisplayMember = "DescricaoGenero";
            cboxGeneroLivroRequisicao.ValueMember = "IdGenero";
            cboxGeneroLivroRequisicao.DataSource = livroRequisicaoBLL.GetGeneroLivroRequisicaoBLL();
            cboxGeneroLivroRequisicao.SelectedIndex = -1;
        }

        private void LoadDgvLivroRequisicao()
        {
            dgvLivroRequisicao.DataSource = livroRequisicaoBLL.GetLivroRequisicaoBLL();

            // Configuração das colunas
            dgvLivroRequisicao.Columns["IdLivroRequisicao"].HeaderText = "ID";
            dgvLivroRequisicao.Columns["TituloLivroRequisicao"].HeaderText = "Título";
            dgvLivroRequisicao.Columns["GeneroLivroRequisicao"].HeaderText = "Gênero";
            dgvLivroRequisicao.Columns["SinopseLivroRequisicao"].HeaderText = "Sinopse";
            dgvLivroRequisicao.Columns["AutorLivroRequisicao"].HeaderText = "Autor";
            dgvLivroRequisicao.Columns["DataPublicacaoLivroRequisicao"].HeaderText = "Data de Publicação";
            dgvLivroRequisicao.Columns["UrlCapaLivroRequisicao"].HeaderText = "Capa";
            dgvLivroRequisicao.Columns["UrlIconLivroRequisicao"].HeaderText = "Ícone";
            dgvLivroRequisicao.Columns["UrlBannerLivroRequisicao"].HeaderText = "Banner";
            dgvLivroRequisicao.Columns["UrlPDFLivroRequisicao"].HeaderText = "PDF";

            //ADICIONAR MAIS
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
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Remove a seleção da ComboBox
                }
                else if (ctrl is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear(); // Limpa as MaskedTextBox
                }
            }
        }

        private void frmLivrosRequisicao_Load(object sender, EventArgs e)
        {
            LoadDgvLivroRequisicao();
            LoadCboxGeneroLivroRequisicao();
            lblIdLivroRequisicaoErro.Text = string.Empty;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdLivroRequisicao.Text))
            {
                lblIdLivroRequisicaoErro.Text = "Preencha o campo";
                return;
            }

            int idLivroRequisicao = int.Parse(txtIdLivroRequisicao.Text.Trim());
            livroRequisicaoDTO = livroRequisicaoBLL.SearchByIdLivroRequisicaoBLL(idLivroRequisicao);

            txtIdLivroRequisicao.Text = livroRequisicaoDTO.IdLivroRequisicao.ToString(); //Desnessário, mas está aí só por estar
            txtTituloLivroRequisicao.Text = livroRequisicaoDTO.TituloLivroRequisicao;

            switch (livroRequisicaoDTO.GeneroLivroRequisicao)
            {
                case "1":
                    cboxGeneroLivroRequisicao.Text = "Ficção Científica";
                    break;
                case "2":
                    cboxGeneroLivroRequisicao.Text = "Fantasia";
                    break;
                case "3":
                    cboxGeneroLivroRequisicao.Text = "Romance";
                    break;
                case "4":
                    cboxGeneroLivroRequisicao.Text = "Terror";
                    break;
                case "5":
                    cboxGeneroLivroRequisicao.Text = "Mistério";
                    break;
                case "6":
                    cboxGeneroLivroRequisicao.Text = "Aventura";
                    break;
                case "7":
                    cboxGeneroLivroRequisicao.Text = "Ciência";
                    break;
                case "8":
                    cboxGeneroLivroRequisicao.Text = "Tecnologia";
                    break;
                case "9":
                    cboxGeneroLivroRequisicao.Text = "Suspense";
                    break;
                case "10":
                    cboxGeneroLivroRequisicao.Text = "Drama";
                    break;
                case "11":
                    cboxGeneroLivroRequisicao.Text = "Biografia";
                    break;
                case "12":
                    cboxGeneroLivroRequisicao.Text = "História";
                    break;
                case "13":
                    cboxGeneroLivroRequisicao.Text = "Autoajuda";
                    break;
                case "14":
                    cboxGeneroLivroRequisicao.Text = "Filosofia";
                    break;
                case "15":
                    cboxGeneroLivroRequisicao.Text = "Psicologia";
                    break;
            }

            txtSinopseLivroRequisicao.Text = livroRequisicaoDTO.SinopseLivroRequisicao;
            txtAutorLivroRequisicao.Text = livroRequisicaoDTO.AutorLivroRequisicao;
            txtDataPublicacaoLivroRequisicao.Text = livroRequisicaoDTO.DataPublicacaoLivroRequisicao.ToString("dd/MM/yyyy");
            txtUrlCapaLivroRequisicao.Text = livroRequisicaoDTO.UrlCapaLivroRequisicao;
            txtUrlIconLivroRequisicao.Text = livroRequisicaoDTO.UrlIconLivroRequisicao;
            txtUrlBannerLivroRequisicao.Text = livroRequisicaoDTO.UrlBannerLivroRequisicao;
            txtUrlPDFLivroRequisicao.Text = livroRequisicaoDTO.UrlPDFLivroRequisicao;
        }

        private void btnRecusar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Recusar levará a remoção da requisição do livro. Tem certeza?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                int idLivroRequisicao = int.Parse(txtIdLivroRequisicao.Text.Trim());
                livroRequisicaoBLL.DeleteLivroRequisicaoBLL(idLivroRequisicao);

                LoadDgvLivroRequisicao();

                MessageBox.Show("Requisição rejeitada com sucesso", "SUCESS!!");
            }
        }

        private void dgvLivroRequisicao_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!dgvLivroRequisicao_CellMouseClick_Ativo)
            {
                return;
            }

            // Verifica se o clique foi na área da seta de seleção (coluna -1) e em uma linha válida
            if (e.ColumnIndex == -1 && e.RowIndex >= 0)
            {
                // Obtém a linha clicada
                DataGridViewRow row = dgvLivroRequisicao.Rows[e.RowIndex];

                // Preenche os controles com os dados da linha
                txtIdLivroRequisicao.Text = row.Cells["IdLivroRequisicao"].Value.ToString();
                txtTituloLivroRequisicao.Text = row.Cells["TituloLivroRequisicao"].Value.ToString();
                cboxGeneroLivroRequisicao.Text = row.Cells["GeneroLivroRequisicao"].Value.ToString();
                txtSinopseLivroRequisicao.Text = row.Cells["SinopseLivroRequisicao"].Value.ToString();
                txtAutorLivroRequisicao.Text = row.Cells["AutorLivroRequisicao"].Value.ToString();
                txtDataPublicacaoLivroRequisicao.Text = Convert.ToDateTime(row.Cells["DataPublicacaoLivroRequisicao"].Value).ToString("dd/MM/yyyy");
                txtUrlCapaLivroRequisicao.Text = row.Cells["UrlCapaLivroRequisicao"].Value.ToString();
                txtUrlIconLivroRequisicao.Text = row.Cells["UrlIconLivroRequisicao"].Value.ToString();
                txtUrlBannerLivroRequisicao.Text = row.Cells["UrlBannerLivroRequisicao"].Value?.ToString() ?? string.Empty; // Único campo que pode ser nulo
                txtUrlPDFLivroRequisicao.Text = row.Cells["UrlPDFLivroRequisicao"].Value.ToString();
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente aprovar a requisição e mandar o livro para a lista de publicados?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                int idLivro = int.Parse(txtIdLivroRequisicao.Text.Trim());
                livroRequisicaoBLL.ApproveLivroRequisicaoBLL(idLivro);

                LoadDgvLivroRequisicao();

                MessageBox.Show("Livro aprovado com sucesso", "SUCESS!!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            
            if (txtIdLivroRequisicao.ReadOnly == false)
            {
                txtIdLivroRequisicao.Focus();
            }
        }

        private void btnMudancaPesquisa_Click(object sender, EventArgs e)
        {
            if (txtIdLivroRequisicao.ReadOnly == true)
            {
                dgvLivroRequisicao_CellMouseClick_Ativo = false;
                txtIdLivroRequisicao.ReadOnly = false;
                btnPesquisar.Enabled = true;

                btnMudancaPesquisa.Text = "Selecionar pela Grade";
            }
            else
            {
                dgvLivroRequisicao_CellMouseClick_Ativo = true;
                txtIdLivroRequisicao.ReadOnly = true;
                btnPesquisar.Enabled = false;

                btnMudancaPesquisa.Text = "Selecionar por ID";
            }
        }

        private void txtIdLivroRequisicao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdLivroRequisicao.Text))
            {
                btnAprovar.Enabled = true;
                btnRecusar.Enabled = true;
            }
            else
            {
                btnAprovar.Enabled = false;
                btnRecusar.Enabled = false;
            }
        }

        private void txtIdLivroRequisicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada do caractere
            }
        }

        private void txtUrlCapaLivroRequisicao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlCapaLivroRequisicao.Text))
            {
                string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
                string caminhoAbsoluto = Path.Combine(diretorioSolucao, txtUrlCapaLivroRequisicao.Text);

                if (File.Exists(caminhoAbsoluto))
                {
                    pbUrlCapaLivroRequisicao.Image = Image.FromFile(caminhoAbsoluto);
                }
                else
                {
                    pbUrlCapaLivroRequisicao.Image = null;
                }

            }
            else
            {
                pbUrlCapaLivroRequisicao.Image = null;
            }
        }

        private void txtUrlBannerLivroRequisicao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlBannerLivroRequisicao.Text))
            {
                string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
                string caminhoAbsoluto = Path.Combine(diretorioSolucao, txtUrlBannerLivroRequisicao.Text);

                if (File.Exists(caminhoAbsoluto))
                {
                    pbUrlBannerLivroRequisicao.Image = Image.FromFile(caminhoAbsoluto);
                }
                else
                {
                    pbUrlBannerLivroRequisicao.Image = null;
                }

            }
            else
            {
                pbUrlBannerLivroRequisicao.Image = null;
            }
        }

        private void txtUrlIconLivroRequisicao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlIconLivroRequisicao.Text))
            {
                string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
                string caminhoAbsoluto = Path.Combine(diretorioSolucao, txtUrlIconLivroRequisicao.Text);

                if (File.Exists(caminhoAbsoluto))
                {
                    pbUrlIconLivroRequisicao.Image = Image.FromFile(caminhoAbsoluto);
                }
                else
                {
                    pbUrlIconLivroRequisicao.Image = null;
                }
            }
            else
            {
                pbUrlIconLivroRequisicao.Image = null;
            }
        }

        private void txtUrlPDFLivroRequisicao_TextChanged(object sender, EventArgs e)
        {
            // Caminho completo para as imagens
            string pdfExistente = Path.Combine(Application.StartupPath, "resources", "imgFrmLivro", "PDF_existente.png");
            string pdfInexistente = Path.Combine(Application.StartupPath, "resources", "imgFrmLivro", "PDF_inexistente.png");

            // Verifica se o arquivo PDF existe no caminho especificado
            if (!string.IsNullOrEmpty(txtUrlPDFLivroRequisicao.Text))
            {
                pbPDFconfirmacao.Image = Image.FromFile(pdfExistente);
            }
            else
            {
                // Verifica se o arquivo de imagem "PDF_inexistente.png" existe antes de tentar carregá-lo
                if (File.Exists(pdfInexistente))
                {
                    pbPDFconfirmacao.Image = Image.FromFile(pdfInexistente);
                }
                else
                {
                    MessageBox.Show("Arquivo PDF_inexistente.png não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbUrlCapaLivroRequisicao_Click(object sender, EventArgs e)
        {

        }
    }
}
