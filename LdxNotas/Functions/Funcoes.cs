﻿using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LdxNotas.Functions {
    class Funcoes {

        public Funcoes() { }

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

        public bool IsNumeric(string codUsuario) {
            bool isnumeric = false;
            char[] datachars = codUsuario.ToCharArray();

            foreach (var datachar in datachars)
                isnumeric = isnumeric ? char.IsDigit(datachar) : isnumeric;


            return isnumeric;
        }

        public void LimparTextBoxes(Control.ControlCollection controles) {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles) {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox) {
                    ((TextBox)(ctrl)).Text = string.Empty;
                }
            }
        }
    }
}
