using System;
using LdxNotas.Entidades.Excecoes;
using LdxNotas.Functions;
namespace LdxNotas.Entidades {
    class Notas {

        public Funcoes f = new Funcoes();
        public string codigoNota { get; set; }        public string codigoUsuario { get; set; }        public string tituloNota { get; set; }        public string descricaoNota { get; set; }        public string dataNota { get; set; }        private DateTime dtAlter;
        Banco banco = new Banco();

        public Notas() { }

        public Notas(string codUsuario, string titNota, string desNota) {

            codigoNota = banco.PegaUltimoCodigoNota();


            this.codigoUsuario = codUsuario;
            if (titNota.Length > 50) {
                throw new DomainException("Título com mais de 50 caracteres!");
            } else {
                this.tituloNota = titNota;
            }

            if (desNota.Length > 256) {
                throw new DomainException("Descrição com mais de 256 caracteres!");
            } else {
                this.descricaoNota = desNota;
            }

            dataNota = this.DataTexto();



        }

        public string DataTexto() {
            dtAlter = DateTime.Now;
            string sqlFormattedDate = dtAlter.ToString("yyyy-MM-dd HH:mm:ss.fff");
            dataNota = sqlFormattedDate;
            return dataNota;
        }


    }
}
