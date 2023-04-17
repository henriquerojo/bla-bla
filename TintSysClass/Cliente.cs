                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Cliente
    {
        // Atributos

        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime datacad;
        private List<Endereco> enderecos;
        private List<Telefone> telefones;
        private bool ativo;

        // Propriedade (Encapsulamento)

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value;}
        public DateTime Datacad { get => datacad; set => datacad = value; }
        public List<Endereco> Enderecos  { get => enderecos; set => enderecos = value; }
        public List<Telefone> Telefones { get => telefones; set => telefones = value; }
        public bool Ativo { get => ativo; set => ativo = value;}

        // Métodos Construtores

        public Cliente() { }

        public Cliente(int id, string nome, string cpf, string email, DateTime datacad, List<Endereco> enderecos, List<Telefone> telefones, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Enderecos  = enderecos;
            Telefones = telefones;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, DateTime datacad, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public Cliente(int id, string nome, string cpf, string email, DateTime datacad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, DateTime datacad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad= datacad;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, DateTime datacad)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
        }

        public Cliente(string nome, string cpf, string email)
        { 
            Nome = nome;
            Cpf = cpf; 
            Email = email;
        }
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Email = email;  
        }
        // Métodos da Classe

        public void Inserir()
        {
            var well = Banco.Abrir();
            well.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values (@nome, @cpf, @email, default, default)";
            well.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            well.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            well.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            well.Parameters.Add("datacad", MySqlDbType.DateTime).Value = datacad;
            well.ExecuteNonQuery();

            well.CommandText = "select @@identity";
            Id = Convert.ToInt32(well.ExecuteScalar());

            Banco.Fechar(well);
        }
       
        public void Atualizar()
        {
            var vitu = Banco.Abrir();
            vitu.CommandText = "update clientes set nome = @nome, cpf = @cpf, email = @email, datacad = default, ativo = 1 where id = @id";
            vitu.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            vitu.Parameters.Add("@cpf", MySqlDbType.VarChar).Value= Cpf;
            vitu.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            vitu.Parameters.Add("@datacad");
            vitu.ExecuteNonQuery ();

            vitu.CommandText = "select @@identity";
            Id = Convert.ToInt32(vitu.ExecuteScalar());

            Banco.Fechar(vitu);
        }

        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from clientes where id = " + id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update cliente set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from clientes where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDateTime(4),
                dr.GetBoolean(5)
                //Endereco.ListarPorCliente
                //Telefone.ListarPorCliente
                );
            }
            Banco.Fechar(cmd);
            return cliente;
        }
        public static List<Cliente> Listar(string nome = "")
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            if (nome != string.Empty)
            {
                cmd.CommandText = "select * from clientes where nome like '%" + nome + "%'";
            }
            else
            {
                cmd.CommandText = "select * from clientes";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }
    }
}
