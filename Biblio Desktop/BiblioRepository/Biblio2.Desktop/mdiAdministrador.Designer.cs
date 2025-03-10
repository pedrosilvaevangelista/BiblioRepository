namespace Biblio2.Desktop
{
    partial class mdiAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiAdministrador));
            this.pbFotoAdministrador = new System.Windows.Forms.PictureBox();
            this.lblNomeAdministrador = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnRequisicoes = new System.Windows.Forms.Button();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.pbLivros = new System.Windows.Forms.PictureBox();
            this.pbRequisicoes = new System.Windows.Forms.PictureBox();
            this.btnSairAplicativo = new System.Windows.Forms.Button();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.gbMenuEsquerda = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequisicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            this.gbMenuEsquerda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFotoAdministrador
            // 
            this.pbFotoAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pbFotoAdministrador.Location = new System.Drawing.Point(12, 12);
            this.pbFotoAdministrador.Name = "pbFotoAdministrador";
            this.pbFotoAdministrador.Size = new System.Drawing.Size(57, 47);
            this.pbFotoAdministrador.TabIndex = 0;
            this.pbFotoAdministrador.TabStop = false;
            // 
            // lblNomeAdministrador
            // 
            this.lblNomeAdministrador.AutoSize = true;
            this.lblNomeAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lblNomeAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomeAdministrador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNomeAdministrador.Location = new System.Drawing.Point(75, 21);
            this.lblNomeAdministrador.Name = "lblNomeAdministrador";
            this.lblNomeAdministrador.Size = new System.Drawing.Size(113, 25);
            this.lblNomeAdministrador.TabIndex = 1;
            this.lblNomeAdministrador.Text = "placeholder";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(67, 112);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(121, 32);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.Location = new System.Drawing.Point(67, 150);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(121, 32);
            this.btnLivros.TabIndex = 3;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnRequisicoes
            // 
            this.btnRequisicoes.Location = new System.Drawing.Point(67, 188);
            this.btnRequisicoes.Name = "btnRequisicoes";
            this.btnRequisicoes.Size = new System.Drawing.Size(121, 32);
            this.btnRequisicoes.TabIndex = 4;
            this.btnRequisicoes.Text = "Requisições";
            this.btnRequisicoes.UseVisualStyleBackColor = true;
            this.btnRequisicoes.Click += new System.EventHandler(this.btnRequisicoes_Click);
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarios.Image")));
            this.pbUsuarios.Location = new System.Drawing.Point(24, 112);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(37, 32);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuarios.TabIndex = 6;
            this.pbUsuarios.TabStop = false;
            // 
            // pbLivros
            // 
            this.pbLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pbLivros.Image = ((System.Drawing.Image)(resources.GetObject("pbLivros.Image")));
            this.pbLivros.Location = new System.Drawing.Point(24, 150);
            this.pbLivros.Name = "pbLivros";
            this.pbLivros.Size = new System.Drawing.Size(37, 32);
            this.pbLivros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLivros.TabIndex = 7;
            this.pbLivros.TabStop = false;
            // 
            // pbRequisicoes
            // 
            this.pbRequisicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pbRequisicoes.Image = ((System.Drawing.Image)(resources.GetObject("pbRequisicoes.Image")));
            this.pbRequisicoes.Location = new System.Drawing.Point(24, 188);
            this.pbRequisicoes.Name = "pbRequisicoes";
            this.pbRequisicoes.Size = new System.Drawing.Size(37, 32);
            this.pbRequisicoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRequisicoes.TabIndex = 8;
            this.pbRequisicoes.TabStop = false;
            // 
            // btnSairAplicativo
            // 
            this.btnSairAplicativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSairAplicativo.Location = new System.Drawing.Point(68, 546);
            this.btnSairAplicativo.Name = "btnSairAplicativo";
            this.btnSairAplicativo.Size = new System.Drawing.Size(121, 32);
            this.btnSairAplicativo.TabIndex = 10;
            this.btnSairAplicativo.Text = "Fechar Aplicação";
            this.btnSairAplicativo.UseVisualStyleBackColor = true;
            this.btnSairAplicativo.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbSair
            // 
            this.pbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(25, 546);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(37, 32);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 11;
            this.pbSair.TabStop = false;
            // 
            // gbMenuEsquerda
            // 
            this.gbMenuEsquerda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMenuEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.gbMenuEsquerda.Controls.Add(this.btnSairAplicativo);
            this.gbMenuEsquerda.Controls.Add(this.pbSair);
            this.gbMenuEsquerda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.gbMenuEsquerda.Location = new System.Drawing.Point(-1, -12);
            this.gbMenuEsquerda.Name = "gbMenuEsquerda";
            this.gbMenuEsquerda.Size = new System.Drawing.Size(251, 623);
            this.gbMenuEsquerda.TabIndex = 12;
            this.gbMenuEsquerda.TabStop = false;
            // 
            // mdiAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pbRequisicoes);
            this.Controls.Add(this.pbLivros);
            this.Controls.Add(this.pbUsuarios);
            this.Controls.Add(this.btnRequisicoes);
            this.Controls.Add(this.btnLivros);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblNomeAdministrador);
            this.Controls.Add(this.pbFotoAdministrador);
            this.Controls.Add(this.gbMenuEsquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdiAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "mdiAdministrador";
            this.Load += new System.EventHandler(this.mdiAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequisicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            this.gbMenuEsquerda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotoAdministrador;
        private System.Windows.Forms.Label lblNomeAdministrador;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnRequisicoes;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.PictureBox pbLivros;
        private System.Windows.Forms.PictureBox pbRequisicoes;
        private System.Windows.Forms.Button btnSairAplicativo;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.GroupBox gbMenuEsquerda;
    }
}