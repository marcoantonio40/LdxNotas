using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LdxNotas.Entidades.Excecoes;

namespace LdxNotas.Entidades {
    class TUSUARIOS {


        public string codUsuario { get; set; }
        public string nomUsuario { get; set; }
        public string logUsuario { get; set; }
        public string senUsuario { get; set; }

        public TUSUARIOS() {
            }
        public TUSUARIOS(string codUsuario, string nomUsuario, string logUsuario, string senUsuario) {
            if (codUsuario.Length > 36) {
                throw new DomainException("Erro no cadastro do usuários - O código do usuário tem mais do que 36 caracteres!");
            }
            else if (IsNumeric(codUsuario)) {
                throw new DomainException("Erro no cadastro do usuários - O código do usuário contém caracters não numéricos!");
            } 
            else {
                this.codUsuario = codUsuario;
            }
            
            this.nomUsuario = nomUsuario;
            this.logUsuario = logUsuario;
            this.senUsuario = senUsuario;
        }

        public bool IsNumeric(string codUsuario) {
            bool isnumeric = false;
            char[] datachars = codUsuario.ToCharArray();

            foreach (var datachar in datachars)
                isnumeric = isnumeric ? char.IsDigit(datachar) : isnumeric;


            return isnumeric;
        }



    }
}
