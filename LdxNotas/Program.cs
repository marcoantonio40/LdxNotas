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
                Funcoes f = new Funcoes();
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
                nome = dados.Rows[0][0].ToString();
                codigo = dados.Rows[0][1].ToString();//código do usuário

               
                if (nome is null) {
                    Console.WriteLine("Login Inválido!");
                } else {
                    Console.WriteLine("Bem vindo, " + nome);
                    Console.WriteLine("Escolha a opção:");
                    Console.WriteLine("1 - Cadastrar Usuários");
                    Console.WriteLine("2 - Cadastrar Nota");
                    int opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    //=======================================CADASTRA USUÁRIO=======================================
                    if (opcao == 1) {
                        Console.Write("NOME: ");
                        nome = Console.ReadLine();
                        Console.Write("LOGIN: ");
                        login = Console.ReadLine();
                        adaptador = new SqlCeDataAdapter($"SELECT count(*) FROM TUSUARIOS " +
                                                         $"WHERE DSLOGIN='{login}';", conexao);

                    dados.Clear();
                    adaptador.Fill(dados);
                        
                        int existe = 0;
                        existe = int.Parse(dados.Rows[0][2].ToString());
                        
                        if (existe == 0) {
                        
                            Console.Write("SENHA: ");
                            senha = Console.ReadLine();

                            TUSUARIOS usu = new TUSUARIOS(nome, login, senha);
                            string query = "INSERT INTO TUSUARIOS VALUES ('" + usu.codUsuario +
                                "','" + usu.nomUsuario + "','" + usu.logUsuario + "','" + usu.senUsuario + "');";
                            SqlCeCommand operaio = new SqlCeCommand(query, conexao);
                            operaio.ExecuteNonQuery();


                    } else {
                            Console.WriteLine("Login já existente!");
                        }


                    }
                    //=======================================CADASTRA =======================================
                    else if (opcao==2) {
                        Console.WriteLine("");
                        Console.WriteLine("===============Cadastre a nota:==============");
                        Console.Write("Título da Nota:");
                        string tit = Console.ReadLine();
                        Console.Write("Descrição da Nota:");
                        string desc = Console.ReadLine();

                        adaptador = new SqlCeDataAdapter($"SELECT MAX(CDNOTA) FROM TNOTAS; ", conexao);
                        dados.Clear();
                        adaptador.Fill(dados);
                        int cdnota = 0;
                        cdnota = ((int)dados.Rows[0][2])+1;


                        TNOTAS t = new TNOTAS(cdnota.ToString(),codigo,tit,desc,DateTime.Now);


                    }

                }
                conexao.Close();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }


        }
}
