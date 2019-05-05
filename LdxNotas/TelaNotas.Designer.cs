namespace LdxNotas {
    partial class TelaNotas {
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
            this.ButtonTelaNotaCadastrar = new System.Windows.Forms.Button();
            this.ButtonTelaNotaEditar = new System.Windows.Forms.Button();
            this.ButtonTelaNotaDeletar = new System.Windows.Forms.Button();
            this.ButtonTelaNotaSair = new System.Windows.Forms.Button();
            this.ButtonTelaNotaVisualizar = new System.Windows.Forms.Button();
            this.LabelTelaNotaTitulo = new System.Windows.Forms.Label();
            this.LabelTelaNotaDescricao = new System.Windows.Forms.Label();
            this.TextBoxTelaNotaTitulo = new System.Windows.Forms.TextBox();
            this.TextBoxTelaNotaDescricao = new System.Windows.Forms.TextBox();
            this.ButtonTelaNotaConfirmar = new System.Windows.Forms.Button();
            this.ButtonTelaNotaCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonTelaNotaCadastrar
            // 
            this.ButtonTelaNotaCadastrar.Location = new System.Drawing.Point(512, 415);
            this.ButtonTelaNotaCadastrar.Name = "ButtonTelaNotaCadastrar";
            this.ButtonTelaNotaCadastrar.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaCadastrar.TabIndex = 0;
            this.ButtonTelaNotaCadastrar.Text = "CADASTRAR";
            this.ButtonTelaNotaCadastrar.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaCadastrar.Click += new System.EventHandler(this.ButtonTelaNotaCadastrar_Click);
            // 
            // ButtonTelaNotaEditar
            // 
            this.ButtonTelaNotaEditar.Location = new System.Drawing.Point(593, 415);
            this.ButtonTelaNotaEditar.Name = "ButtonTelaNotaEditar";
            this.ButtonTelaNotaEditar.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaEditar.TabIndex = 1;
            this.ButtonTelaNotaEditar.Text = "EDITAR";
            this.ButtonTelaNotaEditar.UseVisualStyleBackColor = true;
            // 
            // ButtonTelaNotaDeletar
            // 
            this.ButtonTelaNotaDeletar.Location = new System.Drawing.Point(674, 415);
            this.ButtonTelaNotaDeletar.Name = "ButtonTelaNotaDeletar";
            this.ButtonTelaNotaDeletar.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaDeletar.TabIndex = 2;
            this.ButtonTelaNotaDeletar.Text = "DELETAR";
            this.ButtonTelaNotaDeletar.UseVisualStyleBackColor = true;
            // 
            // ButtonTelaNotaSair
            // 
            this.ButtonTelaNotaSair.Location = new System.Drawing.Point(755, 415);
            this.ButtonTelaNotaSair.Name = "ButtonTelaNotaSair";
            this.ButtonTelaNotaSair.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaSair.TabIndex = 3;
            this.ButtonTelaNotaSair.Text = "SAIR";
            this.ButtonTelaNotaSair.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaSair.Click += new System.EventHandler(this.ButtonTelaNotaSair_Click);
            // 
            // ButtonTelaNotaVisualizar
            // 
            this.ButtonTelaNotaVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTelaNotaVisualizar.Location = new System.Drawing.Point(431, 415);
            this.ButtonTelaNotaVisualizar.Name = "ButtonTelaNotaVisualizar";
            this.ButtonTelaNotaVisualizar.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaVisualizar.TabIndex = 4;
            this.ButtonTelaNotaVisualizar.Text = "VISUALIZAR";
            this.ButtonTelaNotaVisualizar.UseVisualStyleBackColor = true;
            // 
            // LabelTelaNotaTitulo
            // 
            this.LabelTelaNotaTitulo.AutoSize = true;
            this.LabelTelaNotaTitulo.Location = new System.Drawing.Point(13, 261);
            this.LabelTelaNotaTitulo.Name = "LabelTelaNotaTitulo";
            this.LabelTelaNotaTitulo.Size = new System.Drawing.Size(49, 13);
            this.LabelTelaNotaTitulo.TabIndex = 5;
            this.LabelTelaNotaTitulo.Text = "TÍTULO:";
            this.LabelTelaNotaTitulo.Visible = false;
            // 
            // LabelTelaNotaDescricao
            // 
            this.LabelTelaNotaDescricao.AutoSize = true;
            this.LabelTelaNotaDescricao.Location = new System.Drawing.Point(13, 304);
            this.LabelTelaNotaDescricao.Name = "LabelTelaNotaDescricao";
            this.LabelTelaNotaDescricao.Size = new System.Drawing.Size(72, 13);
            this.LabelTelaNotaDescricao.TabIndex = 6;
            this.LabelTelaNotaDescricao.Text = "DESCRIÇÃO:";
            this.LabelTelaNotaDescricao.Visible = false;
            // 
            // TextBoxTelaNotaTitulo
            // 
            this.TextBoxTelaNotaTitulo.Location = new System.Drawing.Point(94, 261);
            this.TextBoxTelaNotaTitulo.MaxLength = 50;
            this.TextBoxTelaNotaTitulo.Name = "TextBoxTelaNotaTitulo";
            this.TextBoxTelaNotaTitulo.Size = new System.Drawing.Size(154, 20);
            this.TextBoxTelaNotaTitulo.TabIndex = 7;
            this.TextBoxTelaNotaTitulo.Visible = false;
            // 
            // TextBoxTelaNotaDescricao
            // 
            this.TextBoxTelaNotaDescricao.Location = new System.Drawing.Point(94, 301);
            this.TextBoxTelaNotaDescricao.MaxLength = 256;
            this.TextBoxTelaNotaDescricao.Multiline = true;
            this.TextBoxTelaNotaDescricao.Name = "TextBoxTelaNotaDescricao";
            this.TextBoxTelaNotaDescricao.Size = new System.Drawing.Size(154, 92);
            this.TextBoxTelaNotaDescricao.TabIndex = 8;
            this.TextBoxTelaNotaDescricao.Visible = false;
            // 
            // ButtonTelaNotaConfirmar
            // 
            this.ButtonTelaNotaConfirmar.Location = new System.Drawing.Point(94, 415);
            this.ButtonTelaNotaConfirmar.Name = "ButtonTelaNotaConfirmar";
            this.ButtonTelaNotaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaConfirmar.TabIndex = 9;
            this.ButtonTelaNotaConfirmar.Text = "CONFIRMAR";
            this.ButtonTelaNotaConfirmar.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaConfirmar.Visible = false;
            this.ButtonTelaNotaConfirmar.Click += new System.EventHandler(this.ButtonTelaNotaConfirmar_Click);
            // 
            // ButtonTelaNotaCancelar
            // 
            this.ButtonTelaNotaCancelar.Location = new System.Drawing.Point(173, 415);
            this.ButtonTelaNotaCancelar.Name = "ButtonTelaNotaCancelar";
            this.ButtonTelaNotaCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaCancelar.TabIndex = 10;
            this.ButtonTelaNotaCancelar.Text = "CANCELAR";
            this.ButtonTelaNotaCancelar.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaCancelar.Visible = false;
            this.ButtonTelaNotaCancelar.Click += new System.EventHandler(this.ButtonTelaNotaCancelar_Click);
            // 
            // TelaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.ButtonTelaNotaCancelar);
            this.Controls.Add(this.ButtonTelaNotaConfirmar);
            this.Controls.Add(this.TextBoxTelaNotaDescricao);
            this.Controls.Add(this.TextBoxTelaNotaTitulo);
            this.Controls.Add(this.LabelTelaNotaDescricao);
            this.Controls.Add(this.LabelTelaNotaTitulo);
            this.Controls.Add(this.ButtonTelaNotaVisualizar);
            this.Controls.Add(this.ButtonTelaNotaSair);
            this.Controls.Add(this.ButtonTelaNotaDeletar);
            this.Controls.Add(this.ButtonTelaNotaEditar);
            this.Controls.Add(this.ButtonTelaNotaCadastrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TelaNotas";
            this.Text = "TelaNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonTelaNotaCadastrar;
        private System.Windows.Forms.Button ButtonTelaNotaEditar;
        private System.Windows.Forms.Button ButtonTelaNotaDeletar;
        private System.Windows.Forms.Button ButtonTelaNotaSair;
        private System.Windows.Forms.Button ButtonTelaNotaVisualizar;
        private System.Windows.Forms.Label LabelTelaNotaTitulo;
        private System.Windows.Forms.Label LabelTelaNotaDescricao;
        private System.Windows.Forms.TextBox TextBoxTelaNotaTitulo;
        private System.Windows.Forms.TextBox TextBoxTelaNotaDescricao;
        private System.Windows.Forms.Button ButtonTelaNotaConfirmar;
        private System.Windows.Forms.Button ButtonTelaNotaCancelar;
    }
}