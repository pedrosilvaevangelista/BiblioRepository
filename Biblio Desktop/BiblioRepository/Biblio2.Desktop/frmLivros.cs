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
    public partial class frmLivros : Form
    {
        //Objetos globais
        LivroDTO livroDTO = new LivroDTO();
        LivroBLL livroBLL = new LivroBLL();

        bool dgvLivro_CellMouseClick_Ativo = true;

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
            // Carrega os dados dos livros no DataGridView
            dgvLivro.DataSource = livroBLL.GetLivroBLL();

            // Configuração das colunas
            dgvLivro.Columns["IdLivro"].HeaderText = "ID";
            dgvLivro.Columns["TituloLivro"].HeaderText = "Título";
            dgvLivro.Columns["GeneroLivro"].HeaderText = "Gênero";
            dgvLivro.Columns["SinopseLivro"].HeaderText = "Sinopse";
            dgvLivro.Columns["AutorLivro"].HeaderText = "Autor";
            dgvLivro.Columns["DataPublicacaoLivro"].HeaderText = "Data de Publicação";
            dgvLivro.Columns["UrlCapaLivro"].HeaderText = "Capa";
            dgvLivro.Columns["UrlIconLivro"].HeaderText = "Ícone";
            dgvLivro.Columns["UrlBannerLivro"].HeaderText = "Banner";
            dgvLivro.Columns["UrlPDFLivro"].HeaderText = "PDF";

            // Oculta as colunas de texto das URLs
            if (dgvLivro.Columns.Contains("UrlCapaLivro"))
            {
                dgvLivro.Columns["UrlCapaLivro"].Visible = false;
            }

            if (dgvLivro.Columns.Contains("UrlIconLivro"))
            {
                dgvLivro.Columns["UrlIconLivro"].Visible = false;
            }

            if (dgvLivro.Columns.Contains("UrlBannerLivro"))
            {
                dgvLivro.Columns["UrlBannerLivro"].Visible = false;
            }

            // Cria uma coluna de imagem para a capa do livro
            if (!dgvLivro.Columns.Contains("CapaLivroImagem"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "CapaLivroImagem";
                imgColumn.HeaderText = "Capa do Livro";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvLivro.Columns.Add(imgColumn);
            }

            // Cria uma coluna de imagem para o ícone do livro
            if (!dgvLivro.Columns.Contains("IconLivroImagem"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "IconLivroImagem";
                imgColumn.HeaderText = "Ícone do Livro";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvLivro.Columns.Add(imgColumn);
            }

            // Cria uma coluna de imagem para o banner do livro
            if (!dgvLivro.Columns.Contains("BannerLivroImagem"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "BannerLivroImagem";
                imgColumn.HeaderText = "Banner do Livro";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvLivro.Columns.Add(imgColumn);
            }

            // Obtém o diretório da solução (assumindo que o projeto desktop está na pasta da solução)
            string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

            // Preenche as colunas de imagem com as imagens carregadas dos caminhos
            foreach (DataGridViewRow row in dgvLivro.Rows)
            {
                // Carrega a imagem da capa
                string caminhoRelativoCapa = row.Cells["UrlCapaLivro"].Value?.ToString();
                if (!string.IsNullOrEmpty(caminhoRelativoCapa))
                {
                    try
                    {
                        // Converte o caminho relativo em um caminho absoluto
                        string caminhoAbsolutoCapa = Path.GetFullPath(Path.Combine(diretorioSolucao, caminhoRelativoCapa));

                        // Verifica se o arquivo existe
                        if (File.Exists(caminhoAbsolutoCapa))
                        {
                            // Carrega a imagem a partir do caminho absoluto
                            Image imgCapa = Image.FromFile(caminhoAbsolutoCapa);
                            row.Cells["CapaLivroImagem"].Value = imgCapa;
                        }
                        else
                        {
                            // Se o arquivo não existir, deixa a célula vazia
                            row.Cells["CapaLivroImagem"].Value = null;
                            //MessageBox.Show($"Arquivo não encontrado: {caminhoAbsolutoCapa}");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Se falhar ao carregar, deixa a célula vazia
                        row.Cells["CapaLivroImagem"].Value = null;
                        //MessageBox.Show($"Erro ao carregar a capa: {ex.Message}");
                    }
                }
                else
                {
                    // Se não houver caminho, deixa a célula vazia
                    row.Cells["CapaLivroImagem"].Value = null;
                }

                // Carrega a imagem do ícone
                string caminhoRelativoIcone = row.Cells["UrlIconLivro"].Value?.ToString();
                if (!string.IsNullOrEmpty(caminhoRelativoIcone))
                {
                    try
                    {
                        // Converte o caminho relativo em um caminho absoluto
                        string caminhoAbsolutoIcone = Path.GetFullPath(Path.Combine(diretorioSolucao, caminhoRelativoIcone));

                        // Verifica se o arquivo existe
                        if (File.Exists(caminhoAbsolutoIcone))
                        {
                            // Carrega a imagem a partir do caminho absoluto
                            Image imgIcone = Image.FromFile(caminhoAbsolutoIcone);
                            row.Cells["IconLivroImagem"].Value = imgIcone;
                        }
                        else
                        {
                            // Se o arquivo não existir, deixa a célula vazia
                            row.Cells["IconLivroImagem"].Value = null;
                            //MessageBox.Show($"Arquivo não encontrado: {caminhoAbsolutoIcone}");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Se falhar ao carregar, deixa a célula vazia
                        row.Cells["IconLivroImagem"].Value = null;
                        //MessageBox.Show($"Erro ao carregar o ícone: {ex.Message}");
                    }
                }
                else
                {
                    // Se não houver caminho, deixa a célula vazia
                    row.Cells["IconLivroImagem"].Value = null;
                }

                // Carrega a imagem do banner
                string caminhoRelativoBanner = row.Cells["UrlBannerLivro"].Value?.ToString();
                if (!string.IsNullOrEmpty(caminhoRelativoBanner))
                {
                    try
                    {
                        // Converte o caminho relativo em um caminho absoluto
                        string caminhoAbsolutoBanner = Path.GetFullPath(Path.Combine(diretorioSolucao, caminhoRelativoBanner));

                        // Verifica se o arquivo existe
                        if (File.Exists(caminhoAbsolutoBanner))
                        {
                            // Carrega a imagem a partir do caminho absoluto
                            Image imgBanner = Image.FromFile(caminhoAbsolutoBanner);
                            row.Cells["BannerLivroImagem"].Value = imgBanner;
                        }
                        else
                        {
                            // Se o arquivo não existir, deixa a célula vazia
                            row.Cells["BannerLivroImagem"].Value = null;
                            //MessageBox.Show($"Arquivo não encontrado: {caminhoAbsolutoBanner}");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Se falhar ao carregar, deixa a célula vazia
                        row.Cells["BannerLivroImagem"].Value = null;
                        //MessageBox.Show($"Erro ao carregar o banner: {ex.Message}");
                    }
                }
                else
                {
                    // Se não houver caminho, deixa a célula vazia
                    row.Cells["BannerLivroImagem"].Value = null;
                }
            }
        }

        public bool ValidaPageLivro()
        {
            bool valid;
            DateTime dt;

            string msg = "Preencha o campo";

            if (string.IsNullOrEmpty(txtTituloLivro.Text))
            {
                lblTituloLivroErro.Text = msg;

                lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                txtTituloLivro.Focus();
                valid = false;
            }
            else if (cboxGeneroLivro.SelectedIndex == -1)
            {
                lblGeneroLivroErro.Text = msg;

                lblTituloLivroErro.Text = lblAutorLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                valid = false;
            }
            else if (string.IsNullOrEmpty(txtAutorLivro.Text))
            {
                lblAutorLivroErro.Text = msg;

                lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                txtAutorLivro.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtDataPublicacaoLivro.Text) || !DateTime.TryParse(txtDataPublicacaoLivro.Text, out dt))
            {
                lblDataPublicacaoLivroErro.Text = msg;

                lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                valid = false;
            }
            else if (dt > DateTime.Today)
            {
                lblDataPublicacaoLivroErro.Text = "A data de publicação não pode ser no futuro";

                lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                valid = false;
            }
            else if (string.IsNullOrEmpty(txtSinopseLivro.Text))
            {
                lblSinopseLivroErro.Text = msg;

                lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                valid = false;
            }
            else if (string.IsNullOrEmpty(txtUrlCapaLivro.Text))
            {
                lblUrlCapaLivroErro.Text = msg;

                lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblSinopseLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                valid = false;
            }
            //else if (string.IsNullOrEmpty(txtUrlBannerLivro.Text))
            //{
            //    lblUrlBannerLivroErro.Text = msg;

            //    lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlIconLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

            //    valid = false;
            //}
            else if (string.IsNullOrEmpty(txtUrlIconLivro.Text))
            {
                lblUrlIconLivroErro.Text = msg;

                lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlPDFLivroErro.Text = string.Empty;

                valid = false;
            }
            else if (string.IsNullOrEmpty(txtUrlPDFLivro.Text))
            {
                lblUrlPDFLivroErro.Text = msg;

                lblTituloLivroErro.Text = lblGeneroLivroErro.Text = lblAutorLivroErro.Text = lblDataPublicacaoLivroErro.Text = lblSinopseLivroErro.Text = lblUrlCapaLivroErro.Text = lblUrlBannerLivroErro.Text = lblUrlIconLivroErro.Text = string.Empty;

                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            LoadDgvLivro();
            LoadCboxGeneroLivro();
            LimparCampos();
        }

        private void btnUrlCapaLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione a capa do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Caminho absoluto da imagem selecionada
                string caminhoAbsolutoImagem = ofd.FileName;

                // Obtém o diretório base da UI (Biblio2.UI)
                string diretorioUI = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Biblio2.UI\"));

                // Converte o caminho absoluto da imagem para um caminho relativo à UI
                Uri uriDiretorioUI = new Uri(diretorioUI);
                Uri uriImagem = new Uri(caminhoAbsolutoImagem);
                Uri uriRelativo = uriDiretorioUI.MakeRelativeUri(uriImagem);

                // Converte o caminho relativo para string e substitui as barras invertidas
                string caminhoRelativo = Uri.UnescapeDataString(uriRelativo.ToString()).Replace("\\", "/");

                // Adiciona o prefixo ~/ ao caminho relativo
                caminhoRelativo = $"~/{caminhoRelativo}";

                // Exibe a imagem no PictureBox
                pbUrlCapaLivro.Image = Image.FromFile(caminhoAbsolutoImagem);

                // Define o caminho relativo no TextBox
                txtUrlCapaLivro.Text = caminhoRelativo;
            }
        }

        private void btnUrlBannerLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione o banner do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Caminho absoluto da imagem selecionada
                    string caminhoAbsolutoImagem = ofd.FileName;

                    // Verifica se o arquivo existe
                    if (!File.Exists(caminhoAbsolutoImagem))
                    {
                        MessageBox.Show("Arquivo de imagem não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Obtém o diretório base da UI (Biblio2.UI)
                    string diretorioUI = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Biblio2.UI\"));

                    // Verifica se o diretório da UI existe
                    if (!Directory.Exists(diretorioUI))
                    {
                        MessageBox.Show("Diretório da UI não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Converte o caminho absoluto da imagem para um caminho relativo à UI
                    Uri uriDiretorioUI = new Uri(diretorioUI);
                    Uri uriImagem = new Uri(caminhoAbsolutoImagem);
                    Uri uriRelativo = uriDiretorioUI.MakeRelativeUri(uriImagem);

                    // Converte o caminho relativo para string e substitui as barras invertidas
                    string caminhoRelativo = Uri.UnescapeDataString(uriRelativo.ToString()).Replace("\\", "/");

                    // Adiciona o prefixo ~/ ao caminho relativo
                    caminhoRelativo = $"~/{caminhoRelativo}";

                    // Exibe a imagem no PictureBox
                    pbUrlBannerLivro.Image = Image.FromFile(caminhoAbsolutoImagem);

                    // Define o caminho relativo no TextBox
                    txtUrlBannerLivro.Text = caminhoRelativo;

                    // Mensagem de depuração
                }
                catch (Exception ex)
                {
                    // Exibe mensagem de erro em caso de exceção
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUrlIconLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione o ícone do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Caminho absoluto da imagem selecionada
                string caminhoAbsolutoImagem = ofd.FileName;

                // Obtém o diretório base da UI (Biblio2.UI)
                string diretorioUI = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Biblio2.UI\"));

                // Converte o caminho absoluto da imagem para um caminho relativo à UI
                Uri uriDiretorioUI = new Uri(diretorioUI);
                Uri uriImagem = new Uri(caminhoAbsolutoImagem);
                Uri uriRelativo = uriDiretorioUI.MakeRelativeUri(uriImagem);

                // Converte o caminho relativo para string e substitui as barras invertidas
                string caminhoRelativo = Uri.UnescapeDataString(uriRelativo.ToString()).Replace("\\", "/");

                // Adiciona o prefixo ~/ ao caminho relativo
                caminhoRelativo = $"~/{caminhoRelativo}";

                // Exibe a imagem no PictureBox
                pbUrlIconLivro.Image = Image.FromFile(caminhoAbsolutoImagem);

                // Define o caminho relativo no TextBox
                txtUrlIconLivro.Text = caminhoRelativo;
            }
        }

        private void btnUrlPDFLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files|*.pdf";
            ofd.Title = "Selecione o PDF do livro";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Caminho absoluto do arquivo PDF selecionado
                string caminhoAbsolutoPDF = ofd.FileName;

                // Obtém o diretório base da UI (Biblio2.UI)
                string diretorioUI = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Biblio2.UI\"));

                // Converte o caminho absoluto do PDF para um caminho relativo à UI
                Uri uriDiretorioUI = new Uri(diretorioUI);
                Uri uriPDF = new Uri(caminhoAbsolutoPDF);
                Uri uriRelativo = uriDiretorioUI.MakeRelativeUri(uriPDF);

                // Converte o caminho relativo para string e substitui as barras invertidas
                string caminhoRelativo = Uri.UnescapeDataString(uriRelativo.ToString()).Replace("\\", "/");

                // Adiciona o prefixo ~/ ao caminho relativo
                caminhoRelativo = $"~/{caminhoRelativo}";

                // Define o caminho relativo no TextBox
                txtUrlPDFLivro.Text = caminhoRelativo;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaPageLivro())
            {
                // Atribui os valores dos campos ao DTO
                livroDTO.TituloLivro = txtTituloLivro.Text;
                livroDTO.GeneroLivro = cboxGeneroLivro.SelectedValue.ToString();
                livroDTO.SinopseLivro = txtSinopseLivro.Text;
                livroDTO.AutorLivro = txtAutorLivro.Text;
                livroDTO.DataPublicacaoLivro = DateTime.Parse(txtDataPublicacaoLivro.Text);
                livroDTO.UrlCapaLivro = txtUrlCapaLivro.Text;
                livroDTO.UrlIconLivro = txtUrlIconLivro.Text;
                livroDTO.UrlBannerLivro = txtUrlBannerLivro.Text;
                livroDTO.UrlPDFLivro = txtUrlPDFLivro.Text;

                // Verifica se o título já existe no banco de dados
                bool duplicado = livroBLL.VerificarTituloLivroBLL(livroDTO.TituloLivro);

                if (duplicado)
                {
                    // Exibe uma mensagem de erro personalizada
                    MessageBox.Show("Título de livro já existente. Por favor, escolha um título diferente.", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Se não houver duplicidade, cadastra o livro
                    livroBLL.CreateLivroBLL(livroDTO);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show($"Livro {livroDTO.TituloLivro.ToUpper()} cadastrado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    // Recarrega a lista de livros
                    LoadDgvLivro();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidaPageLivro())
            {
                int idLivro = int.Parse(txtIdLivro.Text.Trim());
                livroDTO = livroBLL.SearchByIdLivroBLL(idLivro);

                bool duplicado = false;
                if (livroDTO.TituloLivro != txtTituloLivro.Text)
                {
                    // Verifica se o novo título já existe no banco de dados
                    duplicado = livroBLL.VerificarTituloLivroBLL(txtTituloLivro.Text);
                }

                if (duplicado)
                {
                    MessageBox.Show("Título de livro já existente. Por favor, escolha um título diferente.", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Atualiza os dados do livro
                    livroDTO.TituloLivro = txtTituloLivro.Text;
                    livroDTO.GeneroLivro = cboxGeneroLivro.SelectedValue.ToString();
                    livroDTO.SinopseLivro = txtSinopseLivro.Text;
                    livroDTO.AutorLivro = txtAutorLivro.Text;
                    livroDTO.DataPublicacaoLivro = DateTime.Parse(txtDataPublicacaoLivro.Text);
                    livroDTO.UrlCapaLivro = txtUrlCapaLivro.Text;
                    livroDTO.UrlIconLivro = txtUrlIconLivro.Text;
                    livroDTO.UrlBannerLivro = txtUrlBannerLivro.Text;
                    livroDTO.UrlPDFLivro = txtUrlPDFLivro.Text;

                    // Atualiza o livro no banco de dados
                    livroDTO.IdLivro = int.Parse(txtIdLivro.Text);
                    livroBLL.UpdateLivroBLL(livroDTO);

                    // Recarrega a lista de livros e exibe uma mensagem de sucesso
                    LimparCampos();
                    LoadDgvLivro();
                    MessageBox.Show($"Livro {livroDTO.TituloLivro.ToUpper()} editado com sucesso !!");
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente deletar este livro?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                int idLivro = int.Parse(txtIdLivro.Text.Trim());
                livroBLL.DeleteLivroBLL(idLivro);

                LimparCampos();
                LoadDgvLivro();

                MessageBox.Show("Livro deletado com sucesso", "SUCESS!!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int idLivro = int.Parse(txtIdLivro.Text.Trim());
            livroDTO = livroBLL.SearchByIdLivroBLL(idLivro);

            txtIdLivro.Text = livroDTO.IdLivro.ToString();
            txtTituloLivro.Text = livroDTO.TituloLivro;

            switch (livroDTO.GeneroLivro)
            {
                case "1":
                    cboxGeneroLivro.Text = "Ficção Científica";
                    break;
                case "2":
                    cboxGeneroLivro.Text = "Fantasia";
                    break;
                case "3":
                    cboxGeneroLivro.Text = "Romance";
                    break;
                case "4":
                    cboxGeneroLivro.Text = "Terror";
                    break;
                case "5":
                    cboxGeneroLivro.Text = "Mistério";
                    break;
                case "6":
                    cboxGeneroLivro.Text = "Aventura";
                    break;
                case "7":
                    cboxGeneroLivro.Text = "Ciência";
                    break;
                case "8":
                    cboxGeneroLivro.Text = "Tecnologia";
                    break;
                case "9":
                    cboxGeneroLivro.Text = "Suspense";
                    break;
                case "10":
                    cboxGeneroLivro.Text = "Drama";
                    break;
                case "11":
                    cboxGeneroLivro.Text = "Biografia";
                    break;
                case "12":
                    cboxGeneroLivro.Text = "História";
                    break;
                case "13":
                    cboxGeneroLivro.Text = "Autoajuda";
                    break;
                case "14":
                    cboxGeneroLivro.Text = "Filosofia";
                    break;
                case "15":
                    cboxGeneroLivro.Text = "Psicologia";
                    break;
            }

            txtSinopseLivro.Text = livroDTO.SinopseLivro;
            txtAutorLivro.Text = livroDTO.AutorLivro;
            txtDataPublicacaoLivro.Text = livroDTO.DataPublicacaoLivro.ToString();
            txtUrlCapaLivro.Text = livroDTO.UrlCapaLivro;
            txtUrlIconLivro.Text = livroDTO.UrlIconLivro;
            txtUrlBannerLivro.Text = livroDTO.UrlBannerLivro;
            txtUrlPDFLivro.Text = livroDTO.UrlPDFLivro;
        }

        private void dgvLivro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!dgvLivro_CellMouseClick_Ativo)
            {
                return;
            }

            //Verifica se o clique foi na área de seta de seleção (coluna -1) e em uma linha válida
            if (e.ColumnIndex == -1 && e.RowIndex >= 0)
            {
                //Obtém a linha clicada
                DataGridViewRow row = dgvLivro.Rows[e.RowIndex];

                // Preenche os controles com os dados da linha
                txtIdLivro.Text = row.Cells["IdLivro"].Value.ToString();
                txtTituloLivro.Text = row.Cells["TituloLivro"].Value.ToString();
                cboxGeneroLivro.Text = row.Cells["GeneroLivro"].Value.ToString();
                txtAutorLivro.Text = row.Cells["AutorLivro"].Value.ToString();
                txtDataPublicacaoLivro.Text = row.Cells["DataPublicacaoLivro"].Value.ToString();
                txtSinopseLivro.Text = row.Cells["SinopseLivro"].Value.ToString();
                txtUrlCapaLivro.Text = row.Cells["UrlCapaLivro"].Value.ToString();
                txtUrlBannerLivro.Text = row.Cells["UrlBannerLivro"].Value.ToString();
                txtUrlIconLivro.Text = row.Cells["UrlIconLivro"].Value.ToString();
                txtUrlPDFLivro.Text = row.Cells["UrlPDFLivro"].Value.ToString();
            }
        }

        private void txtIdLivro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdLivro.Text))
            {
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
                btnCadastrar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
                btnCadastrar.Enabled = true;
            }
        }

        private void txtIdLivro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada do caractere
            }
        }

        private void btnMudancaPesquisa_Click(object sender, EventArgs e)
        {
            if (txtIdLivro.ReadOnly == true)
            {
                dgvLivro_CellMouseClick_Ativo = false;
                txtIdLivro.ReadOnly = false;
                btnPesquisar.Enabled = true;

                btnMudancaPesquisa.Text = "Selecionar pela Grade";
            }
            else
            {
                dgvLivro_CellMouseClick_Ativo = true;
                txtIdLivro.ReadOnly = true;
                btnPesquisar.Enabled = false;

                btnMudancaPesquisa.Text = "Selecionar por ID";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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

            if (txtIdLivro.ReadOnly == true)
            {
                txtTituloLivro.Focus();
            }
            else
            {
                txtIdLivro.Focus();
            }
        }

        private void txtUrlCapaLivro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlCapaLivro.Text))
            {
                try
                {
                    // Obtém o diretório base da solução
                    string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

                    // Substitui o ~/ pelo caminho da pasta UI
                    string caminhoRelativo = txtUrlCapaLivro.Text.Trim();
                    if (caminhoRelativo.StartsWith("~/"))
                    {
                        caminhoRelativo = caminhoRelativo.Substring(2); // Remove o ~/
                        caminhoRelativo = caminhoRelativo.Replace("/", "\\"); // Substitui barras por barras invertidas
                    }

                    // Caminho absoluto para o arquivo da imagem
                    string caminhoImagem = Path.Combine(diretorioSolucao, "Biblio2.UI", caminhoRelativo);

                    // Verifica se o arquivo existe antes de tentar carregar
                    if (File.Exists(caminhoImagem))
                    {
                        // Libera a imagem anterior para evitar erro de arquivo em uso
                        if (pbUrlCapaLivro.Image != null)
                            pbUrlCapaLivro.Image.Dispose();

                        pbUrlCapaLivro.Image = new Bitmap(caminhoImagem);
                        btnRemoverCapa.Enabled = true;
                    }
                    else
                    {
                        pbUrlCapaLivro.Image = null;
                        btnRemoverCapa.Enabled = false;
                        MessageBox.Show("Arquivo de imagem não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbUrlCapaLivro.Image = null;
                    btnRemoverCapa.Enabled = false;
                }
            }
            else
            {
                pbUrlCapaLivro.Image = null;
                btnRemoverCapa.Enabled = false;
            }
        }
        private void txtUrlBannerLivro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlBannerLivro.Text))
            {
                try
                {
                    // Obtém o diretório base da solução
                    string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

                    // Substitui o ~/ pelo caminho da pasta UI
                    string caminhoRelativo = txtUrlBannerLivro.Text.Trim();
                    if (caminhoRelativo.StartsWith("~/"))
                    {
                        caminhoRelativo = caminhoRelativo.Substring(2); // Remove o ~/
                        caminhoRelativo = caminhoRelativo.Replace("/", "\\"); // Substitui barras por barras invertidas
                    }

                    // Caminho absoluto para o arquivo da imagem
                    string caminhoImagem = Path.Combine(diretorioSolucao, "Biblio2.UI", caminhoRelativo);

                    // Verifica se o arquivo existe antes de tentar carregar
                    if (File.Exists(caminhoImagem))
                    {
                        // Libera a imagem anterior para evitar erro de arquivo em uso
                        if (pbUrlBannerLivro.Image != null)
                            pbUrlBannerLivro.Image.Dispose();

                        pbUrlBannerLivro.Image = new Bitmap(caminhoImagem);
                        btnRemoverBanner.Enabled = true;
                    }
                    else
                    {
                        pbUrlBannerLivro.Image = null;
                        btnRemoverBanner.Enabled = false;
                        MessageBox.Show("Arquivo de imagem não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbUrlBannerLivro.Image = null;
                    btnRemoverBanner.Enabled = false;
                }
            }
            else
            {
                pbUrlBannerLivro.Image = null;
                btnRemoverBanner.Enabled = false;
            }
        }

        private void txtUrlIconLivro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlIconLivro.Text))
            {
                try
                {
                    // Obtém o diretório base da solução
                    string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

                    // Substitui o ~/ pelo caminho da pasta UI
                    string caminhoRelativo = txtUrlIconLivro.Text.Trim();
                    if (caminhoRelativo.StartsWith("~/"))
                    {
                        caminhoRelativo = caminhoRelativo.Substring(2); // Remove o ~/
                        caminhoRelativo = caminhoRelativo.Replace("/", "\\"); // Substitui barras por barras invertidas
                    }

                    // Caminho absoluto para o arquivo da imagem
                    string caminhoImagem = Path.Combine(diretorioSolucao, "Biblio2.UI", caminhoRelativo);

                    // Verifica se o arquivo existe antes de tentar carregar
                    if (File.Exists(caminhoImagem))
                    {
                        // Libera a imagem anterior para evitar erro de arquivo em uso
                        if (pbUrlIconLivro.Image != null)
                            pbUrlIconLivro.Image.Dispose();

                        pbUrlIconLivro.Image = new Bitmap(caminhoImagem);
                        btnRemoverIcon.Enabled = true;
                    }
                    else
                    {
                        pbUrlIconLivro.Image = null;
                        btnRemoverIcon.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbUrlIconLivro.Image = null;
                    btnRemoverIcon.Enabled = false;
                }
            }
            else
            {
                pbUrlIconLivro.Image = null;
                btnRemoverIcon.Enabled = false;
            }
        }

        private void txtUrlPDFLivro_TextChanged(object sender, EventArgs e)
        {
            // Caminho completo para as imagens
            string pdfExistente = Path.Combine(Application.StartupPath, "resources", "imgFrmLivro", "PDF_existente.png");
            string pdfInexistente = Path.Combine(Application.StartupPath, "resources", "imgFrmLivro", "PDF_inexistente.png");

            // Verifica se o arquivo PDF existe no caminho especificado
            if (!string.IsNullOrEmpty(txtUrlPDFLivro.Text))
            {
                pbPDFconfirmacao.Image = Image.FromFile(pdfExistente);

                btnRemoverPDF.Enabled = true;
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

                btnRemoverPDF.Enabled = false;
            }
        }

        private void btnRemoverCapa_Click(object sender, EventArgs e)
        {
            txtUrlCapaLivro.Text = string.Empty;
        }

        private void btnRemoverBanner_Click(object sender, EventArgs e)
        {
            txtUrlBannerLivro.Text = string.Empty;
        }

        private void btnRemoverIcon_Click(object sender, EventArgs e)
        {
            txtUrlIconLivro.Text = string.Empty;
        }

        private void btnRemoverPDF_Click(object sender, EventArgs e)
        {
            txtUrlPDFLivro.Text = string.Empty;
        }

        private void txtTituloLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutorLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSinopseLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTituloLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblIdLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblGeneroLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblAutorLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblDataPublicacaoLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblSinopseLivro_Click(object sender, EventArgs e)
        {

        }

        private void cboxGeneroLivro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUrlFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblUrlBannerLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblBannerLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblGeneroLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblAutorLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblDataPublicacaoLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblUrlIconLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblIconLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblCapaLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblUrlPDFLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblPDFLivro_Click(object sender, EventArgs e)
        {

        }

        private void pbPDFconfirmacao_Click(object sender, EventArgs e)
        {

        }

        private void pbUrlIconLivro_Click(object sender, EventArgs e)
        {

        }

        private void pbUrlBannerLivro_Click(object sender, EventArgs e)
        {

        }

        private void pbUrlCapaLivro_Click(object sender, EventArgs e)
        {

        }

        private void lblIdLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblSinopseLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void lblPagina_Click(object sender, EventArgs e)
        {

        }

        private void lblUrlCapaLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblUrlBannerLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblUrlPDFLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void lblUrlIconLivroErro_Click(object sender, EventArgs e)
        {

        }

        private void txtDataPublicacaoLivro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
