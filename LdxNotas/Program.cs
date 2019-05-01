using System;
using System.Data.SqlServerCe;
using System.Data;
using LdxNotas.Entidades;
using LdxNotas.Functions;

namespace LdxNotas {
    class Program {
        static void Main(string[] args) {

            try {
                string  titulo, descricao, cdnota, nome;
                int seq = 0, editar;
                Funcoes funcao = new Funcoes();
                Usuarios usuario;
                Notas nota;
                Banco banco = new Banco();             
                SqlCeConnection conexao = banco.ConectarBanco();

                //Tela de Login
                Console.WriteLine("------------LDXNOTAS--------------");
                Console.Write("LOGIN: ");
                string login = Console.ReadLine();
                Console.Write("SENHA: ");
                string senha = Console.ReadLine();
                Console.WriteLine("");

                //Valida login

                DataTable dados = new DataTable();

                string codigoDoUsuario = banco.BuscaCodigoUsuario(login, senha, conexao);

                if (!banco.ValidaLoginTusuarios(login, senha, conexao)) {

                    Console.WriteLine("Login Inválido!");

                } else {
                    int opcao;
                    do {
                        //=======================================CADASTRA USUÁRIO=======================================
                        Console.WriteLine("Escolha a opção:");
                        Console.WriteLine("0 - Sair:");
                        Console.WriteLine("1 - Cadastrar Usuário");
                        Console.WriteLine("2 - Cadastrar Nota");
                        Console.WriteLine("3 - Visualizar Notas");
                        Console.WriteLine("4 - Editar Nota");

                        opcao = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if (opcao == 1) {
                            Console.Write("NOME: ");
                            nome = Console.ReadLine();
                            Console.Write("LOGIN: ");
                            login = Console.ReadLine();

                            if (banco.VerificaSeLoginUsuarioExiste(login, conexao)) {

                                Console.Write("SENHA: ");
                                senha = Console.ReadLine();

                                usuario = new Usuarios(nome, login, senha);
                                banco.InsereUsuariosBanco(usuario);


                            } else {
                                Console.WriteLine("Login já existente!");
                            }


                        }
                        //=======================================CADASTRA =======================================
                        else if (opcao == 2) {
                            Console.WriteLine("");
                            Console.WriteLine("===============Cadastre a nota:==============");
                            Console.Write("Título da Nota: ");
                            titulo = Console.ReadLine();
                            Console.Write("Descrição da Nota: ");
                            descricao = Console.ReadLine();

                            nota = new Notas(codigoDoUsuario, titulo, descricao);
                            banco.InsereNotasBanco(nota);

                        }//=======================================VISUALIZA NOTAS =======================================
                        else if (opcao == 3) {

                            int linhas = banco.QuantidadeDeNotasPorUsuario(codigoDoUsuario);
                            dados = banco.ObterNotas(codigoDoUsuario);

                            for (int i = 0; i < linhas; i++) {

                                Console.WriteLine($"--------------NOTA {dados.Rows[i][seq].ToString()} --------------");
                                seq++;
                                Console.WriteLine($"TÍTULO: {dados.Rows[i][seq].ToString()}");
                                seq++;
                                Console.WriteLine($"DESCRIÇÃO: {dados.Rows[i][seq].ToString()}");
                                seq++;
                                Console.WriteLine($"DATA DE ALTERAÇÃO: {dados.Rows[i][seq].ToString()}");
                                seq++;
                                Console.WriteLine("-------------------------------------");
                                seq -= 4;
                            }
                        }
                        //=======================================EDITAR NOTA =======================================
                        else if (opcao == 4) {
                            Console.WriteLine("Editar qual nota");
                            cdnota = Console.ReadLine();
                            Console.WriteLine("1 - Título");
                            Console.WriteLine("2 - Descrição");
                            editar = int.Parse(Console.ReadLine());

                            if (editar == 1) {
                                dados = banco.ObtemValordaNota(cdnota, "DSTITU");
                                Console.WriteLine("Novo título: ");
                                titulo = Console.ReadLine();
                                banco.AlteraValorDaNota(cdnota, "DSTITU", titulo);

                            } else if (editar == 2) {
                                dados = banco.ObtemValordaNota(cdnota, "DSNOTA");
                                Console.WriteLine("Nova descrição: ");
                                descricao = Console.ReadLine();
                                banco.AlteraValorDaNota(cdnota, "DSNOTA", descricao);
                            }
                        }

                    } while (opcao != 0);
                }
                conexao.Close();

        } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

}


    }
}
