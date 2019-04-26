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
            string query;
            int seq = 0;
            Funcoes f = new Funcoes();
            SqlCeCommand operaio = new SqlCeCommand();
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
                Console.WriteLine("Bem vindo, " + nome);
                Console.WriteLine("Escolha a opção:");
                Console.WriteLine("0 - Sair:");
                Console.WriteLine("1 - Cadastrar Usuários");
                Console.WriteLine("2 - Cadastrar Nota");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                do {
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
                        existe = int.Parse(dados.Rows[0][seq].ToString());
                        seq++;
                        if (existe == 0) {

                            Console.Write("SENHA: ");
                            senha = Console.ReadLine();

                            TUSUARIOS usu = new TUSUARIOS(nome, login, senha);
                            query = "INSERT INTO TUSUARIOS VALUES ('" + usu.codUsuario +
                                "','" + usu.nomUsuario + "','" + usu.logUsuario + "','" + usu.senUsuario + "');";
                            operaio = new SqlCeCommand(query, conexao);
                            operaio.ExecuteNonQuery();


                        } else {
                            Console.WriteLine("Login já existente!");
                        }


                    }
                    //=======================================CADASTRA =======================================
                    else if (opcao == 2) {
                        Console.WriteLine("");
                        Console.WriteLine("===============Cadastre a nota:==============");
                        Console.Write("Título da Nota: ");
                        string tit = Console.ReadLine();
                        Console.Write("Descrição da Nota: ");
                        string desc = Console.ReadLine();

                        TNOTAS t = new TNOTAS(codigo, tit, desc);
                        query = "INSERT INTO TNOTAS VALUES ('" + t.codNota + "','" + t.codUsuario + "','" + t.titNota + "','" + t.desNota + "','" + t.data + "');";
                        operaio = new SqlCeCommand(query, conexao);
                        operaio.ExecuteNonQuery();
                        

                    }

                } while (opcao != 0);
            }
            conexao.Close();

            //    } catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}

        }


    }
}
