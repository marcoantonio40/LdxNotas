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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.LabelTelaNotasStatus = new System.Windows.Forms.Label();
            this.DataGridViewTelaNota = new System.Windows.Forms.DataGridView();
            this.ButtonTelaNotaConfirmarEdicao = new System.Windows.Forms.Button();
            this.LabelTelaNotaCodigoNota = new System.Windows.Forms.Label();
            this.ButtonTelaNotaConfirmarDelecao = new System.Windows.Forms.Button();
            this.LabelTelaNotaTituloDelecao = new System.Windows.Forms.Label();
            this.LabelTelaNotaDescricaoDelecao = new System.Windows.Forms.Label();
            this.ButtonTelaNotaCancelarDelecao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTelaNota)).BeginInit();
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
            this.ButtonTelaNotaEditar.Click += new System.EventHandler(this.ButtonTelaNotaEditar_Click);
            // 
            // ButtonTelaNotaDeletar
            // 
            this.ButtonTelaNotaDeletar.Location = new System.Drawing.Point(674, 415);
            this.ButtonTelaNotaDeletar.Name = "ButtonTelaNotaDeletar";
            this.ButtonTelaNotaDeletar.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaDeletar.TabIndex = 2;
            this.ButtonTelaNotaDeletar.Text = "DELETAR";
            this.ButtonTelaNotaDeletar.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaDeletar.Click += new System.EventHandler(this.ButtonTelaNotaDeletar_Click);
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
            this.ButtonTelaNotaVisualizar.Click += new System.EventHandler(this.ButtonTelaNotaVisualizar_Click);
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
            this.TextBoxTelaNotaTitulo.TextChanged += new System.EventHandler(this.TextBoxTelaNotaTitulo_TextChanged);
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
            this.TextBoxTelaNotaDescricao.TextChanged += new System.EventHandler(this.TextBoxTelaNotaDescricao_TextChanged);
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
            // LabelTelaNotasStatus
            // 
            this.LabelTelaNotasStatus.AutoSize = true;
            this.LabelTelaNotasStatus.Location = new System.Drawing.Point(10, 412);
            this.LabelTelaNotasStatus.Name = "LabelTelaNotasStatus";
            this.LabelTelaNotasStatus.Size = new System.Drawing.Size(75, 26);
            this.LabelTelaNotasStatus.TabIndex = 11;
            this.LabelTelaNotasStatus.Text = "Nota inserida\r\n com sucesso!";
            this.LabelTelaNotasStatus.Visible = false;
            // 
            // DataGridViewTelaNota
            // 
            this.DataGridViewTelaNota.AllowUserToAddRows = false;
            this.DataGridViewTelaNota.AllowUserToDeleteRows = false;
            this.DataGridViewTelaNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTelaNota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewTelaNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTelaNota.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewTelaNota.Location = new System.Drawing.Point(273, 12);
            this.DataGridViewTelaNota.Name = "DataGridViewTelaNota";
            this.DataGridViewTelaNota.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTelaNota.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTelaNota.Size = new System.Drawing.Size(557, 381);
            this.DataGridViewTelaNota.TabIndex = 12;
            this.DataGridViewTelaNota.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTelaNota_CellDoubleClick);
            // 
            // ButtonTelaNotaConfirmarEdicao
            // 
            this.ButtonTelaNotaConfirmarEdicao.Location = new System.Drawing.Point(94, 415);
            this.ButtonTelaNotaConfirmarEdicao.Name = "ButtonTelaNotaConfirmarEdicao";
            this.ButtonTelaNotaConfirmarEdicao.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaConfirmarEdicao.TabIndex = 13;
            this.ButtonTelaNotaConfirmarEdicao.Text = "CONFIRMAR";
            this.ButtonTelaNotaConfirmarEdicao.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaConfirmarEdicao.Visible = false;
            this.ButtonTelaNotaConfirmarEdicao.Click += new System.EventHandler(this.ButtonTelaNotaConfirmarEdicao_Click);
            // 
            // LabelTelaNotaCodigoNota
            // 
            this.LabelTelaNotaCodigoNota.AutoSize = true;
            this.LabelTelaNotaCodigoNota.Location = new System.Drawing.Point(10, 326);
            this.LabelTelaNotaCodigoNota.Name = "LabelTelaNotaCodigoNota";
            this.LabelTelaNotaCodigoNota.Size = new System.Drawing.Size(0, 13);
            this.LabelTelaNotaCodigoNota.TabIndex = 14;
            this.LabelTelaNotaCodigoNota.Visible = false;
            // 
            // ButtonTelaNotaConfirmarDelecao
            // 
            this.ButtonTelaNotaConfirmarDelecao.Location = new System.Drawing.Point(94, 415);
            this.ButtonTelaNotaConfirmarDelecao.Name = "ButtonTelaNotaConfirmarDelecao";
            this.ButtonTelaNotaConfirmarDelecao.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaConfirmarDelecao.TabIndex = 15;
            this.ButtonTelaNotaConfirmarDelecao.Text = "APAGAR";
            this.ButtonTelaNotaConfirmarDelecao.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaConfirmarDelecao.Visible = false;
            this.ButtonTelaNotaConfirmarDelecao.Click += new System.EventHandler(this.ButtonTelaNotaConfirmarDelecao_Click);
            // 
            // LabelTelaNotaTituloDelecao
            // 
            this.LabelTelaNotaTituloDelecao.AutoSize = true;
            this.LabelTelaNotaTituloDelecao.Location = new System.Drawing.Point(13, 261);
            this.LabelTelaNotaTituloDelecao.Name = "LabelTelaNotaTituloDelecao";
            this.LabelTelaNotaTituloDelecao.Size = new System.Drawing.Size(0, 13);
            this.LabelTelaNotaTituloDelecao.TabIndex = 16;
            this.LabelTelaNotaTituloDelecao.Visible = false;
            // 
            // LabelTelaNotaDescricaoDelecao
            // 
            this.LabelTelaNotaDescricaoDelecao.AutoSize = true;
            this.LabelTelaNotaDescricaoDelecao.Location = new System.Drawing.Point(13, 340);
            this.LabelTelaNotaDescricaoDelecao.Name = "LabelTelaNotaDescricaoDelecao";
            this.LabelTelaNotaDescricaoDelecao.Size = new System.Drawing.Size(0, 13);
            this.LabelTelaNotaDescricaoDelecao.TabIndex = 17;
            this.LabelTelaNotaDescricaoDelecao.Visible = false;
            // 
            // ButtonTelaNotaCancelarDelecao
            // 
            this.ButtonTelaNotaCancelarDelecao.Location = new System.Drawing.Point(175, 415);
            this.ButtonTelaNotaCancelarDelecao.Name = "ButtonTelaNotaCancelarDelecao";
            this.ButtonTelaNotaCancelarDelecao.Size = new System.Drawing.Size(75, 23);
            this.ButtonTelaNotaCancelarDelecao.TabIndex = 18;
            this.ButtonTelaNotaCancelarDelecao.Text = "CANCELAR";
            this.ButtonTelaNotaCancelarDelecao.UseVisualStyleBackColor = true;
            this.ButtonTelaNotaCancelarDelecao.Visible = false;
            this.ButtonTelaNotaCancelarDelecao.Click += new System.EventHandler(this.ButtonTelaNotaCancelarDelecao_Click);
            // 
            // TelaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.ButtonTelaNotaCancelarDelecao);
            this.Controls.Add(this.LabelTelaNotaDescricaoDelecao);
            this.Controls.Add(this.LabelTelaNotaTituloDelecao);
            this.Controls.Add(this.ButtonTelaNotaConfirmarDelecao);
            this.Controls.Add(this.LabelTelaNotaCodigoNota);
            this.Controls.Add(this.ButtonTelaNotaConfirmarEdicao);
            this.Controls.Add(this.DataGridViewTelaNota);
            this.Controls.Add(this.LabelTelaNotasStatus);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaNotas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTelaNota)).EndInit();
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
        private System.Windows.Forms.Label LabelTelaNotasStatus;
        private System.Windows.Forms.DataGridView DataGridViewTelaNota;
        private System.Windows.Forms.Button ButtonTelaNotaConfirmarEdicao;
        private System.Windows.Forms.Label LabelTelaNotaCodigoNota;
        private System.Windows.Forms.Button ButtonTelaNotaConfirmarDelecao;
        private System.Windows.Forms.Label LabelTelaNotaTituloDelecao;
        private System.Windows.Forms.Label LabelTelaNotaDescricaoDelecao;
        private System.Windows.Forms.Button ButtonTelaNotaCancelarDelecao;
    }
}