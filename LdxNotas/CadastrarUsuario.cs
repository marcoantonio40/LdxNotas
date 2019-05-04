using LdxNotas.Functions;
using LdxNotas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LdxNotas {
    public partial class CadastrarUsuario : Form {
        Banco banco = new Banco();
        Funcoes funcao = new Funcoes();
       
        public CadastrarUsuario() {
            InitializeComponent();
        }
        

        private void ButtonCadastrarSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ButtonCadastrarVoltar_Click(object sender, EventArgs e) {
            TelaLogin telaLogin = new TelaLogin();
            this.Visible = false;
            telaLogin.ShowDialog();
            

        }

        private void ButtonCadastrarRegistrar_Click(object sender, EventArgs e) {
            if (banco.VerificaSeLoginUsuarioExiste(TextBoxCadastrarUsuarioLogin.Text, banco.ConectarBanco())) {
                Usuarios usuario = new Usuarios(TextBoxCadastrarUsuarioNome.Text,
                    TextBoxCadastrarUsuarioLogin.Text, TextBoxCadastrarUsuarioSenha.Text);
                banco.InsereUsuariosBanco(usuario);
                LabelCadastraUsuarioStatus.Text = "Cadastro realizado com sucesso!";
                LabelCadastraUsuarioStatus.Visible = true;
                funcao.LimparTextBoxes(this.Controls);
            }
        }
    }
}
