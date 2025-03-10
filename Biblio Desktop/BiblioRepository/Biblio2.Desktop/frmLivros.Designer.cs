namespace Biblio2.Desktop
{
    partial class frmLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivros));
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.txtSinopseLivro = new System.Windows.Forms.TextBox();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.lblIdLivro = new System.Windows.Forms.Label();
            this.lblGeneroLivro = new System.Windows.Forms.Label();
            this.lblAutorLivro = new System.Windows.Forms.Label();
            this.lblDataPublicacaoLivro = new System.Windows.Forms.Label();
            this.lblSinopseLivro = new System.Windows.Forms.Label();
            this.cboxGeneroLivro = new System.Windows.Forms.ComboBox();
            this.lblUrlFotoPerfil = new System.Windows.Forms.Label();
            this.txtUrlCapaLivro = new System.Windows.Forms.TextBox();
            this.lblUrlBannerLivro = new System.Windows.Forms.Label();
            this.btnUrlBannerLivro = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblBannerLivro = new System.Windows.Forms.Label();
            this.lblTituloLivroErro = new System.Windows.Forms.Label();
            this.lblGeneroLivroErro = new System.Windows.Forms.Label();
            this.lblAutorLivroErro = new System.Windows.Forms.Label();
            this.lblDataPublicacaoLivroErro = new System.Windows.Forms.Label();
            this.lblUrlIconLivro = new System.Windows.Forms.Label();
            this.txtUrlIconLivro = new System.Windows.Forms.TextBox();
            this.lblIconLivro = new System.Windows.Forms.Label();
            this.lblCapaLivro = new System.Windows.Forms.Label();
            this.lblUrlPDFLivro = new System.Windows.Forms.Label();
            this.txtUrlPDFLivro = new System.Windows.Forms.TextBox();
            this.btnUrlPDFLivro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtUrlBannerLivro = new System.Windows.Forms.TextBox();
            this.btnUrlIconLivro = new System.Windows.Forms.Button();
            this.lblPDFLivro = new System.Windows.Forms.Label();
            this.pbPDFconfirmacao = new System.Windows.Forms.PictureBox();
            this.pbUrlIconLivro = new System.Windows.Forms.PictureBox();
            this.pbUrlBannerLivro = new System.Windows.Forms.PictureBox();
            this.pbUrlCapaLivro = new System.Windows.Forms.PictureBox();
            this.lblIdLivroErro = new System.Windows.Forms.Label();
            this.lblSinopseLivroErro = new System.Windows.Forms.Label();
            this.btnUrlCapaLivro = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblUrlCapaLivroErro = new System.Windows.Forms.Label();
            this.lblUrlBannerLivroErro = new System.Windows.Forms.Label();
            this.lblUrlPDFLivroErro = new System.Windows.Forms.Label();
            this.lblUrlIconLivroErro = new System.Windows.Forms.Label();
            this.txtDataPublicacaoLivro = new System.Windows.Forms.MaskedTextBox();
            this.btnMudancaPesquisa = new System.Windows.Forms.Button();
            this.btnRemoverIcon = new System.Windows.Forms.Button();
            this.btnRemoverPDF = new System.Windows.Forms.Button();
            this.btnRemoverCapa = new System.Windows.Forms.Button();
            this.btnRemoverBanner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDFconfirmacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlIconLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlBannerLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlCapaLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivro
            // 
            this.dgvLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(12, 330);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(1362, 298);
            this.dgvLivro.TabIndex = 0;
            this.dgvLivro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellContentClick);
            this.dgvLivro.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLivro_CellMouseClick);
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(162, 28);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.ReadOnly = true;
            this.txtIdLivro.Size = new System.Drawing.Size(47, 20);
            this.txtIdLivro.TabIndex = 1;
            this.txtIdLivro.TextChanged += new System.EventHandler(this.txtIdLivro_TextChanged);
            this.txtIdLivro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdLivro_KeyPress);
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(12, 69);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(197, 20);
            this.txtTituloLivro.TabIndex = 2;
            this.txtTituloLivro.TextChanged += new System.EventHandler(this.txtTituloLivro_TextChanged);
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Location = new System.Drawing.Point(12, 148);
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.Size = new System.Drawing.Size(197, 20);
            this.txtAutorLivro.TabIndex = 3;
            this.txtAutorLivro.TextChanged += new System.EventHandler(this.txtAutorLivro_TextChanged);
            // 
            // txtSinopseLivro
            // 
            this.txtSinopseLivro.Location = new System.Drawing.Point(12, 226);
            this.txtSinopseLivro.Multiline = true;
            this.txtSinopseLivro.Name = "txtSinopseLivro";
            this.txtSinopseLivro.Size = new System.Drawing.Size(197, 73);
            this.txtSinopseLivro.TabIndex = 4;
            this.txtSinopseLivro.TextChanged += new System.EventHandler(this.txtSinopseLivro_TextChanged);
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloLivro.Location = new System.Drawing.Point(17, 51);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(35, 13);
            this.lblTituloLivro.TabIndex = 7;
            this.lblTituloLivro.Text = "Título";
            this.lblTituloLivro.Click += new System.EventHandler(this.lblTituloLivro_Click);
            // 
            // lblIdLivro
            // 
            this.lblIdLivro.AutoSize = true;
            this.lblIdLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblIdLivro.Location = new System.Drawing.Point(164, 12);
            this.lblIdLivro.Name = "lblIdLivro";
            this.lblIdLivro.Size = new System.Drawing.Size(18, 13);
            this.lblIdLivro.TabIndex = 8;
            this.lblIdLivro.Text = "ID";
            this.lblIdLivro.Click += new System.EventHandler(this.lblIdLivro_Click);
            // 
            // lblGeneroLivro
            // 
            this.lblGeneroLivro.AutoSize = true;
            this.lblGeneroLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblGeneroLivro.Location = new System.Drawing.Point(17, 92);
            this.lblGeneroLivro.Name = "lblGeneroLivro";
            this.lblGeneroLivro.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroLivro.TabIndex = 9;
            this.lblGeneroLivro.Text = "Gênero";
            this.lblGeneroLivro.Click += new System.EventHandler(this.lblGeneroLivro_Click);
            // 
            // lblAutorLivro
            // 
            this.lblAutorLivro.AutoSize = true;
            this.lblAutorLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAutorLivro.Location = new System.Drawing.Point(17, 132);
            this.lblAutorLivro.Name = "lblAutorLivro";
            this.lblAutorLivro.Size = new System.Drawing.Size(32, 13);
            this.lblAutorLivro.TabIndex = 10;
            this.lblAutorLivro.Text = "Autor";
            this.lblAutorLivro.Click += new System.EventHandler(this.lblAutorLivro_Click);
            // 
            // lblDataPublicacaoLivro
            // 
            this.lblDataPublicacaoLivro.AutoSize = true;
            this.lblDataPublicacaoLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDataPublicacaoLivro.Location = new System.Drawing.Point(17, 171);
            this.lblDataPublicacaoLivro.Name = "lblDataPublicacaoLivro";
            this.lblDataPublicacaoLivro.Size = new System.Drawing.Size(101, 13);
            this.lblDataPublicacaoLivro.TabIndex = 11;
            this.lblDataPublicacaoLivro.Text = "Data de Publicação";
            this.lblDataPublicacaoLivro.Click += new System.EventHandler(this.lblDataPublicacaoLivro_Click);
            // 
            // lblSinopseLivro
            // 
            this.lblSinopseLivro.AutoSize = true;
            this.lblSinopseLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSinopseLivro.Location = new System.Drawing.Point(17, 210);
            this.lblSinopseLivro.Name = "lblSinopseLivro";
            this.lblSinopseLivro.Size = new System.Drawing.Size(45, 13);
            this.lblSinopseLivro.TabIndex = 12;
            this.lblSinopseLivro.Text = "Sinopse";
            this.lblSinopseLivro.Click += new System.EventHandler(this.lblSinopseLivro_Click);
            // 
            // cboxGeneroLivro
            // 
            this.cboxGeneroLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGeneroLivro.FormattingEnabled = true;
            this.cboxGeneroLivro.Location = new System.Drawing.Point(12, 108);
            this.cboxGeneroLivro.Name = "cboxGeneroLivro";
            this.cboxGeneroLivro.Size = new System.Drawing.Size(197, 21);
            this.cboxGeneroLivro.TabIndex = 13;
            this.cboxGeneroLivro.SelectedIndexChanged += new System.EventHandler(this.cboxGeneroLivro_SelectedIndexChanged);
            // 
            // lblUrlFotoPerfil
            // 
            this.lblUrlFotoPerfil.AutoSize = true;
            this.lblUrlFotoPerfil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUrlFotoPerfil.Location = new System.Drawing.Point(403, 153);
            this.lblUrlFotoPerfil.Name = "lblUrlFotoPerfil";
            this.lblUrlFotoPerfil.Size = new System.Drawing.Size(72, 13);
            this.lblUrlFotoPerfil.TabIndex = 28;
            this.lblUrlFotoPerfil.Text = "URL da Capa";
            this.lblUrlFotoPerfil.Click += new System.EventHandler(this.lblUrlFotoPerfil_Click);
            // 
            // txtUrlCapaLivro
            // 
            this.txtUrlCapaLivro.Location = new System.Drawing.Point(403, 169);
            this.txtUrlCapaLivro.Name = "txtUrlCapaLivro";
            this.txtUrlCapaLivro.ReadOnly = true;
            this.txtUrlCapaLivro.Size = new System.Drawing.Size(300, 20);
            this.txtUrlCapaLivro.TabIndex = 27;
            this.txtUrlCapaLivro.TextChanged += new System.EventHandler(this.txtUrlCapaLivro_TextChanged);
            // 
            // lblUrlBannerLivro
            // 
            this.lblUrlBannerLivro.AutoSize = true;
            this.lblUrlBannerLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUrlBannerLivro.Location = new System.Drawing.Point(493, 263);
            this.lblUrlBannerLivro.Name = "lblUrlBannerLivro";
            this.lblUrlBannerLivro.Size = new System.Drawing.Size(81, 13);
            this.lblUrlBannerLivro.TabIndex = 36;
            this.lblUrlBannerLivro.Text = "URL do Banner";
            this.lblUrlBannerLivro.Click += new System.EventHandler(this.lblUrlBannerLivro_Click);
            // 
            // btnUrlBannerLivro
            // 
            this.btnUrlBannerLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUrlBannerLivro.Location = new System.Drawing.Point(591, 224);
            this.btnUrlBannerLivro.Name = "btnUrlBannerLivro";
            this.btnUrlBannerLivro.Size = new System.Drawing.Size(150, 33);
            this.btnUrlBannerLivro.TabIndex = 34;
            this.btnUrlBannerLivro.Text = "Selecionar Arquivo";
            this.btnUrlBannerLivro.UseVisualStyleBackColor = true;
            this.btnUrlBannerLivro.Click += new System.EventHandler(this.btnUrlBannerLivro_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Location = new System.Drawing.Point(93, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(63, 37);
            this.btnPesquisar.TabIndex = 41;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblBannerLivro
            // 
            this.lblBannerLivro.AutoSize = true;
            this.lblBannerLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBannerLivro.Location = new System.Drawing.Point(312, 210);
            this.lblBannerLivro.Name = "lblBannerLivro";
            this.lblBannerLivro.Size = new System.Drawing.Size(133, 13);
            this.lblBannerLivro.TabIndex = 43;
            this.lblBannerLivro.Text = "Banner do Livro (Opcional)";
            this.lblBannerLivro.Click += new System.EventHandler(this.lblBannerLivro_Click);
            // 
            // lblTituloLivroErro
            // 
            this.lblTituloLivroErro.AutoSize = true;
            this.lblTituloLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblTituloLivroErro.Location = new System.Drawing.Point(215, 72);
            this.lblTituloLivroErro.Name = "lblTituloLivroErro";
            this.lblTituloLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblTituloLivroErro.TabIndex = 45;
            this.lblTituloLivroErro.Text = "Aviso2";
            this.lblTituloLivroErro.Click += new System.EventHandler(this.lblTituloLivroErro_Click);
            // 
            // lblGeneroLivroErro
            // 
            this.lblGeneroLivroErro.AutoSize = true;
            this.lblGeneroLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblGeneroLivroErro.Location = new System.Drawing.Point(215, 111);
            this.lblGeneroLivroErro.Name = "lblGeneroLivroErro";
            this.lblGeneroLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblGeneroLivroErro.TabIndex = 46;
            this.lblGeneroLivroErro.Text = "Aviso3";
            this.lblGeneroLivroErro.Click += new System.EventHandler(this.lblGeneroLivroErro_Click);
            // 
            // lblAutorLivroErro
            // 
            this.lblAutorLivroErro.AutoSize = true;
            this.lblAutorLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblAutorLivroErro.Location = new System.Drawing.Point(215, 151);
            this.lblAutorLivroErro.Name = "lblAutorLivroErro";
            this.lblAutorLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblAutorLivroErro.TabIndex = 47;
            this.lblAutorLivroErro.Text = "Aviso4";
            this.lblAutorLivroErro.Click += new System.EventHandler(this.lblAutorLivroErro_Click);
            // 
            // lblDataPublicacaoLivroErro
            // 
            this.lblDataPublicacaoLivroErro.AutoSize = true;
            this.lblDataPublicacaoLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblDataPublicacaoLivroErro.Location = new System.Drawing.Point(215, 190);
            this.lblDataPublicacaoLivroErro.Name = "lblDataPublicacaoLivroErro";
            this.lblDataPublicacaoLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblDataPublicacaoLivroErro.TabIndex = 48;
            this.lblDataPublicacaoLivroErro.Text = "Aviso5";
            this.lblDataPublicacaoLivroErro.Click += new System.EventHandler(this.lblDataPublicacaoLivroErro_Click);
            // 
            // lblUrlIconLivro
            // 
            this.lblUrlIconLivro.AutoSize = true;
            this.lblUrlIconLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUrlIconLivro.Location = new System.Drawing.Point(901, 153);
            this.lblUrlIconLivro.Name = "lblUrlIconLivro";
            this.lblUrlIconLivro.Size = new System.Drawing.Size(74, 13);
            this.lblUrlIconLivro.TabIndex = 52;
            this.lblUrlIconLivro.Text = "URL do Ícone";
            this.lblUrlIconLivro.Click += new System.EventHandler(this.lblUrlIconLivro_Click);
            // 
            // txtUrlIconLivro
            // 
            this.txtUrlIconLivro.Location = new System.Drawing.Point(811, 169);
            this.txtUrlIconLivro.Name = "txtUrlIconLivro";
            this.txtUrlIconLivro.ReadOnly = true;
            this.txtUrlIconLivro.Size = new System.Drawing.Size(300, 20);
            this.txtUrlIconLivro.TabIndex = 51;
            this.txtUrlIconLivro.TextChanged += new System.EventHandler(this.txtUrlIconLivro_TextChanged);
            // 
            // lblIconLivro
            // 
            this.lblIconLivro.AutoSize = true;
            this.lblIconLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblIconLivro.Location = new System.Drawing.Point(811, 73);
            this.lblIconLivro.Name = "lblIconLivro";
            this.lblIconLivro.Size = new System.Drawing.Size(75, 13);
            this.lblIconLivro.TabIndex = 53;
            this.lblIconLivro.Text = "Ícone do Livro";
            this.lblIconLivro.Click += new System.EventHandler(this.lblIconLivro_Click);
            // 
            // lblCapaLivro
            // 
            this.lblCapaLivro.AutoSize = true;
            this.lblCapaLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCapaLivro.Location = new System.Drawing.Point(312, 53);
            this.lblCapaLivro.Name = "lblCapaLivro";
            this.lblCapaLivro.Size = new System.Drawing.Size(73, 13);
            this.lblCapaLivro.TabIndex = 54;
            this.lblCapaLivro.Text = "Capa do Livro";
            this.lblCapaLivro.Click += new System.EventHandler(this.lblCapaLivro_Click);
            // 
            // lblUrlPDFLivro
            // 
            this.lblUrlPDFLivro.AutoSize = true;
            this.lblUrlPDFLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUrlPDFLivro.Location = new System.Drawing.Point(811, 263);
            this.lblUrlPDFLivro.Name = "lblUrlPDFLivro";
            this.lblUrlPDFLivro.Size = new System.Drawing.Size(68, 13);
            this.lblUrlPDFLivro.TabIndex = 58;
            this.lblUrlPDFLivro.Text = "URL do PDF";
            this.lblUrlPDFLivro.Click += new System.EventHandler(this.lblUrlPDFLivro_Click);
            // 
            // txtUrlPDFLivro
            // 
            this.txtUrlPDFLivro.Location = new System.Drawing.Point(811, 279);
            this.txtUrlPDFLivro.Name = "txtUrlPDFLivro";
            this.txtUrlPDFLivro.ReadOnly = true;
            this.txtUrlPDFLivro.Size = new System.Drawing.Size(300, 20);
            this.txtUrlPDFLivro.TabIndex = 57;
            this.txtUrlPDFLivro.TextChanged += new System.EventHandler(this.txtUrlPDFLivro_TextChanged);
            // 
            // btnUrlPDFLivro
            // 
            this.btnUrlPDFLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUrlPDFLivro.Location = new System.Drawing.Point(909, 225);
            this.btnUrlPDFLivro.Name = "btnUrlPDFLivro";
            this.btnUrlPDFLivro.Size = new System.Drawing.Size(118, 32);
            this.btnUrlPDFLivro.TabIndex = 56;
            this.btnUrlPDFLivro.Text = "Selecionar PDF";
            this.btnUrlPDFLivro.UseVisualStyleBackColor = true;
            this.btnUrlPDFLivro.Click += new System.EventHandler(this.btnUrlPDFLivro_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(1175, 145);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 50);
            this.btnCadastrar.TabIndex = 61;
            this.btnCadastrar.Text = "Cadastrar Livro";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.Enabled = false;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(1175, 201);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 50);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletar.Location = new System.Drawing.Point(1175, 257);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(200, 50);
            this.btnDeletar.TabIndex = 63;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtUrlBannerLivro
            // 
            this.txtUrlBannerLivro.Location = new System.Drawing.Point(493, 279);
            this.txtUrlBannerLivro.Name = "txtUrlBannerLivro";
            this.txtUrlBannerLivro.ReadOnly = true;
            this.txtUrlBannerLivro.Size = new System.Drawing.Size(300, 20);
            this.txtUrlBannerLivro.TabIndex = 64;
            this.txtUrlBannerLivro.TextChanged += new System.EventHandler(this.txtUrlBannerLivro_TextChanged);
            // 
            // btnUrlIconLivro
            // 
            this.btnUrlIconLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUrlIconLivro.Location = new System.Drawing.Point(999, 116);
            this.btnUrlIconLivro.Name = "btnUrlIconLivro";
            this.btnUrlIconLivro.Size = new System.Drawing.Size(112, 34);
            this.btnUrlIconLivro.TabIndex = 66;
            this.btnUrlIconLivro.Text = "Selecionar Arquivo";
            this.btnUrlIconLivro.UseVisualStyleBackColor = true;
            this.btnUrlIconLivro.Click += new System.EventHandler(this.btnUrlIconLivro_Click);
            // 
            // lblPDFLivro
            // 
            this.lblPDFLivro.AutoSize = true;
            this.lblPDFLivro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPDFLivro.Location = new System.Drawing.Point(811, 209);
            this.lblPDFLivro.Name = "lblPDFLivro";
            this.lblPDFLivro.Size = new System.Drawing.Size(69, 13);
            this.lblPDFLivro.TabIndex = 68;
            this.lblPDFLivro.Text = "PDF do Livro";
            this.lblPDFLivro.Click += new System.EventHandler(this.lblPDFLivro_Click);
            // 
            // pbPDFconfirmacao
            // 
            this.pbPDFconfirmacao.Image = ((System.Drawing.Image)(resources.GetObject("pbPDFconfirmacao.Image")));
            this.pbPDFconfirmacao.Location = new System.Drawing.Point(1033, 225);
            this.pbPDFconfirmacao.Name = "pbPDFconfirmacao";
            this.pbPDFconfirmacao.Size = new System.Drawing.Size(34, 32);
            this.pbPDFconfirmacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPDFconfirmacao.TabIndex = 67;
            this.pbPDFconfirmacao.TabStop = false;
            this.pbPDFconfirmacao.Click += new System.EventHandler(this.pbPDFconfirmacao_Click);
            // 
            // pbUrlIconLivro
            // 
            this.pbUrlIconLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrlIconLivro.Location = new System.Drawing.Point(811, 89);
            this.pbUrlIconLivro.Name = "pbUrlIconLivro";
            this.pbUrlIconLivro.Size = new System.Drawing.Size(84, 77);
            this.pbUrlIconLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrlIconLivro.TabIndex = 49;
            this.pbUrlIconLivro.TabStop = false;
            this.pbUrlIconLivro.Click += new System.EventHandler(this.pbUrlIconLivro_Click);
            // 
            // pbUrlBannerLivro
            // 
            this.pbUrlBannerLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrlBannerLivro.Location = new System.Drawing.Point(315, 226);
            this.pbUrlBannerLivro.Name = "pbUrlBannerLivro";
            this.pbUrlBannerLivro.Size = new System.Drawing.Size(172, 73);
            this.pbUrlBannerLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrlBannerLivro.TabIndex = 33;
            this.pbUrlBannerLivro.TabStop = false;
            this.pbUrlBannerLivro.Click += new System.EventHandler(this.pbUrlBannerLivro_Click);
            // 
            // pbUrlCapaLivro
            // 
            this.pbUrlCapaLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrlCapaLivro.Location = new System.Drawing.Point(315, 69);
            this.pbUrlCapaLivro.Name = "pbUrlCapaLivro";
            this.pbUrlCapaLivro.Size = new System.Drawing.Size(82, 122);
            this.pbUrlCapaLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrlCapaLivro.TabIndex = 25;
            this.pbUrlCapaLivro.TabStop = false;
            this.pbUrlCapaLivro.Click += new System.EventHandler(this.pbUrlCapaLivro_Click);
            // 
            // lblIdLivroErro
            // 
            this.lblIdLivroErro.AutoSize = true;
            this.lblIdLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblIdLivroErro.Location = new System.Drawing.Point(215, 31);
            this.lblIdLivroErro.Name = "lblIdLivroErro";
            this.lblIdLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblIdLivroErro.TabIndex = 69;
            this.lblIdLivroErro.Text = "Aviso1";
            this.lblIdLivroErro.Click += new System.EventHandler(this.lblIdLivroErro_Click);
            // 
            // lblSinopseLivroErro
            // 
            this.lblSinopseLivroErro.AutoSize = true;
            this.lblSinopseLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblSinopseLivroErro.Location = new System.Drawing.Point(215, 229);
            this.lblSinopseLivroErro.Name = "lblSinopseLivroErro";
            this.lblSinopseLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblSinopseLivroErro.TabIndex = 70;
            this.lblSinopseLivroErro.Text = "Aviso6";
            this.lblSinopseLivroErro.Click += new System.EventHandler(this.lblSinopseLivroErro_Click);
            // 
            // btnUrlCapaLivro
            // 
            this.btnUrlCapaLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUrlCapaLivro.Location = new System.Drawing.Point(501, 108);
            this.btnUrlCapaLivro.Name = "btnUrlCapaLivro";
            this.btnUrlCapaLivro.Size = new System.Drawing.Size(136, 34);
            this.btnUrlCapaLivro.TabIndex = 71;
            this.btnUrlCapaLivro.Text = "Selecionar Arquivo";
            this.btnUrlCapaLivro.UseVisualStyleBackColor = true;
            this.btnUrlCapaLivro.Click += new System.EventHandler(this.btnUrlCapaLivro_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // lblPagina
            // 
            this.lblPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPagina.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPagina.Location = new System.Drawing.Point(1287, 9);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(87, 31);
            this.lblPagina.TabIndex = 72;
            this.lblPagina.Text = "Livros";
            this.lblPagina.Click += new System.EventHandler(this.lblPagina_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(1175, 89);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 50);
            this.btnLimpar.TabIndex = 60;
            this.btnLimpar.Text = "Limpar Campo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblUrlCapaLivroErro
            // 
            this.lblUrlCapaLivroErro.AutoSize = true;
            this.lblUrlCapaLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblUrlCapaLivroErro.Location = new System.Drawing.Point(481, 153);
            this.lblUrlCapaLivroErro.Name = "lblUrlCapaLivroErro";
            this.lblUrlCapaLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblUrlCapaLivroErro.TabIndex = 73;
            this.lblUrlCapaLivroErro.Text = "Aviso7";
            this.lblUrlCapaLivroErro.Click += new System.EventHandler(this.lblUrlCapaLivroErro_Click);
            // 
            // lblUrlBannerLivroErro
            // 
            this.lblUrlBannerLivroErro.AutoSize = true;
            this.lblUrlBannerLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblUrlBannerLivroErro.Location = new System.Drawing.Point(580, 263);
            this.lblUrlBannerLivroErro.Name = "lblUrlBannerLivroErro";
            this.lblUrlBannerLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblUrlBannerLivroErro.TabIndex = 74;
            this.lblUrlBannerLivroErro.Text = "Aviso8";
            this.lblUrlBannerLivroErro.Click += new System.EventHandler(this.lblUrlBannerLivroErro_Click);
            // 
            // lblUrlPDFLivroErro
            // 
            this.lblUrlPDFLivroErro.AutoSize = true;
            this.lblUrlPDFLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblUrlPDFLivroErro.Location = new System.Drawing.Point(885, 263);
            this.lblUrlPDFLivroErro.Name = "lblUrlPDFLivroErro";
            this.lblUrlPDFLivroErro.Size = new System.Drawing.Size(45, 13);
            this.lblUrlPDFLivroErro.TabIndex = 75;
            this.lblUrlPDFLivroErro.Text = "Aviso10";
            this.lblUrlPDFLivroErro.Click += new System.EventHandler(this.lblUrlPDFLivroErro_Click);
            // 
            // lblUrlIconLivroErro
            // 
            this.lblUrlIconLivroErro.AutoSize = true;
            this.lblUrlIconLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblUrlIconLivroErro.Location = new System.Drawing.Point(981, 153);
            this.lblUrlIconLivroErro.Name = "lblUrlIconLivroErro";
            this.lblUrlIconLivroErro.Size = new System.Drawing.Size(39, 13);
            this.lblUrlIconLivroErro.TabIndex = 76;
            this.lblUrlIconLivroErro.Text = "Aviso9";
            this.lblUrlIconLivroErro.Click += new System.EventHandler(this.lblUrlIconLivroErro_Click);
            // 
            // txtDataPublicacaoLivro
            // 
            this.txtDataPublicacaoLivro.Location = new System.Drawing.Point(12, 187);
            this.txtDataPublicacaoLivro.Mask = "00/00/0000";
            this.txtDataPublicacaoLivro.Name = "txtDataPublicacaoLivro";
            this.txtDataPublicacaoLivro.Size = new System.Drawing.Size(197, 20);
            this.txtDataPublicacaoLivro.TabIndex = 77;
            this.txtDataPublicacaoLivro.ValidatingType = typeof(System.DateTime);
            this.txtDataPublicacaoLivro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataPublicacaoLivro_MaskInputRejected);
            // 
            // btnMudancaPesquisa
            // 
            this.btnMudancaPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMudancaPesquisa.Location = new System.Drawing.Point(12, 11);
            this.btnMudancaPesquisa.Name = "btnMudancaPesquisa";
            this.btnMudancaPesquisa.Size = new System.Drawing.Size(75, 37);
            this.btnMudancaPesquisa.TabIndex = 78;
            this.btnMudancaPesquisa.Text = "Selecionar por ID";
            this.btnMudancaPesquisa.UseVisualStyleBackColor = true;
            this.btnMudancaPesquisa.Click += new System.EventHandler(this.btnMudancaPesquisa_Click);
            // 
            // btnRemoverIcon
            // 
            this.btnRemoverIcon.Enabled = false;
            this.btnRemoverIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoverIcon.Location = new System.Drawing.Point(901, 116);
            this.btnRemoverIcon.Name = "btnRemoverIcon";
            this.btnRemoverIcon.Size = new System.Drawing.Size(92, 34);
            this.btnRemoverIcon.TabIndex = 80;
            this.btnRemoverIcon.Text = "Remover Arquivo";
            this.btnRemoverIcon.UseVisualStyleBackColor = true;
            this.btnRemoverIcon.Click += new System.EventHandler(this.btnRemoverIcon_Click);
            // 
            // btnRemoverPDF
            // 
            this.btnRemoverPDF.Enabled = false;
            this.btnRemoverPDF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoverPDF.Location = new System.Drawing.Point(811, 224);
            this.btnRemoverPDF.Name = "btnRemoverPDF";
            this.btnRemoverPDF.Size = new System.Drawing.Size(92, 34);
            this.btnRemoverPDF.TabIndex = 81;
            this.btnRemoverPDF.Text = "Remover Arquivo";
            this.btnRemoverPDF.UseVisualStyleBackColor = true;
            this.btnRemoverPDF.Click += new System.EventHandler(this.btnRemoverPDF_Click);
            // 
            // btnRemoverCapa
            // 
            this.btnRemoverCapa.Enabled = false;
            this.btnRemoverCapa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoverCapa.Location = new System.Drawing.Point(403, 108);
            this.btnRemoverCapa.Name = "btnRemoverCapa";
            this.btnRemoverCapa.Size = new System.Drawing.Size(92, 34);
            this.btnRemoverCapa.TabIndex = 82;
            this.btnRemoverCapa.Text = "Remover Arquivo";
            this.btnRemoverCapa.UseVisualStyleBackColor = true;
            this.btnRemoverCapa.Click += new System.EventHandler(this.btnRemoverCapa_Click);
            // 
            // btnRemoverBanner
            // 
            this.btnRemoverBanner.Enabled = false;
            this.btnRemoverBanner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoverBanner.Location = new System.Drawing.Point(493, 223);
            this.btnRemoverBanner.Name = "btnRemoverBanner";
            this.btnRemoverBanner.Size = new System.Drawing.Size(92, 34);
            this.btnRemoverBanner.TabIndex = 83;
            this.btnRemoverBanner.Text = "Remover Arquivo";
            this.btnRemoverBanner.UseVisualStyleBackColor = true;
            this.btnRemoverBanner.Click += new System.EventHandler(this.btnRemoverBanner_Click);
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1386, 640);
            this.Controls.Add(this.btnRemoverBanner);
            this.Controls.Add(this.btnRemoverCapa);
            this.Controls.Add(this.btnRemoverPDF);
            this.Controls.Add(this.btnRemoverIcon);
            this.Controls.Add(this.btnMudancaPesquisa);
            this.Controls.Add(this.txtDataPublicacaoLivro);
            this.Controls.Add(this.lblUrlIconLivroErro);
            this.Controls.Add(this.lblUrlPDFLivroErro);
            this.Controls.Add(this.lblUrlBannerLivroErro);
            this.Controls.Add(this.lblUrlCapaLivroErro);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnUrlCapaLivro);
            this.Controls.Add(this.lblSinopseLivroErro);
            this.Controls.Add(this.lblIdLivroErro);
            this.Controls.Add(this.lblPDFLivro);
            this.Controls.Add(this.pbPDFconfirmacao);
            this.Controls.Add(this.btnUrlIconLivro);
            this.Controls.Add(this.txtUrlBannerLivro);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblUrlPDFLivro);
            this.Controls.Add(this.txtUrlPDFLivro);
            this.Controls.Add(this.btnUrlPDFLivro);
            this.Controls.Add(this.lblCapaLivro);
            this.Controls.Add(this.lblIconLivro);
            this.Controls.Add(this.lblUrlIconLivro);
            this.Controls.Add(this.txtUrlIconLivro);
            this.Controls.Add(this.pbUrlIconLivro);
            this.Controls.Add(this.lblDataPublicacaoLivroErro);
            this.Controls.Add(this.lblAutorLivroErro);
            this.Controls.Add(this.lblGeneroLivroErro);
            this.Controls.Add(this.lblTituloLivroErro);
            this.Controls.Add(this.lblBannerLivro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblUrlBannerLivro);
            this.Controls.Add(this.btnUrlBannerLivro);
            this.Controls.Add(this.pbUrlBannerLivro);
            this.Controls.Add(this.lblUrlFotoPerfil);
            this.Controls.Add(this.txtUrlCapaLivro);
            this.Controls.Add(this.pbUrlCapaLivro);
            this.Controls.Add(this.cboxGeneroLivro);
            this.Controls.Add(this.lblSinopseLivro);
            this.Controls.Add(this.lblDataPublicacaoLivro);
            this.Controls.Add(this.lblAutorLivro);
            this.Controls.Add(this.lblGeneroLivro);
            this.Controls.Add(this.lblIdLivro);
            this.Controls.Add(this.lblTituloLivro);
            this.Controls.Add(this.txtSinopseLivro);
            this.Controls.Add(this.txtAutorLivro);
            this.Controls.Add(this.txtTituloLivro);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.dgvLivro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmLivros";
            this.Load += new System.EventHandler(this.frmLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDFconfirmacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlIconLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlBannerLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlCapaLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.TextBox txtAutorLivro;
        private System.Windows.Forms.TextBox txtSinopseLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Label lblIdLivro;
        private System.Windows.Forms.Label lblGeneroLivro;
        private System.Windows.Forms.Label lblAutorLivro;
        private System.Windows.Forms.Label lblDataPublicacaoLivro;
        private System.Windows.Forms.Label lblSinopseLivro;
        private System.Windows.Forms.ComboBox cboxGeneroLivro;
        private System.Windows.Forms.Label lblUrlFotoPerfil;
        private System.Windows.Forms.TextBox txtUrlCapaLivro;
        private System.Windows.Forms.PictureBox pbUrlCapaLivro;
        private System.Windows.Forms.Label lblUrlBannerLivro;
        private System.Windows.Forms.Button btnUrlBannerLivro;
        private System.Windows.Forms.PictureBox pbUrlBannerLivro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblBannerLivro;
        private System.Windows.Forms.Label lblTituloLivroErro;
        private System.Windows.Forms.Label lblGeneroLivroErro;
        private System.Windows.Forms.Label lblAutorLivroErro;
        private System.Windows.Forms.Label lblDataPublicacaoLivroErro;
        private System.Windows.Forms.Label lblUrlIconLivro;
        private System.Windows.Forms.TextBox txtUrlIconLivro;
        private System.Windows.Forms.PictureBox pbUrlIconLivro;
        private System.Windows.Forms.Label lblIconLivro;
        private System.Windows.Forms.Label lblCapaLivro;
        private System.Windows.Forms.Label lblUrlPDFLivro;
        private System.Windows.Forms.TextBox txtUrlPDFLivro;
        private System.Windows.Forms.Button btnUrlPDFLivro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtUrlBannerLivro;
        private System.Windows.Forms.Button btnUrlIconLivro;
        private System.Windows.Forms.PictureBox pbPDFconfirmacao;
        private System.Windows.Forms.Label lblPDFLivro;
        private System.Windows.Forms.Label lblIdLivroErro;
        private System.Windows.Forms.Label lblSinopseLivroErro;
        private System.Windows.Forms.Button btnUrlCapaLivro;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblUrlCapaLivroErro;
        private System.Windows.Forms.Label lblUrlBannerLivroErro;
        private System.Windows.Forms.Label lblUrlPDFLivroErro;
        private System.Windows.Forms.Label lblUrlIconLivroErro;
        private System.Windows.Forms.MaskedTextBox txtDataPublicacaoLivro;
        private System.Windows.Forms.Button btnMudancaPesquisa;
        private System.Windows.Forms.Button btnRemoverIcon;
        private System.Windows.Forms.Button btnRemoverPDF;
        private System.Windows.Forms.Button btnRemoverCapa;
        private System.Windows.Forms.Button btnRemoverBanner;
    }
}