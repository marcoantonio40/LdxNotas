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

            SqlCeConnection conexao = new SqlCeConnection();
            conexao.ConnectionString = @"Data Source=C:\csharp\LDXNOTAS\LdxNotas\landix.sdf;Password=landix";
            conexao.Open();

            Console.WriteLine("COD: ");
            string cod = Console.ReadLine();
            Console.WriteLine("NOME: ");
            string nome = Console.ReadLine();
            Console.WriteLine("LOGIN: ");
            string login = Console.ReadLine();
            Console.WriteLine("SENHA: ");
            string senha = Console.ReadLine();

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TUSUARIOS WHERE CDUSU in ('{cod}');",conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);          
            int a = int.Parse(dados.Rows[0][0].ToString());

            if (a != 0) {
                Console.WriteLine($"Já existe o código {cod}");
            } else {
                TUSUARIOS usu = new TUSUARIOS(cod, nome, login, senha);
                string query= "INSERT INTO TUSUARIOS VALUES ('"+cod+"','"+nome+"','"+login+"','"+senha+"');";              
                SqlCeCommand operaio = new SqlCeCommand(query,conexao);
                operaio.ExecuteNonQuery();
            }


            conexao.Close();
            

            

            







        }
    }
}
