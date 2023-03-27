                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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

        // Métodos da Classe

        public void Inserir()
        {
            var well = Banco.Abrir();
            well.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values (@nome, @cpf, @email, default, 1)";
            well.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            well.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            well.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            well.Parameters.Add("datacad");
        }

    }
}
