using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Nivel // Abstração
    {
        // atributos
        // private (-)
        // protected (#)
        // public (+)

        private int id = 0;
        private string nome = "";
        private string sigla = string.Empty;

        // propriedades (encapsulamento)
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set {  nome = value; } 
        }
        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }
        
        // metodos construtores - Int x = new Int ();
        public Nivel() { } // vazio
        public Nivel(string _nome, string _sigla)
        {
            Nome = _nome;
            Sigla = _sigla;
        }
        public Nivel(int _id, string _nome, string _sigla)
        {
            Id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }


        // metodos da classe (inserir, alterar, consultar, por id)

        public void Inserir()
        {
            // cria uma variável com conexão de banco aberta
            var cmd = Banco.Abrir();
            // define o tipo de instrução sql a ser processada pelo servidor de banco de dados
            cmd.CommandType = CommandType.Text;
            // define a query sql especificada com parâmetros (@nome)
            cmd.CommandText = "insert niveis (nome, sigla) values (@nome, @sigla)";
            // cria o parametro e define o valor
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("@sigla", Sigla);
            // executa a instrução SQL na conexão aberta
            cmd.ExecuteNonQuery();
            // obtendo o id do nivel recem inserido
            cmd.CommandText = "select @@identity";
            // recupera o id na Propriedade
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexão
            Banco.Fechar(cmd);
                  
        }
        public static Nivel ObterPorId(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where id = @id";
            cmd.Parameters.AddWithValue("@id", _id);
            var dr = cmd.ExecuteReader();
            Nivel nivel = null;
            while (dr.Read())
            {
                nivel = new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            Banco.Fechar(cmd);
            return nivel;
        }
        public static List<Nivel> Listar()
        { 
            List<Nivel> lista = new List<Nivel>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = @nome, sigla = @sigla where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@sigla", Sigla);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public bool Excluir()
        {
            bool confirma = false;
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from niveis where id = " + id;
            if (cmd.ExecuteNonQuery() > 0)
            {
                confirma = true;
            }
            Banco.Fechar(cmd);
            return confirma;
        }
    }
}
