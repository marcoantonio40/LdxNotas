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
namespace LdxNotas {
    public partial class TelaLogin : Form {
        Banco banco = new Banco();

        public TelaLogin() {
            InitializeComponent();
        }

        private void ButtonLogar_Click(object sender, EventArgs e) {

            if (banco.ValidaLoginTusuarios(TetxBoxLogin.Text, TextBoxSenha.Text, banco.ConectarBanco())) {
                string codigoUsuario = banco.BuscaCodigoUsuario(TetxBoxLogin.Text, TextBoxSenha.Text, banco.ConectarBanco());
                TelaNotas telaNota = new TelaNotas(codigoUsuario);
                this.Visible = false;
                telaNota.ShowDialog();

            } else {
                MessageBox.Show("Usuário não existe!");
            }
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e) {
            CadastrarUsuario cadastraUsuario = new CadastrarUsuario();
            this.Visible = false;
            cadastraUsuario.ShowDialog();


        }

        private void ButtonSair_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
