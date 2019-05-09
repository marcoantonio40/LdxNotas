using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LdxNotas.Functions;
using LdxNotas.Entidades;


namespace LdxNotas {
    public partial class TelaNotas : Form {
        Funcoes funcao = new Funcoes();
        Notas nota = new Notas();
        Banco banco = new Banco();
        string codigo;
        public TelaNotas(String codigoUsuario) {
            this.codigo = codigoUsuario;
            InitializeComponent();
        }
        public TelaNotas() { }
                

        private void ButtonTelaNotaSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ButtonTelaNotaCadastrar_Click(object sender, EventArgs e) {
            LabelTelaNotaTitulo.Visible = true;
            LabelTelaNotaDescricao.Visible = true;
            TextBoxTelaNotaTitulo.Visible = true;
            TextBoxTelaNotaDescricao.Visible = true;
            funcao.AtivarBotoesTelaNota(ButtonTelaNotaConfirmar, ButtonTelaNotaCancelar, this.Controls);

        }

        private void ButtonTelaNotaCancelar_Click(object sender, EventArgs e) {
            funcao.LimparTextBoxes(this.Controls);
        }

        private void ButtonTelaNotaConfirmar_Click(object sender, EventArgs e) {
            if (!(TextBoxTelaNotaTitulo.Text is null && TextBoxTelaNotaDescricao.Text is null)) {
                nota = new Notas(codigo, TextBoxTelaNotaTitulo.Text, TextBoxTelaNotaDescricao.Text);
                banco.InsereNotasBanco(nota);
                funcao.LimparTextBoxes(this.Controls);
                LabelTelaNotasStatus.Visible = true;
                ButtonTelaNotaVisualizar.Enabled = true;
            }
        }

        private void ButtonTelaNotaVisualizar_Click(object sender, EventArgs e) {
            DataTable notas = new DataTable();
            notas = banco.ObterNotas(codigo);

            LabelTelaNotasStatus.Visible = false;
            notas.Columns[0].ColumnName = "CÓDIGO";
            notas.Columns[1].ColumnName = "TÍTULO";
            notas.Columns[2].ColumnName = "DESCRIÇÃO";
            notas.Columns[3].ColumnName = "CRIAÇÃO/ALTERAÇÃO";
            DataGridViewTelaNota.DataSource = notas;
            foreach (DataGridViewColumn column in DataGridViewTelaNota.Columns) {
                                
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
            ButtonTelaNotaVisualizar.Enabled = false;

            
        }

        private void TextBoxTelaNotaTitulo_TextChanged(object sender, EventArgs e) {
            LabelTelaNotasStatus.Visible = false;
        }

        private void TextBoxTelaNotaDescricao_TextChanged(object sender, EventArgs e) {
            LabelTelaNotasStatus.Visible = false;
        }

        private void ButtonTelaNotaEditar_Click(object sender, EventArgs e) {
            LabelTelaNotaTitulo.Visible = true;
            LabelTelaNotaDescricao.Visible = true;
            TextBoxTelaNotaTitulo.Visible = true;
            TextBoxTelaNotaDescricao.Visible = true;
            funcao.AtivarBotoesTelaNota(ButtonTelaNotaCancelar, ButtonTelaNotaConfirmarEdicao, this.Controls);
        }

        private void DataGridViewTelaNota_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            LabelTelaNotaCodigoNota.Text = DataGridViewTelaNota.Rows[e.RowIndex].Cells[0].Value.ToString();
            string titulo = DataGridViewTelaNota.Rows[e.RowIndex].Cells[1].Value.ToString();
            string descricao = DataGridViewTelaNota.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            TextBoxTelaNotaTitulo.Text = titulo;
            TextBoxTelaNotaDescricao.Text = descricao;
            LabelTelaNotaDescricaoDelecao.Text = descricao;
            LabelTelaNotaTituloDelecao.Text = titulo;

        }

        private void ButtonTelaNotaConfirmarEdicao_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Edição de nota" + Environment.NewLine +
                        "Deseja alterar?", "Atenção", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                banco.AlteraValorDaNotaForm(LabelTelaNotaCodigoNota.Text, TextBoxTelaNotaTitulo.Text, TextBoxTelaNotaDescricao.Text);
                funcao.LimparTextBoxes(this.Controls);
                ButtonTelaNotaVisualizar.Enabled = true;
            } else {
                funcao.LimparTextBoxes(this.Controls);
            }

                
        }

        private void ButtonTelaNotaDeletar_Click(object sender, EventArgs e) {
            funcao.AtivarBotoesTelaNota(ButtonTelaNotaConfirmarDelecao, ButtonTelaNotaCancelarDelecao, this.Controls);
            funcao.MostarLabels(LabelTelaNotaTitulo, LabelTelaNotaDescricao, LabelTelaNotaDescricaoDelecao, LabelTelaNotaTituloDelecao,this.Controls);       
            LabelTelaNotaTituloDelecao.MaximumSize = new Size(150, 0);
            LabelTelaNotaTituloDelecao.AutoSize = true;
            LabelTelaNotaTituloDelecao.Location = new Point(13, 281);
            LabelTelaNotaDescricaoDelecao.Location = new Point(13, 324);
            LabelTelaNotaDescricaoDelecao.MaximumSize = new Size(150, 0);
            LabelTelaNotaDescricaoDelecao.AutoSize = true;
            TextBoxTelaNotaTitulo.Visible = false;
            TextBoxTelaNotaDescricao.Visible = false;
            

        }

        private void ButtonTelaNotaConfirmarDelecao_Click(object sender, EventArgs e) {
            funcao.LimparLabels(LabelTelaNotaTituloDelecao, LabelTelaNotaDescricaoDelecao, this.Controls);

            if (MessageBox.Show("Deleção de nota" + Environment.NewLine +
                        "Deseja deletar?", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                banco.DeletarNota(LabelTelaNotaCodigoNota.Text);
                funcao.LimparTextBoxes(this.Controls);
                
            } else {
                funcao.LimparLabels(this.Controls);
            }

            LabelTelaNotasStatus.Text = "Nota deletada";
            LabelTelaNotasStatus.Visible = true;
            ButtonTelaNotaVisualizar.Enabled = true;
        }

        private void ButtonTelaNotaCancelarDelecao_Click(object sender, EventArgs e) {

            funcao.LimparLabels(LabelTelaNotaTituloDelecao, LabelTelaNotaDescricaoDelecao, this.Controls);


        }
    }
}
