using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int IdCli { get => IdCli; set => IdCli = value; }

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

        //Métodos da Classe

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            Banco.Fechar(cmd);
        }
        
    }
}
