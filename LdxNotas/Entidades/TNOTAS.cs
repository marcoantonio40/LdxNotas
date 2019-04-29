using System;
using System.IO;
using LdxNotas.Entidades.Excecoes;

namespace LdxNotas.Entidades {
    class TNOTAS {

        public Funcoes f = new Funcoes();
        public string codNota { get; set; }        public string codUsuario { get; set; }        public string titNota { get; set; }        public string desNota { get; set; }        public string data { get; set; }        private DateTime dtAlter;

        public TNOTAS() { }

        public TNOTAS(string codUsuario, string titNota, string desNota) {

            codNota = UltCodNota();
            
            
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

            data = this.DataTexto();

            
            
        }

        public string DataTexto() {
            dtAlter = DateTime.Now;
            string sqlFormattedDate = dtAlter.ToString("yyyy-MM-dd HH:mm:ss.fff");
            data = sqlFormattedDate;
            return data;
        }

        public string UltCodNota() {
            string ultCodNota = "";
            try {
                string caminho = @"C:\csharp\LDXNOTAS\LdxNotas\codNota.txt";
            
                ultCodNota = File.ReadAllText(caminho);
                int novCod = int.Parse(ultCodNota)+1;
                File.WriteAllText(caminho, novCod.ToString());
                

            } catch (IOException e) {
                Console.WriteLine(e.Message);

            }

            return ultCodNota;

        }
    }
}
