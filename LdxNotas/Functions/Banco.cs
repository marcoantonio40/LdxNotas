using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;


namespace LdxNotas.Functions {
    class Banco {
        Funcoes funcao = new Funcoes();
        SqlCeDataAdapter adaptador;
        int existe;

        public SqlCeConnection ConectarBanco() {
            SqlCeConnection conector = new SqlCeConnection();
            conector.ConnectionString = @"Data Source=C:\csharp\LDXNOTAS\LdxNotas\landix.sdf;Password=landix";
            conector.Open();

            return conector;
        }

        public bool ValidaLoginTusuarios(string login, string senha, SqlCeConnection conexao) {
            adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TUSUARIOS " +
                $"WHERE DSLOGIN='{login}' AND DSSENH='{funcao.Criptografa(senha)}'", conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            existe = int.Parse(dados.Rows[0][0].ToString());

            if (existe == 0) {
                return false;
            } else {
                return true;
            }

        }

        public string BuscaCodigoUsuario(string login, string senha, SqlCeConnection conexao) {
            adaptador = new SqlCeDataAdapter($"SELECT CDUSU FROM TUSUARIOS " +
                $"WHERE DSLOGIN='{login}' AND DSSENH='{funcao.Criptografa(senha)}'", conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            return dados.Rows[0][0].ToString();

        }

        public bool VerificaSeLoginUsuarioExiste(string login,SqlCeConnection conexao) {
            adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TUSUARIOS WHERE DSLOGIN='{login}';", conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            existe=int.Parse(dados.Rows[0][0].ToString());

            if (existe == 0) {
                return true;
            } else {
                return false;
            }
            
        }

        public string PegaUltimoCodigoNota() {
            adaptador = new SqlCeDataAdapter($"SELECT MAX(CDNOTA)+1 FROM TNOTAS;", this.ConectarBanco());
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            return dados.Rows[0][0].ToString();
        }
    }
}