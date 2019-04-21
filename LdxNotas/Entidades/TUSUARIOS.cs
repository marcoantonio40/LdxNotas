using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LdxNotas.Entidades.Excecoes;

namespace LdxNotas.Entidades {
    class TUSUARIOS {

        public Funcoes f = new Funcoes();
        public string codUsuario { get; set; }
        public string nomUsuario { get; set; }
        public string logUsuario { get; set; }
        public string senUsuario { get; set; }

        public TUSUARIOS() {
        }
        public TUSUARIOS(string codUsuario, string nomUsuario, string logUsuario, string senUsuario) {
            if (codUsuario.Length > 36) {
                throw new DomainException("Erro no cadastro do usuários - O código do usuário tem mais do que 36 caracteres!");
            } else if (f.IsNumeric(codUsuario)) {
                throw new DomainException("Erro no cadastro do usuários - O código do usuário contém caracters não numéricos!");
            } else {
                this.codUsuario = codUsuario;
            }

            if (nomUsuario.Length > 50) {
                throw new DomainException("Erro no cadastro de usuários - O nome do usuário contém mais do que 50 caracteres!");
            } else if (f.IsNumeric(nomUsuario)) {
                throw new DomainException("Erro no cadastro de usuários - O nome do usuário não pode conter números ou caracteres especiais!");
            } else {
                this.nomUsuario = nomUsuario;
            }

            if (logUsuario.Length > 50) {
                throw new DomainException("Erro no cadastro de usuários - O  login contém mais do que 50 caracteres!");
            } else if (f.IsNumeric(logUsuario)) {
                throw new DomainException("Erro no cadastro de usuários - O  login não pode conter números ou caracteres especiais!");
            } else {
                this.logUsuario = logUsuario;
            }

            if (senUsuario.Length > 50) {
                throw new DomainException("Erro no cadastro de usuários - A senha contém mais do que 50 caracteres!");
            } else {
                this.senUsuario = f.Criptografa(senUsuario);
            }
        }





    }
}
