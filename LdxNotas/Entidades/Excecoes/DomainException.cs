using System;

namespace LdxNotas.Entidades.Excecoes {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message){

        }
    }
}
