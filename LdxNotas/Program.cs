using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using LdxNotas.Entidades;


namespace LdxNotas {
    class Program {
        static void Main(string[] args) {

            try {
            string query,tit,desc,data, cdnota;
            int seq = 0,editar,existe;
            Funcoes f = new Funcoes();
            TUSUARIOS usu;
            TNOTAS t;

            SqlCeCommand operario = new SqlCeCommand();
            SqlCeConnection conexao = new SqlCeConnection();
            conexao.ConnectionString = @"Data Source=C:\csharp\LDXNOTAS\LdxNotas\landix.sdf;Password=landix";
            conexao.Open();


            //Tela de Login
            Console.WriteLine("------------LDXNOTAS--------------");
            Console.Write("LOGIN: ");
            string login = Console.ReadLine();
            Console.Write("SENHA: ");
            string senha = Console.ReadLine();
            Console.WriteLine("");


            //Valida login

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter($"SELECT DSNOME,CDUSU FROM TUSUARIOS " +
                $"WHERE DSLOGIN='{login}' AND DSSENH='{f.Criptografa(senha)}';", conexao);
            DataTable dados = new DataTable();
            dados.Clear();
            adaptador.Fill(dados);
            string nome = null;
            string codigo = null;
            nome = dados.Rows[0][seq].ToString();
            seq++;
            codigo = dados.Rows[0][seq].ToString();//código do usuário
            seq++;

            if (nome is null) {
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
                        adaptador = new SqlCeDataAdapter($"SELECT count(*) FROM TUSUARIOS " +
                                                         $"WHERE DSLOGIN='{login}';", conexao);

                        dados.Clear();
                        adaptador.Fill(dados);

                        existe = 0;
                        existe = int.Parse(dados.Rows[0][seq].ToString());
                        seq++;
                        if (existe == 0) {

                            Console.Write("SENHA: ");
                            senha = Console.ReadLine();

                            usu = new TUSUARIOS(nome, login, senha);
                            query = "INSERT INTO TUSUARIOS VALUES ('" + usu.codUsuario +
                                "','" + usu.nomUsuario + "','" + usu.logUsuario + "','" + usu.senUsuario + "');";
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
                        tit = Console.ReadLine();
                        Console.Write("Descrição da Nota: ");
                        desc = Console.ReadLine();

                        t = new TNOTAS(codigo, tit, desc);
                        query = "INSERT INTO TNOTAS VALUES ('" + t.codNota + "','" + t.codUsuario + "','" + t.titNota + "','" + t.desNota + "','" + t.data + "');";
                        operario = new SqlCeCommand(query, conexao);
                        operario.ExecuteNonQuery();
                    }//=======================================VISUALIZA NOTAS =======================================
                    else if (opcao == 3) {
                        adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TNOTAS WHERE CDUSU='{codigo}';", conexao);
                        dados.Clear();
                        adaptador.Fill(dados);
                        int linhas = int.Parse(dados.Rows[0][seq].ToString());
                        seq++;

                        adaptador = new SqlCeDataAdapter($"SELECT CDNOTA,DSTITU,DSNOTA,DTNOTA FROM TNOTAS WHERE CDUSU='{codigo}'",conexao);
                        dados.Clear();
                        adaptador.Fill(dados);
                        
                        for(int i = 0; i < linhas; i++) {
                            cdnota = dados.Rows[i][seq].ToString();
                            seq++;
                            tit = dados.Rows[i][seq].ToString();
                            seq++;
                            desc = dados.Rows[i][seq].ToString();
                            seq++;
                            data = dados.Rows[i][seq].ToString();
                            seq++;
                            Console.WriteLine($"--------------NOTA {cdnota} --------------");
                            Console.WriteLine($"TÍTULO: {tit}");
                            Console.WriteLine($"DESCRIÇÃO: {desc}");
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
                                tit = Console.ReadLine();
                                TNOTAS t1 = new TNOTAS();
                                query = "UPDATE TNOTAS SET DSTITU='" + tit + "',DTNOTA='" + t1.DataTexto() + "' WHERE CDNOTA='" + cdnota + "';";
                                operario = new SqlCeCommand(query, conexao);
                                operario.ExecuteNonQuery();

                            }else if (editar == 2) {
                                Console.WriteLine("Nova descrição: ");
                                desc = Console.ReadLine();
                                TNOTAS t1 = new TNOTAS();
                                query = "UPDATE TNOTAS SET DSNOTA='" + desc + "',DTNOTA='" + t1.DataTexto() + "' WHERE CDNOTA='" + cdnota + "';";
                                operario = new SqlCeCommand(query, conexao);
                                operario.ExecuteNonQuery();
                            }
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
