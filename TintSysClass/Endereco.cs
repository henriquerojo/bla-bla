﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Endereco
    {
        //Atributos
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;
        private string tipo;
        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        //Métodos Construtores
        public Endereco() { }
        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
        }
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
        }

        //Métodos da Classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo)";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@complemento", MySqlDbType.VarChar).Value = Complemento;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = Estado;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            Banco.Fechar(cmd);
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "";
            Banco.Fechar(cmd);
        }
        public void ObterPorId()
        {
            var morrice = Banco.Abrir();
            morrice.CommandText = "";
            Banco.Fechar(morrice);
        }
    }
}
