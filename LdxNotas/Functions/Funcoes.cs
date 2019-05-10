using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LdxNotas.Functions {
    /// <summary>
    /// Classe criada para separar funções distintas do 
    /// banco ou das Entidades
    /// </summary>
    class Funcoes {

        public Funcoes() { }

        //Método utilizado para criptografar a senha dos usuários na classe Usuarios e comparar senha na classe Banco
        public string Criptografa(string senha) {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(senha));

            StringBuilder hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes) {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }

        //Método para verificar se um valor tem apenas números inteiros
        public bool IsNumeric(string codUsuario) {
            bool isnumeric = false;
            char[] datachars = codUsuario.ToCharArray();

            foreach (var datachar in datachars)
                isnumeric = isnumeric ? char.IsDigit(datachar) : isnumeric;


            return isnumeric;
        }

        //Método usando para limpar todos os textBoxes
        public void LimparTextBoxes(Control.ControlCollection controles) {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles) {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox) {
                    ((TextBox)(ctrl)).Text = string.Empty;
                }
            }
        }

        //Método usando para limpar todos as Labels
        public void LimparLabels(Control.ControlCollection controles) {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles) {
                //Se o contorle for um TextBox...
                if (ctrl is Label) {
                    ((Label)(ctrl)).Text = string.Empty;
                }
            }
        }

        //Método usando para limpar todos as Labels passada no argumento
        public void LimparLabels(Label titulo,Label descricao, Control.ControlCollection controles) {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles) {
                
                if (ctrl.Name.ToString()==titulo.Name.ToString() || ctrl.Name.ToString() == descricao.Name.ToString()) {
                    ((Label)(ctrl)).Text = string.Empty;
                }
            }
        }

        public void AtivarBotoesTelaNota(Button confimar, Button cancelar, Control.ControlCollection controles) {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles) {

            
                if (ctrl.Name.ToString() == confimar.Name.ToString() || ctrl.Name.ToString() == cancelar.Name.ToString()) {
                    ((Button)(ctrl)).Visible = true;
                } else {
                    if (ctrl is Button) {
                        ctrl.Visible = false;
                        if (ctrl.Name == "ButtonTelaNotaVisualizar" || 
                            ctrl.Name == "ButtonTelaNotaCadastrar"  ||
                            ctrl.Name == "ButtonTelaNotaEditar"     ||
                            ctrl.Name == "ButtonTelaNotaDeletar"    ||
                            ctrl.Name == "ButtonTelaNotaSair") {
                            ctrl.Visible = true;

                        }
                    }
                    
                    
                }

            }
        }

        public void MostrarLabels(Label primeira, Label segunda, Label terceira, Label quarta, Control.ControlCollection controles) {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles) {

                if (ctrl.Name.ToString() == primeira.Name.ToString() || 
                    ctrl.Name.ToString() == segunda.Name.ToString()  ||
                    ctrl.Name.ToString() == terceira.Name.ToString() ||
                    ctrl.Name.ToString() == quarta.Name.ToString()) {
                    if(ctrl is Label) {
                        ctrl.Visible = true;
                    }
                } 
            }
        }


    }
}
