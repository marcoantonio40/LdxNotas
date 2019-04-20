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
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter($"SELECT COUNT(*) FROM TUSUARIOS WHERE CDUSU in ('s');",conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            string a = dados.Rows[0][0].ToString();
            Console.WriteLine(a);
            conexao.Close();
            

            Funcoes f = new Funcoes();
            string senha1 = "123456";
            string senha2 = "1234567891113151719";

            Console.WriteLine(f.Criptografa(senha1));
            Console.WriteLine(f.Criptografa(senha2).Length);

            







        }
    }
}
