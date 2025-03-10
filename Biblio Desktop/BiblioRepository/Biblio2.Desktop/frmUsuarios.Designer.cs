namespace Biblio2.Desktop
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.cboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblFotoPerfil = new System.Windows.Forms.Label();
            this.lblNomeUsuarioErro = new System.Windows.Forms.Label();
            this.lblEmailUsuarioErro = new System.Windows.Forms.Label();
            this.lblSenhaUsuarioErro = new System.Windows.Forms.Label();
            this.lblTipoUsuarioErro = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.lblUrlFotoPerfil = new System.Windows.Forms.Label();
            this.pbUrlFotoPerfil = new System.Windows.Forms.PictureBox();
            this.txtUrlFotoPerfil = new System.Windows.Forms.TextBox();
            this.lblUrlFotoPerfilErro = new System.Windows.Forms.Label();
            this.lblIdUsuarioErro = new System.Windows.Forms.Label();
            this.btnMudancaPesquisa = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuario.Size = new System.Drawing.Size(414, 561);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuario_CellMouseClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Location = new System.Drawing.Point(580, 456);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 36);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(686, 456);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 36);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(580, 507);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 36);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(686, 507);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(101, 36);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdUsuario.Location = new System.Drawing.Point(580, 86);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(37, 20);
            this.txtIdUsuario.TabIndex = 1;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(580, 148);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(207, 20);
            this.txtNomeUsuario.TabIndex = 2;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailUsuario.Location = new System.Drawing.Point(580, 198);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(207, 20);
            this.txtEmailUsuario.TabIndex = 3;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(580, 248);
            this.txtSenhaUsuario.MaxLength = 8;
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(207, 20);
            this.txtSenhaUsuario.TabIndex = 4;
            // 
            // cboxTipoUsuario
            // 
            this.cboxTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoUsuario.FormattingEnabled = true;
            this.cboxTipoUsuario.Location = new System.Drawing.Point(580, 298);
            this.cboxTipoUsuario.Name = "cboxTipoUsuario";
            this.cboxTipoUsuario.Size = new System.Drawing.Size(207, 21);
            this.cboxTipoUsuario.TabIndex = 5;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblIdUsuario.Location = new System.Drawing.Point(582, 70);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(18, 13);
            this.lblIdUsuario.TabIndex = 6;
            this.lblIdUsuario.Text = "ID";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNomeUsuario.Location = new System.Drawing.Point(582, 132);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNomeUsuario.TabIndex = 7;
            this.lblNomeUsuario.Text = "Nome";
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEmailUsuario.Location = new System.Drawing.Point(582, 182);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblEmailUsuario.TabIndex = 8;
            this.lblEmailUsuario.Text = "E-mail";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(582, 232);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaUsuario.TabIndex = 9;
            this.lblSenhaUsuario.Text = "Senha";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTipoUsuario.Location = new System.Drawing.Point(582, 282);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblTipoUsuario.TabIndex = 10;
            this.lblTipoUsuario.Text = "Tipo de Usuário";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Location = new System.Drawing.Point(639, 70);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(148, 36);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblFotoPerfil
            // 
            this.lblFotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFotoPerfil.AutoSize = true;
            this.lblFotoPerfil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFotoPerfil.Location = new System.Drawing.Point(493, 332);
            this.lblFotoPerfil.Name = "lblFotoPerfil";
            this.lblFotoPerfil.Size = new System.Drawing.Size(69, 13);
            this.lblFotoPerfil.TabIndex = 17;
            this.lblFotoPerfil.Text = "Foto de Perfil";
            // 
            // lblNomeUsuarioErro
            // 
            this.lblNomeUsuarioErro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeUsuarioErro.AutoSize = true;
            this.lblNomeUsuarioErro.ForeColor = System.Drawing.Color.Red;
            this.lblNomeUsuarioErro.Location = new System.Drawing.Point(793, 151);
            this.lblNomeUsuarioErro.Name = "lblNomeUsuarioErro";
            this.lblNomeUsuarioErro.Size = new System.Drawing.Size(39, 13);
            this.lblNomeUsuarioErro.TabIndex = 18;
            this.lblNomeUsuarioErro.Text = "Aviso2";
            // 
            // lblEmailUsuarioErro
            // 
            this.lblEmailUsuarioErro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailUsuarioErro.AutoSize = true;
            this.lblEmailUsuarioErro.ForeColor = System.Drawing.Color.Red;
            this.lblEmailUsuarioErro.Location = new System.Drawing.Point(793, 201);
            this.lblEmailUsuarioErro.Name = "lblEmailUsuarioErro";
            this.lblEmailUsuarioErro.Size = new System.Drawing.Size(39, 13);
            this.lblEmailUsuarioErro.TabIndex = 19;
            this.lblEmailUsuarioErro.Text = "Aviso3";
            // 
            // lblSenhaUsuarioErro
            // 
            this.lblSenhaUsuarioErro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenhaUsuarioErro.AutoSize = true;
            this.lblSenhaUsuarioErro.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaUsuarioErro.Location = new System.Drawing.Point(793, 251);
            this.lblSenhaUsuarioErro.Name = "lblSenhaUsuarioErro";
            this.lblSenhaUsuarioErro.Size = new System.Drawing.Size(39, 13);
            this.lblSenhaUsuarioErro.TabIndex = 20;
            this.lblSenhaUsuarioErro.Text = "Aviso4";
            // 
            // lblTipoUsuarioErro
            // 
            this.lblTipoUsuarioErro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoUsuarioErro.AutoSize = true;
            this.lblTipoUsuarioErro.ForeColor = System.Drawing.Color.Red;
            this.lblTipoUsuarioErro.Location = new System.Drawing.Point(793, 301);
            this.lblTipoUsuarioErro.Name = "lblTipoUsuarioErro";
            this.lblTipoUsuarioErro.Size = new System.Drawing.Size(39, 13);
            this.lblTipoUsuarioErro.TabIndex = 21;
            this.lblTipoUsuarioErro.Text = "Aviso5";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarImagem.Location = new System.Drawing.Point(676, 361);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(111, 34);
            this.btnSelecionarImagem.TabIndex = 22;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // lblUrlFotoPerfil
            // 
            this.lblUrlFotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlFotoPerfil.AutoSize = true;
            this.lblUrlFotoPerfil.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUrlFotoPerfil.Location = new System.Drawing.Point(582, 398);
            this.lblUrlFotoPerfil.Name = "lblUrlFotoPerfil";
            this.lblUrlFotoPerfil.Size = new System.Drawing.Size(109, 13);
            this.lblUrlFotoPerfil.TabIndex = 24;
            this.lblUrlFotoPerfil.Text = "URL da Foto de Perfil";
            // 
            // pbUrlFotoPerfil
            // 
            this.pbUrlFotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUrlFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrlFotoPerfil.Location = new System.Drawing.Point(491, 348);
            this.pbUrlFotoPerfil.Name = "pbUrlFotoPerfil";
            this.pbUrlFotoPerfil.Size = new System.Drawing.Size(83, 86);
            this.pbUrlFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrlFotoPerfil.TabIndex = 16;
            this.pbUrlFotoPerfil.TabStop = false;
            // 
            // txtUrlFotoPerfil
            // 
            this.txtUrlFotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlFotoPerfil.Location = new System.Drawing.Point(580, 414);
            this.txtUrlFotoPerfil.Name = "txtUrlFotoPerfil";
            this.txtUrlFotoPerfil.ReadOnly = true;
            this.txtUrlFotoPerfil.Size = new System.Drawing.Size(252, 20);
            this.txtUrlFotoPerfil.TabIndex = 23;
            this.txtUrlFotoPerfil.TextChanged += new System.EventHandler(this.txtUrlFotoPerfil_TextChanged);
            // 
            // lblUrlFotoPerfilErro
            // 
            this.lblUrlFotoPerfilErro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlFotoPerfilErro.AutoSize = true;
            this.lblUrlFotoPerfilErro.ForeColor = System.Drawing.Color.Red;
            this.lblUrlFotoPerfilErro.Location = new System.Drawing.Point(698, 398);
            this.lblUrlFotoPerfilErro.Name = "lblUrlFotoPerfilErro";
            this.lblUrlFotoPerfilErro.Size = new System.Drawing.Size(39, 13);
            this.lblUrlFotoPerfilErro.TabIndex = 25;
            this.lblUrlFotoPerfilErro.Text = "Aviso6";
            // 
            // lblIdUsuarioErro
            // 
            this.lblIdUsuarioErro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdUsuarioErro.AutoSize = true;
            this.lblIdUsuarioErro.ForeColor = System.Drawing.Color.Red;
            this.lblIdUsuarioErro.Location = new System.Drawing.Point(793, 89);
            this.lblIdUsuarioErro.Name = "lblIdUsuarioErro";
            this.lblIdUsuarioErro.Size = new System.Drawing.Size(39, 13);
            this.lblIdUsuarioErro.TabIndex = 26;
            this.lblIdUsuarioErro.Text = "Aviso1";
            // 
            // btnMudancaPesquisa
            // 
            this.btnMudancaPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMudancaPesquisa.Location = new System.Drawing.Point(461, 70);
            this.btnMudancaPesquisa.Name = "btnMudancaPesquisa";
            this.btnMudancaPesquisa.Size = new System.Drawing.Size(101, 36);
            this.btnMudancaPesquisa.TabIndex = 29;
            this.btnMudancaPesquisa.Text = "Selecionar por ID";
            this.btnMudancaPesquisa.UseVisualStyleBackColor = true;
            this.btnMudancaPesquisa.Click += new System.EventHandler(this.btnMudancaPesquisa_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPagina.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPagina.Location = new System.Drawing.Point(766, 9);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(122, 31);
            this.lblPagina.TabIndex = 30;
            this.lblPagina.Text = "Usuários";
            // 
            // btnRemoverFoto
            // 
            this.btnRemoverFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverFoto.Enabled = false;
            this.btnRemoverFoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoverFoto.Location = new System.Drawing.Point(580, 361);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(92, 34);
            this.btnRemoverFoto.TabIndex = 84;
            this.btnRemoverFoto.Text = "Remover Arquivo";
            this.btnRemoverFoto.UseVisualStyleBackColor = true;
            this.btnRemoverFoto.Click += new System.EventHandler(this.btnRemoverFoto_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnRemoverFoto);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnMudancaPesquisa);
            this.Controls.Add(this.lblIdUsuarioErro);
            this.Controls.Add(this.lblUrlFotoPerfilErro);
            this.Controls.Add(this.lblUrlFotoPerfil);
            this.Controls.Add(this.txtUrlFotoPerfil);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.lblTipoUsuarioErro);
            this.Controls.Add(this.lblSenhaUsuarioErro);
            this.Controls.Add(this.lblEmailUsuarioErro);
            this.Controls.Add(this.lblNomeUsuarioErro);
            this.Controls.Add(this.lblFotoPerfil);
            this.Controls.Add(this.pbUrlFotoPerfil);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.lblEmailUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.cboxTipoUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.dgvUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.ComboBox cboxTipoUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pbUrlFotoPerfil;
        private System.Windows.Forms.Label lblFotoPerfil;
        private System.Windows.Forms.Label lblNomeUsuarioErro;
        private System.Windows.Forms.Label lblEmailUsuarioErro;
        private System.Windows.Forms.Label lblSenhaUsuarioErro;
        private System.Windows.Forms.Label lblTipoUsuarioErro;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.Label lblUrlFotoPerfil;
        private System.Windows.Forms.TextBox txtUrlFotoPerfil;
        private System.Windows.Forms.Label lblUrlFotoPerfilErro;
        private System.Windows.Forms.Label lblIdUsuarioErro;
        private System.Windows.Forms.Button btnMudancaPesquisa;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button btnRemoverFoto;
    }
}