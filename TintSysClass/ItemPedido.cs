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
            ItemPedido iten = new ItemPedido();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido where pedido_id = " + pedido_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                iten.Id = dr.GetInt32(0);
                iten.Produto = Produto.ObterPorId(dr.GetInt32(2));
                iten.Preco = dr.GetDouble(3);
                iten.Quantidade = dr.GetDouble(4);
                iten.Desconto = dr.GetDouble(5);
            }
            return iten;
        }

    }
}
