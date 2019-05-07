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
                

        private void ButtonTelaNotaSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ButtonTelaNotaCadastrar_Click(object sender, EventArgs e) {
            LabelTelaNotaTitulo.Visible = true;
            LabelTelaNotaDescricao.Visible = true;
            TextBoxTelaNotaTitulo.Visible = true;
            TextBoxTelaNotaDescricao.Visible = true;
            ButtonTelaNotaConfirmar.Visible = true;
            ButtonTelaNotaCancelar.Visible = true;

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
            }
        }

        private void ButtonTelaNotaVisualizar_Click(object sender, EventArgs e) {
            DataTable notas = new DataTable();
            notas = banco.ObterNotas(codigo);
            //DataGridViewTelaNota.Columns[0].Name = "Código";
            notas.Columns[0].ColumnName = "CÓDIGO";
            notas.Columns[1].ColumnName = "TÍTULO";
            notas.Columns[2].ColumnName = "DESCRIÇÃO";
            notas.Columns[3].ColumnName = "CRIAÇÃO/ALTERAÇÃO";
            
            
            DataGridViewTelaNota.DataSource = notas;
        }

        private void TextBoxTelaNotaTitulo_TextChanged(object sender, EventArgs e) {
            LabelTelaNotasStatus.Visible = false;
        }

        private void TextBoxTelaNotaDescricao_TextChanged(object sender, EventArgs e) {
            LabelTelaNotasStatus.Visible = false;
        }
    }
}
