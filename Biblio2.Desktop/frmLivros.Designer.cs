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
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.txtSinopseLivro = new System.Windows.Forms.TextBox();
            this.txtDataPublicacaoLivro = new System.Windows.Forms.TextBox();
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
            this.btnLimpar = new System.Windows.Forms.Button();
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
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(12, 306);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(1116, 322);
            this.dgvLivro.TabIndex = 0;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(162, 28);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(47, 20);
            this.txtIdLivro.TabIndex = 1;
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(25, 69);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(184, 20);
            this.txtTituloLivro.TabIndex = 2;
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Location = new System.Drawing.Point(25, 148);
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.Size = new System.Drawing.Size(184, 20);
            this.txtAutorLivro.TabIndex = 3;
            // 
            // txtSinopseLivro
            // 
            this.txtSinopseLivro.Location = new System.Drawing.Point(25, 226);
            this.txtSinopseLivro.Multiline = true;
            this.txtSinopseLivro.Name = "txtSinopseLivro";
            this.txtSinopseLivro.Size = new System.Drawing.Size(184, 73);
            this.txtSinopseLivro.TabIndex = 4;
            // 
            // txtDataPublicacaoLivro
            // 
            this.txtDataPublicacaoLivro.Location = new System.Drawing.Point(25, 187);
            this.txtDataPublicacaoLivro.Name = "txtDataPublicacaoLivro";
            this.txtDataPublicacaoLivro.Size = new System.Drawing.Size(184, 20);
            this.txtDataPublicacaoLivro.TabIndex = 6;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Location = new System.Drawing.Point(27, 53);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(35, 13);
            this.lblTituloLivro.TabIndex = 7;
            this.lblTituloLivro.Text = "Título";
            // 
            // lblIdLivro
            // 
            this.lblIdLivro.AutoSize = true;
            this.lblIdLivro.Location = new System.Drawing.Point(164, 12);
            this.lblIdLivro.Name = "lblIdLivro";
            this.lblIdLivro.Size = new System.Drawing.Size(18, 13);
            this.lblIdLivro.TabIndex = 8;
            this.lblIdLivro.Text = "ID";
            // 
            // lblGeneroLivro
            // 
            this.lblGeneroLivro.AutoSize = true;
            this.lblGeneroLivro.Location = new System.Drawing.Point(27, 92);
            this.lblGeneroLivro.Name = "lblGeneroLivro";
            this.lblGeneroLivro.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroLivro.TabIndex = 9;
            this.lblGeneroLivro.Text = "Gênero";
            // 
            // lblAutorLivro
            // 
            this.lblAutorLivro.AutoSize = true;
            this.lblAutorLivro.Location = new System.Drawing.Point(27, 132);
            this.lblAutorLivro.Name = "lblAutorLivro";
            this.lblAutorLivro.Size = new System.Drawing.Size(32, 13);
            this.lblAutorLivro.TabIndex = 10;
            this.lblAutorLivro.Text = "Autor";
            // 
            // lblDataPublicacaoLivro
            // 
            this.lblDataPublicacaoLivro.AutoSize = true;
            this.lblDataPublicacaoLivro.Location = new System.Drawing.Point(27, 171);
            this.lblDataPublicacaoLivro.Name = "lblDataPublicacaoLivro";
            this.lblDataPublicacaoLivro.Size = new System.Drawing.Size(101, 13);
            this.lblDataPublicacaoLivro.TabIndex = 11;
            this.lblDataPublicacaoLivro.Text = "Data de Publicação";
            // 
            // lblSinopseLivro
            // 
            this.lblSinopseLivro.AutoSize = true;
            this.lblSinopseLivro.Location = new System.Drawing.Point(27, 210);
            this.lblSinopseLivro.Name = "lblSinopseLivro";
            this.lblSinopseLivro.Size = new System.Drawing.Size(45, 13);
            this.lblSinopseLivro.TabIndex = 12;
            this.lblSinopseLivro.Text = "Sinopse";
            // 
            // cboxGeneroLivro
            // 
            this.cboxGeneroLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGeneroLivro.FormattingEnabled = true;
            this.cboxGeneroLivro.Location = new System.Drawing.Point(25, 108);
            this.cboxGeneroLivro.Name = "cboxGeneroLivro";
            this.cboxGeneroLivro.Size = new System.Drawing.Size(184, 21);
            this.cboxGeneroLivro.TabIndex = 13;
            // 
            // lblUrlFotoPerfil
            // 
            this.lblUrlFotoPerfil.AutoSize = true;
            this.lblUrlFotoPerfil.Location = new System.Drawing.Point(403, 153);
            this.lblUrlFotoPerfil.Name = "lblUrlFotoPerfil";
            this.lblUrlFotoPerfil.Size = new System.Drawing.Size(72, 13);
            this.lblUrlFotoPerfil.TabIndex = 28;
            this.lblUrlFotoPerfil.Text = "URL da Capa";
            // 
            // txtUrlCapaLivro
            // 
            this.txtUrlCapaLivro.Location = new System.Drawing.Point(403, 169);
            this.txtUrlCapaLivro.Name = "txtUrlCapaLivro";
            this.txtUrlCapaLivro.Size = new System.Drawing.Size(136, 20);
            this.txtUrlCapaLivro.TabIndex = 27;
            // 
            // lblUrlBannerLivro
            // 
            this.lblUrlBannerLivro.AutoSize = true;
            this.lblUrlBannerLivro.Location = new System.Drawing.Point(493, 263);
            this.lblUrlBannerLivro.Name = "lblUrlBannerLivro";
            this.lblUrlBannerLivro.Size = new System.Drawing.Size(81, 13);
            this.lblUrlBannerLivro.TabIndex = 36;
            this.lblUrlBannerLivro.Text = "URL do Banner";
            // 
            // btnUrlBannerLivro
            // 
            this.btnUrlBannerLivro.Location = new System.Drawing.Point(493, 227);
            this.btnUrlBannerLivro.Name = "btnUrlBannerLivro";
            this.btnUrlBannerLivro.Size = new System.Drawing.Size(150, 33);
            this.btnUrlBannerLivro.TabIndex = 34;
            this.btnUrlBannerLivro.Text = "Selecionar Arquivo";
            this.btnUrlBannerLivro.UseVisualStyleBackColor = true;
            this.btnUrlBannerLivro.Click += new System.EventHandler(this.btnUrlBannerLivro_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(25, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 37);
            this.btnPesquisar.TabIndex = 41;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblBannerLivro
            // 
            this.lblBannerLivro.AutoSize = true;
            this.lblBannerLivro.Location = new System.Drawing.Point(312, 210);
            this.lblBannerLivro.Name = "lblBannerLivro";
            this.lblBannerLivro.Size = new System.Drawing.Size(133, 13);
            this.lblBannerLivro.TabIndex = 43;
            this.lblBannerLivro.Text = "Banner do Livro (Opcional)";
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
            // 
            // lblUrlIconLivro
            // 
            this.lblUrlIconLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlIconLivro.AutoSize = true;
            this.lblUrlIconLivro.Location = new System.Drawing.Point(785, 154);
            this.lblUrlIconLivro.Name = "lblUrlIconLivro";
            this.lblUrlIconLivro.Size = new System.Drawing.Size(74, 13);
            this.lblUrlIconLivro.TabIndex = 52;
            this.lblUrlIconLivro.Text = "URL do Ícone";
            // 
            // txtUrlIconLivro
            // 
            this.txtUrlIconLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlIconLivro.Location = new System.Drawing.Point(785, 170);
            this.txtUrlIconLivro.Name = "txtUrlIconLivro";
            this.txtUrlIconLivro.Size = new System.Drawing.Size(158, 20);
            this.txtUrlIconLivro.TabIndex = 51;
            // 
            // lblIconLivro
            // 
            this.lblIconLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconLivro.AutoSize = true;
            this.lblIconLivro.Location = new System.Drawing.Point(695, 94);
            this.lblIconLivro.Name = "lblIconLivro";
            this.lblIconLivro.Size = new System.Drawing.Size(75, 13);
            this.lblIconLivro.TabIndex = 53;
            this.lblIconLivro.Text = "Ícone do Livro";
            // 
            // lblCapaLivro
            // 
            this.lblCapaLivro.AutoSize = true;
            this.lblCapaLivro.Location = new System.Drawing.Point(312, 53);
            this.lblCapaLivro.Name = "lblCapaLivro";
            this.lblCapaLivro.Size = new System.Drawing.Size(73, 13);
            this.lblCapaLivro.TabIndex = 54;
            this.lblCapaLivro.Text = "Capa do Livro";
            // 
            // lblUrlPDFLivro
            // 
            this.lblUrlPDFLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlPDFLivro.AutoSize = true;
            this.lblUrlPDFLivro.Location = new System.Drawing.Point(695, 264);
            this.lblUrlPDFLivro.Name = "lblUrlPDFLivro";
            this.lblUrlPDFLivro.Size = new System.Drawing.Size(68, 13);
            this.lblUrlPDFLivro.TabIndex = 58;
            this.lblUrlPDFLivro.Text = "URL do PDF";
            // 
            // txtUrlPDFLivro
            // 
            this.txtUrlPDFLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlPDFLivro.Location = new System.Drawing.Point(695, 280);
            this.txtUrlPDFLivro.Name = "txtUrlPDFLivro";
            this.txtUrlPDFLivro.Size = new System.Drawing.Size(248, 20);
            this.txtUrlPDFLivro.TabIndex = 57;
            // 
            // btnUrlPDFLivro
            // 
            this.btnUrlPDFLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrlPDFLivro.Location = new System.Drawing.Point(695, 226);
            this.btnUrlPDFLivro.Name = "btnUrlPDFLivro";
            this.btnUrlPDFLivro.Size = new System.Drawing.Size(118, 32);
            this.btnUrlPDFLivro.TabIndex = 56;
            this.btnUrlPDFLivro.Text = "Selecionar PDF";
            this.btnUrlPDFLivro.UseVisualStyleBackColor = true;
            this.btnUrlPDFLivro.Click += new System.EventHandler(this.btnUrlPDFLivro_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(966, 92);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(162, 47);
            this.btnLimpar.TabIndex = 60;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(966, 145);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 47);
            this.btnCadastrar.TabIndex = 61;
            this.btnCadastrar.Text = "Cadastrar Livro";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(966, 199);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(162, 47);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.Location = new System.Drawing.Point(966, 252);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(162, 47);
            this.btnDeletar.TabIndex = 63;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtUrlBannerLivro
            // 
            this.txtUrlBannerLivro.Location = new System.Drawing.Point(493, 279);
            this.txtUrlBannerLivro.Name = "txtUrlBannerLivro";
            this.txtUrlBannerLivro.Size = new System.Drawing.Size(150, 20);
            this.txtUrlBannerLivro.TabIndex = 64;
            // 
            // btnUrlIconLivro
            // 
            this.btnUrlIconLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrlIconLivro.Location = new System.Drawing.Point(785, 113);
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
            this.lblPDFLivro.Location = new System.Drawing.Point(695, 210);
            this.lblPDFLivro.Name = "lblPDFLivro";
            this.lblPDFLivro.Size = new System.Drawing.Size(69, 13);
            this.lblPDFLivro.TabIndex = 68;
            this.lblPDFLivro.Text = "PDF do Livro";
            // 
            // pbPDFconfirmacao
            // 
            this.pbPDFconfirmacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPDFconfirmacao.Location = new System.Drawing.Point(819, 227);
            this.pbPDFconfirmacao.Name = "pbPDFconfirmacao";
            this.pbPDFconfirmacao.Size = new System.Drawing.Size(34, 32);
            this.pbPDFconfirmacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPDFconfirmacao.TabIndex = 67;
            this.pbPDFconfirmacao.TabStop = false;
            // 
            // pbUrlIconLivro
            // 
            this.pbUrlIconLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUrlIconLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrlIconLivro.Location = new System.Drawing.Point(695, 113);
            this.pbUrlIconLivro.Name = "pbUrlIconLivro";
            this.pbUrlIconLivro.Size = new System.Drawing.Size(84, 77);
            this.pbUrlIconLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrlIconLivro.TabIndex = 49;
            this.pbUrlIconLivro.TabStop = false;
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
            // 
            // lblSinopseLivroErro
            // 
            this.lblSinopseLivroErro.AutoSize = true;
            this.lblSinopseLivroErro.ForeColor = System.Drawing.Color.Red;
            this.lblSinopseLivroErro.Location = new System.Drawing.Point(215, 229);
            this.lblSinopseLivroErro.Name = "lblSinopseLivroErro";
            this.lblSinopseLivroErro.Size = new System.Drawing.Size(94, 13);
            this.lblSinopseLivroErro.TabIndex = 70;
            this.lblSinopseLivroErro.Text = "Preencha campo!!";
            // 
            // btnUrlCapaLivro
            // 
            this.btnUrlCapaLivro.Location = new System.Drawing.Point(403, 111);
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
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 640);
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
            this.Controls.Add(this.txtDataPublicacaoLivro);
            this.Controls.Add(this.txtSinopseLivro);
            this.Controls.Add(this.txtAutorLivro);
            this.Controls.Add(this.txtTituloLivro);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.dgvLivro);
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
        private System.Windows.Forms.TextBox txtDataPublicacaoLivro;
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
        private System.Windows.Forms.Button btnLimpar;
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
    }
}