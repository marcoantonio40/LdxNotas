namespace LdxNotas {
    partial class CadastrarUsuario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUsuario));
            this.ButtonCadastrarRegistrar = new System.Windows.Forms.Button();
            this.TextBoxCadastrarUsuarioNome = new System.Windows.Forms.TextBox();
            this.TextBoxCadastrarUsuarioLogin = new System.Windows.Forms.TextBox();
            this.TextBoxCadastrarUsuarioSenha = new System.Windows.Forms.TextBox();
            this.LabelCadastraUsuarioNome = new System.Windows.Forms.Label();
            this.LabelCadastraUsuarioLogin = new System.Windows.Forms.Label();
            this.LabelCadastraUsuarioSenha = new System.Windows.Forms.Label();
            this.ButtonCadastrarVoltar = new System.Windows.Forms.Button();
            this.ButtonCadastrarSair = new System.Windows.Forms.Button();
            this.LabelCadastraUsuarioStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCadastrarRegistrar
            // 
            this.ButtonCadastrarRegistrar.Location = new System.Drawing.Point(18, 156);
            this.ButtonCadastrarRegistrar.Name = "ButtonCadastrarRegistrar";
            this.ButtonCadastrarRegistrar.Size = new System.Drawing.Size(85, 23);
            this.ButtonCadastrarRegistrar.TabIndex = 3;
            this.ButtonCadastrarRegistrar.Text = "CONFIRMAR";
            this.ButtonCadastrarRegistrar.UseVisualStyleBackColor = true;
            this.ButtonCadastrarRegistrar.Click += new System.EventHandler(this.ButtonCadastrarRegistrar_Click);
            // 
            // TextBoxCadastrarUsuarioNome
            // 
            this.TextBoxCadastrarUsuarioNome.Location = new System.Drawing.Point(75, 23);
            this.TextBoxCadastrarUsuarioNome.MaxLength = 50;
            this.TextBoxCadastrarUsuarioNome.Name = "TextBoxCadastrarUsuarioNome";
            this.TextBoxCadastrarUsuarioNome.Size = new System.Drawing.Size(221, 20);
            this.TextBoxCadastrarUsuarioNome.TabIndex = 0;
            // 
            // TextBoxCadastrarUsuarioLogin
            // 
            this.TextBoxCadastrarUsuarioLogin.Location = new System.Drawing.Point(75, 57);
            this.TextBoxCadastrarUsuarioLogin.MaxLength = 50;
            this.TextBoxCadastrarUsuarioLogin.Name = "TextBoxCadastrarUsuarioLogin";
            this.TextBoxCadastrarUsuarioLogin.Size = new System.Drawing.Size(221, 20);
            this.TextBoxCadastrarUsuarioLogin.TabIndex = 1;
            // 
            // TextBoxCadastrarUsuarioSenha
            // 
            this.TextBoxCadastrarUsuarioSenha.Location = new System.Drawing.Point(75, 92);
            this.TextBoxCadastrarUsuarioSenha.MaxLength = 50;
            this.TextBoxCadastrarUsuarioSenha.Name = "TextBoxCadastrarUsuarioSenha";
            this.TextBoxCadastrarUsuarioSenha.Size = new System.Drawing.Size(221, 20);
            this.TextBoxCadastrarUsuarioSenha.TabIndex = 2;
            // 
            // LabelCadastraUsuarioNome
            // 
            this.LabelCadastraUsuarioNome.AutoSize = true;
            this.LabelCadastraUsuarioNome.Location = new System.Drawing.Point(33, 26);
            this.LabelCadastraUsuarioNome.Name = "LabelCadastraUsuarioNome";
            this.LabelCadastraUsuarioNome.Size = new System.Drawing.Size(38, 13);
            this.LabelCadastraUsuarioNome.TabIndex = 4;
            this.LabelCadastraUsuarioNome.Text = "Nome:";
            // 
            // LabelCadastraUsuarioLogin
            // 
            this.LabelCadastraUsuarioLogin.AutoSize = true;
            this.LabelCadastraUsuarioLogin.Location = new System.Drawing.Point(33, 57);
            this.LabelCadastraUsuarioLogin.Name = "LabelCadastraUsuarioLogin";
            this.LabelCadastraUsuarioLogin.Size = new System.Drawing.Size(36, 13);
            this.LabelCadastraUsuarioLogin.TabIndex = 5;
            this.LabelCadastraUsuarioLogin.Text = "Login:";
            // 
            // LabelCadastraUsuarioSenha
            // 
            this.LabelCadastraUsuarioSenha.AutoSize = true;
            this.LabelCadastraUsuarioSenha.Location = new System.Drawing.Point(33, 92);
            this.LabelCadastraUsuarioSenha.Name = "LabelCadastraUsuarioSenha";
            this.LabelCadastraUsuarioSenha.Size = new System.Drawing.Size(41, 13);
            this.LabelCadastraUsuarioSenha.TabIndex = 6;
            this.LabelCadastraUsuarioSenha.Text = "Senha:";
            // 
            // ButtonCadastrarVoltar
            // 
            this.ButtonCadastrarVoltar.Location = new System.Drawing.Point(122, 156);
            this.ButtonCadastrarVoltar.Name = "ButtonCadastrarVoltar";
            this.ButtonCadastrarVoltar.Size = new System.Drawing.Size(78, 23);
            this.ButtonCadastrarVoltar.TabIndex = 4;
            this.ButtonCadastrarVoltar.Text = "VOLTAR";
            this.ButtonCadastrarVoltar.UseVisualStyleBackColor = true;
            this.ButtonCadastrarVoltar.Click += new System.EventHandler(this.ButtonCadastrarVoltar_Click);
            // 
            // ButtonCadastrarSair
            // 
            this.ButtonCadastrarSair.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCadastrarSair.Location = new System.Drawing.Point(218, 156);
            this.ButtonCadastrarSair.Name = "ButtonCadastrarSair";
            this.ButtonCadastrarSair.Size = new System.Drawing.Size(84, 23);
            this.ButtonCadastrarSair.TabIndex = 5;
            this.ButtonCadastrarSair.Text = "SAIR";
            this.ButtonCadastrarSair.UseVisualStyleBackColor = false;
            this.ButtonCadastrarSair.Click += new System.EventHandler(this.ButtonCadastrarSair_Click);
            // 
            // LabelCadastraUsuarioStatus
            // 
            this.LabelCadastraUsuarioStatus.AutoSize = true;
            this.LabelCadastraUsuarioStatus.Location = new System.Drawing.Point(132, 129);
            this.LabelCadastraUsuarioStatus.Name = "LabelCadastraUsuarioStatus";
            this.LabelCadastraUsuarioStatus.Size = new System.Drawing.Size(0, 13);
            this.LabelCadastraUsuarioStatus.TabIndex = 9;
            // 
            // CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 187);
            this.Controls.Add(this.LabelCadastraUsuarioStatus);
            this.Controls.Add(this.ButtonCadastrarSair);
            this.Controls.Add(this.ButtonCadastrarVoltar);
            this.Controls.Add(this.LabelCadastraUsuarioSenha);
            this.Controls.Add(this.LabelCadastraUsuarioLogin);
            this.Controls.Add(this.LabelCadastraUsuarioNome);
            this.Controls.Add(this.TextBoxCadastrarUsuarioSenha);
            this.Controls.Add(this.TextBoxCadastrarUsuarioLogin);
            this.Controls.Add(this.TextBoxCadastrarUsuarioNome);
            this.Controls.Add(this.ButtonCadastrarRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LdxNotas - Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCadastrarRegistrar;
        private System.Windows.Forms.TextBox TextBoxCadastrarUsuarioNome;
        private System.Windows.Forms.TextBox TextBoxCadastrarUsuarioLogin;
        private System.Windows.Forms.TextBox TextBoxCadastrarUsuarioSenha;
        private System.Windows.Forms.Label LabelCadastraUsuarioNome;
        private System.Windows.Forms.Label LabelCadastraUsuarioLogin;
        private System.Windows.Forms.Label LabelCadastraUsuarioSenha;
        private System.Windows.Forms.Button ButtonCadastrarVoltar;
        private System.Windows.Forms.Button ButtonCadastrarSair;
        private System.Windows.Forms.Label LabelCadastraUsuarioStatus;
    }
}