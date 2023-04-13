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
            cmd.Parameters.Add("@pedido", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto", MySqlDbType.Int32).Value = produto_id;
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
        public static List<ItemPedido> ListarPorPedido(int pedido_id)
        {
            ItemPedido item = null;
            List<ItemPedido> itens = new List<ItemPedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido " +
                "where pedido_id = @pedido";
            cmd.Parameters.Add("@pedido", MySqlDbType.Int32).Value = pedido_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item = new ItemPedido();
                item.Id = dr.GetInt32(0);
                item.Produto = Produto.ObterPorId(dr.GetInt32(2));
                item.Preco = dr.GetDouble(3);
                item.Quantidade = dr.GetDouble(4);
                item.Desconto = dr.GetDouble(5);
                itens.Add(item);
            }
            return itens;
        }
        public void Alterar(int pedido_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update itempedido set (quantidade = @quantidade, " +
            "desconto = @desconto)" +
            "values (@quantidade, @desconto)" +
            "where pedido_id = @pedido and produto_id = @produto_id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto_id", MySqlDbType.Int32).Value = Produto.Id;
            cmd.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = Quantidade;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
        }
        public void Excluir(int pedido_id, int produto_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete itempedido where " +
            "pedido_id = @pedido_id and produto_id = @produto_id";                                                                                                                                                                                                                                                                                                                                                            
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto_id", MySqlDbType.Int32).Value = produto_id;
            cmd.ExecuteNonQuery();
        }

    }
}
