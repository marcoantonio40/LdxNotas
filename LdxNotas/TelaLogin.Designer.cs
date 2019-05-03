namespace LdxNotas {
    partial class TelaLogin {
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
            this.ButtonLogar = new System.Windows.Forms.Button();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.TetxBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLogar
            // 
            this.ButtonLogar.Location = new System.Drawing.Point(15, 101);
            this.ButtonLogar.Name = "ButtonLogar";
            this.ButtonLogar.Size = new System.Drawing.Size(111, 23);
            this.ButtonLogar.TabIndex = 0;
            this.ButtonLogar.Text = "Entrar";
            this.ButtonLogar.UseVisualStyleBackColor = true;
            this.ButtonLogar.Click += new System.EventHandler(this.ButtonLogar_Click);
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.Location = new System.Drawing.Point(161, 101);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(111, 23);
            this.ButtonCadastrar.TabIndex = 1;
            this.ButtonCadastrar.Text = "Cadastrar Usuário";
            this.ButtonCadastrar.UseVisualStyleBackColor = true;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // TetxBoxLogin
            // 
            this.TetxBoxLogin.Location = new System.Drawing.Point(59, 12);
            this.TetxBoxLogin.Name = "TetxBoxLogin";
            this.TetxBoxLogin.Size = new System.Drawing.Size(213, 20);
            this.TetxBoxLogin.TabIndex = 2;
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Location = new System.Drawing.Point(59, 58);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.Size = new System.Drawing.Size(213, 20);
            this.TextBoxSenha.TabIndex = 3;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(12, 15);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(36, 13);
            this.LabelLogin.TabIndex = 4;
            this.LabelLogin.Text = "Login:";
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Location = new System.Drawing.Point(12, 65);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(41, 13);
            this.LabelSenha.TabIndex = 5;
            this.LabelSenha.Text = "Senha:";
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(15, 130);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(257, 23);
            this.ButtonSair.TabIndex = 6;
            this.ButtonSair.Text = "SAIR";
            this.ButtonSair.UseVisualStyleBackColor = true;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.TetxBoxLogin);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.ButtonLogar);
            this.Name = "TelaLogin";
            this.Text = "TelaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogar;
        private System.Windows.Forms.Button ButtonCadastrar;
        private System.Windows.Forms.TextBox TetxBoxLogin;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Label LabelLogin;
        public System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Button ButtonSair;
    }
}