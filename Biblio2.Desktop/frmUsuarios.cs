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
        string msg = "O campo precisa ser preenchido corretamente!!";
        private string connectionString = @"Data Source = localhost; Initial Catalog = Biblio2DB; Integrated Security = true"; // Ajuste conforme seu banco

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
            dgvUsuario.Columns["EmailUsuario"].HeaderText = "Email";
            dgvUsuario.Columns["SenhaUsuario"].HeaderText = "Senha";
            dgvUsuario.Columns["UrlFotoPerfil"].HeaderText = "URL da Foto";

            // Oculta a coluna original de texto 'UrlFotoPerfil'
            //if (dgvUsuario.Columns.Contains("UrlFotoPerfil"))
            //{
            //    dgvUsuario.Columns["UrlFotoPerfil"].Visible = false;
            //}

            if (!dgvUsuario.Columns.Contains("FotoPerfilImagem"))
            {
                // Cria uma nova coluna de imagem para exibir as fotos de perfil
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "FotoPerfilImagem"; // Nome da nova coluna
                imgColumn.HeaderText = "Foto de Perfil"; // Título da coluna
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta a imagem ao tamanho da célula
                dgvUsuario.Columns.Add(imgColumn);
            }

            // Preenche a nova coluna com as imagens carregadas dos caminhos
            foreach (DataGridViewRow row in dgvUsuario.Rows)
            {
                string caminhoImagem = row.Cells["UrlFotoPerfil"].Value?.ToString(); // Obtém o caminho da imagem
                if (!string.IsNullOrEmpty(caminhoImagem) && File.Exists(caminhoImagem))
                {
                    try
                    {
                        // Carrega a imagem a partir do caminho do arquivo
                        Image img = Image.FromFile(caminhoImagem);
                        row.Cells["FotoPerfilImagem"].Value = img; // Define a imagem na nova coluna
                    }
                    catch (Exception ex)
                    {
                        // Se falhar ao carregar, deixa a célula vazia
                        row.Cells["FotoPerfilImagem"].Value = null;
                        MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}");
                    }
                }
                else
                {
                    // Se não houver caminho ou o arquivo não existir, deixa a célula vazia
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

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LoadDgvUsuario();
            LoadCboxTipoUsuario();
            txtUrlFotoPerfil.Enabled = false;
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            ofd.Title = "Selecione uma imagem";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Caminho da imagem selecionada
                string caminhoImagem = ofd.FileName;

                // Exibe a imagem no PictureBox
                pbUrlFotoPerfil.Image = Image.FromFile(caminhoImagem);

                // Salva o caminho da imagem no TextBox
                txtUrlFotoPerfil.Text = caminhoImagem;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            userDTO.NomeUsuario = txtNomeUsuario.Text;
            userDTO.EmailUsuario = txtEmailUsuario.Text;
            userDTO.SenhaUsuario = txtSenhaUsuario.Text;
            userDTO.UsuarioTipo = cboxTipoUsuario.SelectedValue.ToString();
            userDTO.UrlFotoPerfil = txtUrlFotoPerfil.Text;

            //Cadatrando o usuário
            userBLL.CreateUsuarioBLL(userDTO);

            MessageBox.Show($"Usuário {userDTO.NomeUsuario.ToUpper()} cadastrado com sucesso!");
            LoadDgvUsuario();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int idUser = int.Parse(txtIdUsuario.Text.Trim());
            userDTO = userBLL.SearchByIdUsuarioBLL(idUser);

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            userDTO.NomeUsuario = txtNomeUsuario.Text;
            userDTO.EmailUsuario = txtEmailUsuario.Text;
            userDTO.SenhaUsuario = txtSenhaUsuario.Text;
            userDTO.UrlFotoPerfil = txtUrlFotoPerfil.Text;
            userDTO.UsuarioTipo = cboxTipoUsuario.SelectedValue.ToString();

            userDTO.IdUsuario = int.Parse(txtIdUsuario.Text);
            userBLL.UpdateUsuarioBLL(userDTO);

            LoadDgvUsuario();

            MessageBox.Show($"Usuário {userDTO.NomeUsuario.ToUpper()} editado com sucesso !!");
        }
    }
}
