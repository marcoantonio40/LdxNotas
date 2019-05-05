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
            }
        }
    }
}
