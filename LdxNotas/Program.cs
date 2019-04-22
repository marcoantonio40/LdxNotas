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
            //try {
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
                Console.Write("CÓDIGO: ");




                //Valida login
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter($"SELECT DSNOME FROM TUSUARIOS " +
                    $"WHERE DSLOGIN='{login}' AND DSSENH='{f.Criptografa(senha)}';", conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);
                string nome = null;
                nome = dados.Rows[0][0].ToString();

                if (nome is null) {
                    Console.WriteLine("Login Inválido!");
                } else {
                    Console.WriteLine("Bem vindo, " + nome);
                    Console.WriteLine("Escolha a opção:");
                    Console.WriteLine("1 - Cadastrar Usuários");
                    int opcao = int.Parse(Console.ReadLine());
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
                        
                        int existe = 0;
                        existe = int.Parse(dados.Rows[0][1].ToString());
                    
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

                }
                conexao.Close();
            //} catch(Exception e) {
            //    Console.WriteLine(e.Message);
            //    }

        }





        //SqlCeDataAdapter adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TUSUARIOS WHERE CDUSU in ('{cod}');",conexao);
        //DataTable dados = new DataTable();
        //adaptador.Fill(dados);          
        //int a = int.Parse(dados.Rows[0][0].ToString());

        //if (a != 0) {
        //    Console.WriteLine($"Já existe o código {cod}");
        //} else {
        //    TUSUARIOS usu = new TUSUARIOS(cod, nome, login, senha);
        //    string query= "INSERT INTO TUSUARIOS VALUES ('"+cod+"','"+nome+"','"+login+"','"+senha+"');";              
        //    SqlCeCommand operaio = new SqlCeCommand(query,conexao);
        //    operaio.ExecuteNonQuery();
        //}


        
            

            

            






            
        
    }
}
