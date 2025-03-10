namespace Biblio2.Desktop
{
    partial class frmLogin
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblNomeUsuarioErro = new System.Windows.Forms.Label();
            this.lblSenhaUsuarioErro = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Location = new System.Drawing.Point(441, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.Location = new System.Drawing.Point(165, 299);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Location = new System.Drawing.Point(279, 299);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeUsuario.Location = new System.Drawing.Point(165, 140);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(189, 20);
            this.txtNomeUsuario.TabIndex = 3;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(165, 218);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(189, 20);
            this.txtSenhaUsuario.TabIndex = 4;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNomeUsuario.Location = new System.Drawing.Point(162, 124);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNomeUsuario.TabIndex = 5;
            this.lblNomeUsuario.Text = "Nome";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(162, 202);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaUsuario.TabIndex = 6;
            this.lblSenhaUsuario.Text = "Senha";
            // 
            // lblNomeUsuarioErro
            // 
            this.lblNomeUsuarioErro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeUsuarioErro.AutoSize = true;
            this.lblNomeUsuarioErro.ForeColor = System.Drawing.Color.Red;
            this.lblNomeUsuarioErro.Location = new System.Drawing.Point(360, 143);
            this.lblNomeUsuarioErro.Name = "lblNomeUsuarioErro";
            this.lblNomeUsuarioErro.Size = new System.Drawing.Size(39, 13);
            this.lblNomeUsuarioErro.TabIndex = 7;
            this.lblNomeUsuarioErro.Text = "Aviso1";
            // 
            // lblSenhaUsuarioErro
            // 
            this.lblSenhaUsuarioErro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaUsuarioErro.AutoSize = true;
            this.lblSenhaUsuarioErro.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaUsuarioErro.Location = new System.Drawing.Point(360, 221);
            this.lblSenhaUsuarioErro.Name = "lblSenhaUsuarioErro";
            this.lblSenhaUsuarioErro.Size = new System.Drawing.Size(39, 13);
            this.lblSenhaUsuarioErro.TabIndex = 8;
            this.lblSenhaUsuarioErro.Text = "Aviso2";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblResult.Location = new System.Drawing.Point(189, 260);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(146, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Tipo de usuário não permitido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tela de Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSenhaUsuarioErro);
            this.Controls.Add(this.lblNomeUsuarioErro);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblNomeUsuarioErro;
        private System.Windows.Forms.Label lblSenhaUsuarioErro;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
    }
}