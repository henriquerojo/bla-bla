using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{

    public class ItemPedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(Produto produto, double preco, double quantidade, double desconto)
        {
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(int id, Produto produto, double preco, double quantidade, double desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert itempedido (pedido_id, produto_id, preco, quantidade, desconto)" +
            "values (@pedido_id, @produto_id, @preco, @quantidade, @desconto)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.Add("@produto_id", MySqlDbType.Int32).Value = Produto.Id;
        }
        public static ItemPedido BuscarPorProdutoPedido(int pedido_id, int produto_id)
        {
            ItemPedido item = new ItemPedido();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido " +
                "where pedido_id = @pedido and produto_id = @produto";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item.Id = dr.GetInt32(0);
                item.Produto = Produto.ObterPorId(dr.GetInt32(2));
                item.Preco = dr.GetDouble(3);
                item.Quantidade = dr.GetDouble(4);
                item.Desconto = dr.GetDouble(5);
            }
            return item;
        }

    }
}
