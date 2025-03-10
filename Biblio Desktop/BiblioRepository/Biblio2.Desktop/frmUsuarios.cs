using Biblio2.BLL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio2.Desktop
{
    public partial class frmUsuarios : Form
    {
        //Objetos globais
        UsuarioBLL userBLL = new UsuarioBLL();
        UsuarioDTO userDTO = new UsuarioDTO();

        bool dgvUsuario_CellMouseClick_Ativo = true;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public void LoadDgvUsuario()
        {
            // Carrega os dados dos usuários no DataGridView
            dgvUsuario.DataSource = userBLL.GetUsuarioBLL();

            // Configuração das colunas
            dgvUsuario.Columns["IdUsuario"].HeaderText = "ID";
            dgvUsuario.Columns["NomeUsuario"].HeaderText = "Nome";
            dgvUsuario.Columns["EmailUsuario"].HeaderText = "E-mail";
            dgvUsuario.Columns["SenhaUsuario"].HeaderText = "Senha";
            dgvUsuario.Columns["UrlFotoPerfil"].HeaderText = "URL da Foto";

            // Oculta a coluna original de texto 'UrlFotoPerfil'
            if (dgvUsuario.Columns.Contains("UrlFotoPerfil"))
            {
                dgvUsuario.Columns["UrlFotoPerfil"].Visible = false;
            }

            if (!dgvUsuario.Columns.Contains("FotoPerfilImagem"))
            {
                // Cria uma nova coluna de imagem para exibir as fotos de perfil
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "FotoPerfilImagem"; // Nome da nova coluna
                imgColumn.HeaderText = "Foto de Perfil"; // Título da coluna
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta a imagem ao tamanho da célula
                dgvUsuario.Columns.Add(imgColumn);
            }

            // Obtém o diretório da solução (assumindo que o projeto desktop está na pasta da solução)
            string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

            // Preenche a nova coluna com as imagens carregadas dos caminhos
            foreach (DataGridViewRow row in dgvUsuario.Rows)
            {
                string caminhoRelativo = row.Cells["UrlFotoPerfil"].Value?.ToString(); // Obtém o caminho relativo da imagem
                if (!string.IsNullOrEmpty(caminhoRelativo))
                {
                    try
                    {
                        // Converte o caminho relativo em um caminho absoluto
                        string caminhoAbsoluto = Path.GetFullPath(Path.Combine(diretorioSolucao, caminhoRelativo));

                        // Verifica se o arquivo existe
                        if (File.Exists(caminhoAbsoluto))
                        {
                            // Carrega a imagem a partir do caminho absoluto
                            Image img = Image.FromFile(caminhoAbsoluto);
                            row.Cells["FotoPerfilImagem"].Value = img; // Define a imagem na nova coluna
                        }
                        else
                        {
                            // Se o arquivo não existir, deixa a célula vazia
                            row.Cells["FotoPerfilImagem"].Value = null;
                            //MessageBox.Show($"Arquivo não encontrado: {caminhoAbsoluto}");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Se falhar ao carregar, deixa a célula vazia
                        row.Cells["FotoPerfilImagem"].Value = null;
                        //MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}");
                    }
                }
                else
                {
                    // Se não houver caminho, deixa a célula vazia
                    row.Cells["FotoPerfilImagem"].Value = null;
                }
            }

            dgvUsuario.Columns["UsuarioTipo"].HeaderText = "Tipo de Usuário";

            dgvUsuario.Columns["IdUsuario"].Width = 50;
            dgvUsuario.Columns["EmailUsuario"].Width = 150;
        }

        public void LoadCboxTipoUsuario()
        {
            cboxTipoUsuario.Items.Clear();
            cboxTipoUsuario.DisplayMember = "DescricaoTipoUsuario";
            cboxTipoUsuario.ValueMember = "IdTipoUsuario";
            cboxTipoUsuario.DataSource = userBLL.GetTipoUsuarioBLL();
            cboxTipoUsuario.SelectedIndex = -1;
        }

        public bool ValidaPaginaUsuario()
        {
            bool valid;
            DateTime dt;

            string msg = "Preencha o campo";

            if (string.IsNullOrEmpty(txtNomeUsuario.Text))
            {
                lblNomeUsuarioErro.Text = msg;

                lblEmailUsuarioErro.Text = lblSenhaUsuarioErro.Text = lblTipoUsuarioErro.Text = lblUrlFotoPerfilErro.Text = string.Empty;

                txtNomeUsuario.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtEmailUsuario.Text))
            {
                lblEmailUsuarioErro.Text = msg;

                lblNomeUsuarioErro.Text = lblSenhaUsuarioErro.Text = lblTipoUsuarioErro.Text = lblUrlFotoPerfilErro.Text = string.Empty;

                txtEmailUsuario.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtSenhaUsuario.Text))
            {
                lblSenhaUsuarioErro.Text = msg;

                lblNomeUsuarioErro.Text = lblEmailUsuarioErro.Text = lblTipoUsuarioErro.Text = lblUrlFotoPerfilErro.Text = string.Empty;

                txtSenhaUsuario.Focus();
                valid = false;
            }
            else if (cboxTipoUsuario.SelectedIndex == -1)
            {
                lblTipoUsuarioErro.Text = msg;

                lblNomeUsuarioErro.Text = lblEmailUsuarioErro.Text = lblSenhaUsuarioErro.Text = lblUrlFotoPerfilErro.Text = string.Empty;

                valid = false;
            }
            else if (string.IsNullOrEmpty(txtUrlFotoPerfil.Text))
            {
                lblUrlFotoPerfilErro.Text = msg;

                lblNomeUsuarioErro.Text = lblEmailUsuarioErro.Text = lblSenhaUsuarioErro.Text = lblTipoUsuarioErro.Text = string.Empty;

                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;
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

            if (txtIdUsuario.ReadOnly == true)
            {
                txtNomeUsuario.Focus();
            }
            else
            {
                txtIdUsuario.Focus();
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LoadDgvUsuario();
            LoadCboxTipoUsuario();
            LimparCampos();
            //dgvUsuario.BorderStyle = BorderStyle.None;
        }

        private void dgvUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!dgvUsuario_CellMouseClick_Ativo)
            {
                return;
            }

            // Verifica se o clique foi na área da seta de seleção (coluna -1) e em uma linha válida
            if (e.ColumnIndex == -1 && e.RowIndex >= 0)
            {
                // Obtém a linha clicada
                DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];

                // Preenche os controles com os dados da linha
                txtIdUsuario.Text = row.Cells["IdUsuario"].Value.ToString();
                txtNomeUsuario.Text = row.Cells["NomeUsuario"].Value.ToString();
                txtEmailUsuario.Text = row.Cells["EmailUsuario"].Value.ToString();
                txtSenhaUsuario.Text = row.Cells["SenhaUsuario"].Value.ToString();
                cboxTipoUsuario.Text = row.Cells["UsuarioTipo"].Value.ToString();
                txtUrlFotoPerfil.Text = row.Cells["UrlFotoPerfil"].Value.ToString();
            }
        }

        private void btnMudancaPesquisa_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.ReadOnly == true)
            {
                dgvUsuario_CellMouseClick_Ativo = false;
                txtIdUsuario.ReadOnly = false;
                btnPesquisar.Enabled = true;

                btnMudancaPesquisa.Text = "Selecionar pela Grade";
            }
            else
            {
                dgvUsuario_CellMouseClick_Ativo = true;
                txtIdUsuario.ReadOnly = true;
                btnPesquisar.Enabled = false;

                btnMudancaPesquisa.Text = "Selecionar por ID";
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int idUser = int.Parse(txtIdUsuario.Text.Trim());
            userDTO = userBLL.SearchByIdUsuarioBLL(idUser);

            if (userDTO == null)
            {
                MessageBox.Show("Usuário inexistente, tente outro ID...", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdUsuario.Text = string.Empty;
                txtIdUsuario.Focus();
            }
            else
            {
                txtIdUsuario.Text = userDTO.IdUsuario.ToString();
                txtNomeUsuario.Text = userDTO.NomeUsuario;
                txtEmailUsuario.Text = userDTO.EmailUsuario;
                txtSenhaUsuario.Text = userDTO.SenhaUsuario;
                txtUrlFotoPerfil.Text = userDTO.UrlFotoPerfil;
                cboxTipoUsuario.Text = userDTO.UsuarioTipo;

                if (userDTO.UsuarioTipo == "1")
                {
                    cboxTipoUsuario.Text = "Administrador";
                }
                else if (userDTO.UsuarioTipo == "2")
                {
                    cboxTipoUsuario.Text = "Autor";
                }
                else
                {
                    cboxTipoUsuario.Text = "Comum";
                }
            }
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdUsuario.Text))
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

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada do caractere
            }
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione uma imagem";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Caminho absoluto da imagem selecionada
                string caminhoAbsolutoImagem = ofd.FileName;

                // Diretório da solução (assumindo que o projeto está na pasta da solução)
                string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

                // Calcula o caminho relativo
                Uri uriDiretorioSolucao = new Uri(diretorioSolucao);
                Uri uriImagem = new Uri(caminhoAbsolutoImagem);
                Uri uriRelativo = uriDiretorioSolucao.MakeRelativeUri(uriImagem);
                string caminhoRelativo = Uri.UnescapeDataString(uriRelativo.ToString());

                // Exibe a imagem no PictureBox
                pbUrlFotoPerfil.Image = Image.FromFile(caminhoAbsolutoImagem);

                // Salva o caminho relativo no TextBox
                txtUrlFotoPerfil.Text = caminhoRelativo;
            }
        }

        private void txtUrlFotoPerfil_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrlFotoPerfil.Text))
            {
                string diretorioSolucao = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
                string caminhoAbsoluto = Path.Combine(diretorioSolucao, txtUrlFotoPerfil.Text);

                if (File.Exists(caminhoAbsoluto))
                {
                    pbUrlFotoPerfil.Image = Image.FromFile(caminhoAbsoluto);
                }
                else
                {
                    pbUrlFotoPerfil.Image = null;
                }

                btnRemoverFoto.Enabled = true;
            }
            else
            {
                pbUrlFotoPerfil.Image = null;

                btnRemoverFoto.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaPaginaUsuario())
            {
                // Atribui os valores dos campos ao DTO
                userDTO.NomeUsuario = txtNomeUsuario.Text;
                userDTO.EmailUsuario = txtEmailUsuario.Text;
                userDTO.SenhaUsuario = txtSenhaUsuario.Text;
                userDTO.UsuarioTipo = cboxTipoUsuario.SelectedValue.ToString();
                userDTO.UrlFotoPerfil = txtUrlFotoPerfil.Text;

                // Verifica se o nome ou e-mail já existem no banco de dados
                bool duplicado = userBLL.VerificaUsuarioExistenteBLL(userDTO.NomeUsuario);

                if (duplicado)
                {
                    // Exibe uma mensagem de erro personalizada
                    MessageBox.Show("Nome de usuário já existente. Por favor, escolha um nome diferente.", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeUsuario.Text = string.Empty;
                    txtNomeUsuario.Focus();
                }
                else
                {
                    // Se não houver duplicidade, cadastra o usuário
                    userBLL.CreateUsuarioBLL(userDTO);

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show($"Usuário {userDTO.NomeUsuario.ToUpper()} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarrega a lista de usuários
                    LoadDgvUsuario();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidaPaginaUsuario())
            {
                int idUser = int.Parse(txtIdUsuario.Text);
                userDTO = userBLL.SearchByIdUsuarioBLL(idUser);

                bool duplicado = false;

                if (userDTO.NomeUsuario != txtNomeUsuario.Text)
                {
                    // Verifica se o novo nome ou e-mail já existem no banco de dados
                    duplicado = userBLL.VerificaUsuarioExistenteBLL(txtNomeUsuario.Text);
                }

                if (duplicado)
                {
                    MessageBox.Show("Nome de usuário já existente. Por favor, escolha um nome diferente.", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeUsuario.Text = userDTO.NomeUsuario;
                    txtNomeUsuario.Focus();
                }
                else
                {
                    // Atualiza os dados do usuário
                    userDTO.NomeUsuario = txtNomeUsuario.Text;
                    userDTO.EmailUsuario = txtEmailUsuario.Text;
                    userDTO.SenhaUsuario = txtSenhaUsuario.Text;
                    userDTO.UrlFotoPerfil = txtUrlFotoPerfil.Text;
                    userDTO.UsuarioTipo = cboxTipoUsuario.SelectedValue.ToString();

                    // Atualiza o usuário no banco de dados
                    userDTO.IdUsuario = int.Parse(txtIdUsuario.Text);
                    userBLL.UpdateUsuarioBLL(userDTO);

                    // Recarrega a lista de usuários e exibe uma mensagem de sucesso
                    LoadDgvUsuario();
                    MessageBox.Show($"Usuário {userDTO.NomeUsuario.ToUpper()} editado com sucesso !!");
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                DialogResult msg = MessageBox.Show("Deseja realmente deletar este usuário?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    int idUser = int.Parse(txtIdUsuario.Text.Trim());
                    userBLL.DeleteUsuarioBLL(idUser);

                    LoadDgvUsuario();

                    MessageBox.Show("Usuário deletado com sucesso", "SUCESS!!");
                }
            }
        }

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {
            txtUrlFotoPerfil.Text = string.Empty;
        }
    }
}
