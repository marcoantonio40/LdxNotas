using System.Data.SqlServerCe;
using System.Data;
using LdxNotas.Entidades;
using LdxNotas.Entidades.Excecoes;

namespace LdxNotas.Functions {
    /// <summary>
    /// Classe que realiza as operações que precisem
    /// conectar-se ao banco de dados.
    /// </summary>
    class Banco {
        Funcoes funcao = new Funcoes();
        SqlCeDataAdapter adaptador;
        SqlCeCommand operario;
        int existe;
        
        //Método para conectar no banco de dados
        public SqlCeConnection ConectarBanco() {
            SqlCeConnection conector = new SqlCeConnection();
            conector.ConnectionString = @"Data Source=C:\csharp\LDXNOTAS\LdxNotas\landix.sdf;Password=landix";
            conector.Open();

            return conector;
        }
        
        //Método para verificar se o login e a senha estão corretas
        public bool ValidaLoginTusuarios(string login, string senha, SqlCeConnection conexao) {
            try {
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
            } catch {
                throw new DomainException("Erro na Validação de login!");
            }

        }

        //Método para buscar o código do usuário que efetuou o login no sistema
        public string BuscaCodigoUsuario(string login, string senha, SqlCeConnection conexao) {
            try {
                adaptador = new SqlCeDataAdapter($"SELECT CDUSU FROM TUSUARIOS " +
                    $"WHERE DSLOGIN='{login}' AND DSSENH='{funcao.Criptografa(senha)}'", conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                return dados.Rows[0][0].ToString();
            } catch {
                throw new DomainException("Erro na busca de código do usuário!");
            }
        }

        //Método para verificar se o usuário existe no sistema.
        public bool VerificaSeLoginUsuarioExiste(string login, SqlCeConnection conexao) {
            try {
                adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TUSUARIOS WHERE DSLOGIN='{login}';", conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);
                existe = int.Parse(dados.Rows[0][0].ToString());

                if (existe == 0) {
                    return true;
                } else {
                    return false;
                }
            } catch {
                throw new DomainException("Erro na verificação da existencia do usuários!");
            }

        }

        //pega o último código das notas para ser usado para ser criada uma nova nota na classe Notas
        
        public string PegaUltimoCodigoNota() {
            try {
                adaptador = new SqlCeDataAdapter($"SELECT MAX(CDNOTA)+1 FROM TNOTAS;", this.ConectarBanco());
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                return dados.Rows[0][0].ToString();
            } catch {
                throw new DomainException("Erro para pegar o último código da nota!");
            }
        }

        //Método para inserir um usuário no banco de dados
        public void InsereUsuariosBanco(Usuarios usuario) {
            try {
                string query = $"INSERT INTO TUSUARIOS VALUES ('{usuario.codUsuario}'" +
                    $",'{usuario.nomUsuario}','{usuario.logUsuario}','{usuario.senUsuario}');";
                operario = new SqlCeCommand(query, this.ConectarBanco());
                operario.ExecuteNonQuery();
            } catch {
                throw new DomainException("Erro para inserir usuários no banco!");
            }
        }

        //Método para inserir notas no banco
        public void InsereNotasBanco(Notas nota) {
            try {
                string query = $"INSERT INTO TNOTAS VALUES ('{nota.codigoNota}','{nota.codigoUsuario}'," +
                    $"'{nota.tituloNota}','{nota.descricaoNota}','{nota.dataNota}');";
                operario = new SqlCeCommand(query, this.ConectarBanco());
                operario.ExecuteNonQuery();
            } catch {
                throw new DomainException("Erro ao inseir uma nota no banco!");
            }
        }

        //Pega as notas de um usuário para exibir no DataGridView
        public DataTable ObterNotas(string codigoUsuario) {
            try {
                adaptador = new SqlCeDataAdapter($"SELECT CDNOTA,DSTITU,DSNOTA,DTNOTA " +
                    $"FROM TNOTAS WHERE CDUSU='{codigoUsuario}'", this.ConectarBanco());
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                return dados;
            } catch {
                throw new DomainException("Erro ao obter o valor das notas!");
            }


        }

        //Método para contar quantas notas o usuário tem.
        public int QuantidadeDeNotasPorUsuario(string codigoUsuario) {
            try {
                adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) " +
                    $"FROM TNOTAS WHERE CDUSU='{codigoUsuario}'", this.ConectarBanco());
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                return int.Parse(dados.Rows[0][0].ToString());
            } catch {
                throw new DomainException("Erro ao buscar o número de notas do usuário!");
            }
        }

        //Função usada no modo console para editar um valor
        public DataTable ObtemValordaNota(string codigoNota, string campo) {
            try {
                adaptador = new SqlCeDataAdapter($"SELECT {campo} " +
                    $"FROM TNOTAS WHERE CDNOTA='{codigoNota}'", this.ConectarBanco());
                DataTable dados = new DataTable();
                if (dados is null) {
                    throw new DomainException("Nota não existe!");
                }
                adaptador.Fill(dados);

                return dados;
            } catch {
                throw new DomainException("Erro ao obter os valores de uma nota!");
            }
        }

        //Função usada no modo console para editar um valor
        public void AlteraValorDaNota(string codigoNota, string campo, string novoValor) {
            try {
                Notas nota = new Notas();
                string query = $"UPDATE TNOTAS SET {campo} = '{novoValor}', DTNOTA = '{nota.DataTexto()}'" +
                    $" WHERE CDNOTA = '{codigoNota}';";
                operario = new SqlCeCommand(query, this.ConectarBanco());

                operario.ExecuteNonQuery();
            } catch {
                throw new DomainException("Erro ao alteraro valor da nota!");
            }
        }

        //Método para editar as notas que o usuário escolher
        public void AlteraValorDaNotaForm(string codigoNota, string novoTitulo, string novaDescricao) {
            try {
                Notas nota = new Notas();
                string query = $"UPDATE TNOTAS SET DSTITU = '{novoTitulo}', DSNOTA = '{novaDescricao}', DTNOTA = '{nota.DataTexto()}'" +
                    $" WHERE CDNOTA = '{codigoNota}';";
                operario = new SqlCeCommand(query, this.ConectarBanco());

                operario.ExecuteNonQuery();
            } catch {
                throw new DomainException("Erro ao alterar o valor de uma nota!");
            }
        }

        //Método para deletar as notas
        public void DeletarNota(string codigoNota) {
            try {
                string query = $"DELETE FROM TNOTAS WHERE CDNOTA = '{codigoNota}';";
                operario = new SqlCeCommand(query, this.ConectarBanco());
                operario.ExecuteNonQuery();
            } catch {
                throw new DomainException("Erro ao deletar uma nota!");
            }
            
        }


    }
}