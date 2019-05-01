using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using LdxNotas.Entidades;
using LdxNotas.Functions;

namespace LdxNotas {
    class Program {
        static void Main(string[] args) {

           // try {
                string query, titulo, descricao, data, cdnota,nome;
                int seq = 0, editar, existe;
                Funcoes funcao = new Funcoes();
                Usuarios usuario;
                Notas nota;
                Banco banco = new Banco();


                SqlCeCommand operario = new SqlCeCommand();
                SqlCeConnection conexao = banco.ConectarBanco();
               
                //Tela de Login
                Console.WriteLine("------------LDXNOTAS--------------");
                Console.Write("LOGIN: ");
                string login = Console.ReadLine();
                Console.Write("SENHA: ");
                string senha = Console.ReadLine();
                Console.WriteLine("");


                //Valida login


                SqlCeDataAdapter adaptador = new SqlCeDataAdapter($" DSNOME,CDusu FROM TUSUARIOS " +
                    $"WHERE DSLOGIN='{login}' AND DSSENH='{funcao.Criptografa(senha)}';", conexao);
                DataTable dados = new DataTable();
                dados.Clear();
                
                string codigo = banco.BuscaCodigoUsuario(login,senha,conexao);
                

                if (!banco.ValidaLoginTusuarios(login,senha,conexao)) {
                
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
                            
                            if (banco.VerificaSeLoginUsuarioExiste(login,conexao)) {

                                Console.Write("SENHA: ");
                                senha = Console.ReadLine();

                                usuario = new Usuarios(nome, login, senha);
                                query = "INSERT INTO TUSUARIOS VALUES ('" + usuario.codUsuario +
                                    "','" + usuario.nomUsuario + "','" + usuario.logUsuario + "','" + usuario.senUsuario + "');";
                                operario = new SqlCeCommand(query, conexao);
                                operario.ExecuteNonQuery();


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

                            nota = new Notas(codigo, titulo, descricao);
                            query = "INSERT INTO TNOTAS VALUES ('" + nota.codNota + "','" + nota.codUsuario + "','" + nota.titNota + "','" + nota.desNota + "','" + nota.data + "');";
                            operario = new SqlCeCommand(query, conexao);
                            operario.ExecuteNonQuery();
                        }//=======================================VISUALIZA NOTAS =======================================
                        else if (opcao == 3) {
                            adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TNOTAS WHERE CDUSU='{codigo}';", conexao);
                            dados.Clear();
                            adaptador.Fill(dados);
                            int linhas = int.Parse(dados.Rows[0][seq].ToString());
                            seq++;

                            adaptador = new SqlCeDataAdapter($"SELECT CDNOTA,DSTITU,DSNOTA,DTNOTA FROM TNOTAS WHERE CDUSU='{codigo}'", conexao);
                            dados.Clear();
                            adaptador.Fill(dados);

                            for (int i = 0; i < linhas; i++) {
                                cdnota = dados.Rows[i][seq].ToString();
                                seq++;
                                titulo = dados.Rows[i][seq].ToString();
                                seq++;
                                descricao = dados.Rows[i][seq].ToString();
                                seq++;
                                data = dados.Rows[i][seq].ToString();
                                seq++;
                                Console.WriteLine($"--------------NOTA {cdnota} --------------");
                                Console.WriteLine($"TÍTULO: {titulo}");
                                Console.WriteLine($"DESCRIÇÃO: {descricao}");
                                Console.WriteLine($"DATA DE ALTERAÇÃO: {data}");
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

                            adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TNOTAS WHERE CDNOTA='{cdnota}';", conexao);
                            dados.Clear();
                            adaptador.Fill(dados);
                            existe = int.Parse(dados.Rows[0][seq].ToString());
                            seq++;

                            if (existe == 0) {
                                Console.WriteLine("Nota não existe!");
                            } else {
                                if (editar == 1) {
                                    Console.WriteLine("Novo título: ");
                                    titulo = Console.ReadLine();
                                    Notas t1 = new Notas();
                                    query = "UPDATE TNOTAS SET DSTITU='" + titulo + "',DTNOTA='" + t1.DataTexto() + "' WHERE CDNOTA='" + cdnota + "';";
                                    operario = new SqlCeCommand(query, conexao);
                                    operario.ExecuteNonQuery();

                                } else if (editar == 2) {
                                    Console.WriteLine("Nova descrição: ");
                                    descricao = Console.ReadLine();
                                    Notas t1 = new Notas();
                                    query = "UPDATE TNOTAS SET DSNOTA='" + descricao + "',DTNOTA='" + t1.DataTexto() + "' WHERE CDNOTA='" + cdnota + "';";
                                    operario = new SqlCeCommand(query, conexao);
                                    operario.ExecuteNonQuery();
                                }
                            }


                        }


                    } while (opcao != 0);
                }
                conexao.Close();

            //} catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}

        }


    }
}
