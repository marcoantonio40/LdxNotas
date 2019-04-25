using System;
using LdxNotas.Entidades.Excecoes;

namespace LdxNotas.Entidades {
    class TNOTAS {

        public Funcoes f = new Funcoes();
        public string codNota { get; set; }        public string codUsuario { get; set; }        public string titNota { get; set; }        public string desNota { get; set; }        public DateTime dtAlter { get; set; }

        public TNOTAS() { }

        public TNOTAS(string codNota, string codUsuario, string titNota, string desNota, DateTime dtAlter) {
            if (!f.IsNumeric(codNota)) {
                throw new DomainException("Código da nota inválido");
            } else {
                this.codNota = codNota;
            }
            
            this.codUsuario = codUsuario;
            if (titNota.Length > 50) {
                throw new DomainException("Título com mais de 50 caracteres!");
            } else {
                this.titNota = titNota;
            }

            if (desNota.Length > 256) {
                throw new DomainException("Descrição com mais de 256 caracteres!");
            } else {
                this.desNota = desNota;
            }
            
            this.dtAlter = dtAlter;
        }
    }
}
