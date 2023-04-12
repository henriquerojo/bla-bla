using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace TintSysClass
{
    public class Pedido
    {
        // atributos
        private int id;
        private DateTime data;
        private string status;
        private Decimal desconto;
        private Cliente cliente;
        private Usuario usuario;
        private DateTime arquivado;
        private string hashcode;

        // propriedades
        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Status { get => status; set => status = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public DateTime Arquivado { get => arquivado; set => arquivado = value; }
        public string Hashcode { get => hashcode; set => hashcode = value; }
        // métodos construtores
        public Pedido() { }
        public Pedido(int id, DateTime data, string status, decimal desconto, Cliente cliente, Usuario usuario, DateTime arquivado, string hashcode)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Arquivado = arquivado;
            Hashcode = hashcode;
        }
        public Pedido(Cliente cliente, Usuario usuario)
        {
            Cliente = cliente;
            Usuario = usuario;
        }
        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (data, status, desconto, cliente_id, usuario_id, hashcode)" +
                "values (default, default, 0, @cliente, @usuario, @hash)";
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.Parameters.Add("@usuario", MySqlDbType.Int32).Value = Usuario.Id;
            cmd.Parameters.Add("@hash", MySqlDbType.VarChar).Value= ObterHashCode(Cliente.Id, Usuario.Id);

            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";

            Id = Convert.ToInt32(cmd.ExecuteScalar());

            Banco.Fechar(cmd);
        }
        public void ObterPorId(int id)
        {

        }
        public void ObterPorCliente()
        { 

        }
        public void Listar()
        { 
        
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
        public void Excluir()
        {

        }
        private string ObterHashCode(int cli, int user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("PD-");
            Random rd = new Random();
            sb.Append(rd.Next(123450, 543210));
            sb.Append("-");
            sb.Append(cli);
            sb.Append("-");
            sb.Append(user);
            sb.Append(GetHashCode());
            return sb.ToString();
            //return "PD-"+cli+""+user+""+GetHashCode();
        }
    }
}
