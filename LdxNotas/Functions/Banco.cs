using System.Data.SqlServerCe;
using System.Data;
using LdxNotas.Entidades;
using LdxNotas.Entidades.Excecoes;

namespace LdxNotas.Functions {
    class Banco {
        Funcoes funcao = new Funcoes();
        SqlCeDataAdapter adaptador;
        SqlCeCommand operario;
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

        public bool VerificaSeLoginUsuarioExiste(string login, SqlCeConnection conexao) {
            adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TUSUARIOS WHERE DSLOGIN='{login}';", conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            existe = int.Parse(dados.Rows[0][0].ToString());

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

        public void InsereUsuariosBanco(Usuarios usuario) {
            string query = $"INSERT INTO TUSUARIOS VALUES ('{usuario.codUsuario}'" +
                $",'{usuario.nomUsuario}','{usuario.logUsuario}','{usuario.senUsuario}');";
            operario = new SqlCeCommand(query, this.ConectarBanco());
            operario.ExecuteNonQuery();

        }

        public void InsereNotasBanco(Notas nota) {
            string query = $"INSERT INTO TNOTAS VALUES ('{nota.codigoNota}','{nota.codigoUsuario}'," +
                $"'{nota.tituloNota}','{nota.descricaoNota}','{nota.dataNota}');";
            operario = new SqlCeCommand(query, this.ConectarBanco());
            operario.ExecuteNonQuery();
        }

        public DataTable ObterNotas(string codigoUsuario) {
            adaptador = new SqlCeDataAdapter($"SELECT CDNOTA,DSTITU,DSNOTA,DTNOTA " +
                $"FROM TNOTAS WHERE CDUSU='{codigoUsuario}'", this.ConectarBanco());
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            return dados;

        }

        public int QuantidadeDeNotasPorUsuario(string codigoUsuario) {
            adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) " +
                $"FROM TNOTAS WHERE CDUSU='{codigoUsuario}'", this.ConectarBanco());
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            return int.Parse(dados.Rows[0][0].ToString());
        }

        public DataTable ObtemValordaNota(string codigoNota, string campo) {
            adaptador = new SqlCeDataAdapter($"SELECT {campo} " +
                $"FROM TNOTAS WHERE CDNOTA='{codigoNota}'", this.ConectarBanco());
            DataTable dados = new DataTable();
            if (dados is null) {
                throw new DomainException("Nota não existe!");
            }
            adaptador.Fill(dados);

            return dados;
        }

        public void AlteraValorDaNota(string codigoNota, string campo, string novoValor) {
            Notas nota = new Notas();
            string query = $"UPDATE TNOTAS SET {campo} = '{novoValor}', DTNOTA = '{nota.DataTexto()}'" +
                $" WHERE CDNOTA = '{codigoNota}';";
            operario = new SqlCeCommand(query, this.ConectarBanco());
            
            operario.ExecuteNonQuery();
            
        }

        public void AlteraValorDaNotaForm(string codigoNota, string novoTitulo, string novaDescricao) {
            Notas nota = new Notas();
            string query = $"UPDATE TNOTAS SET DSTITU = '{novoTitulo}', DSNOTA = '{novaDescricao}', DTNOTA = '{nota.DataTexto()}'" +
                $" WHERE CDNOTA = '{codigoNota}';";
            operario = new SqlCeCommand(query, this.ConectarBanco());

            operario.ExecuteNonQuery();

        }

        public void DeletarNota(string codigoNota) {

            string query = $"DELETE FROM TNOTAS WHERE CDNOTA = '{codigoNota}';";
            operario = new SqlCeCommand(query, this.ConectarBanco());
            operario.ExecuteNonQuery();

        }


    }
}