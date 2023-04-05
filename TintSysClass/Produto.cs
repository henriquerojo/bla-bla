using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Produto
    {

        // atributos
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string CodBar { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }

        // propriedades

        // métodos construtores
        public Produto() { }

        public Produto(int id, string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto)
        {

            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;

        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert produtos (descricao, unidade, codbar, preco, desconto, descontinuado) values (@descricao, @unidade, @codbar, @preco, @desconto, 0);"
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@unidade", MySqlDbType.VarChar).Value = Unidade;
            cmd.Parameters.Add("@codbar", MySqlDbType.VarChar).Value = CodBar;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = Preco;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public List<Produto> Listar(string descricao = "") 
        {
            List<Produto> lista = new List<Produto>();
            //busca
            return new List<Produto>();
        }

        public static Produto ObterPoriD(int id)
        {
            Produto produto = new Produto();
            // busca
            return produto;
        }
        public void Atualizar()
        {
            
        }
        public void Arquivar()
        {

        }
        public void Restaurar()
        {

        }
    }
}
