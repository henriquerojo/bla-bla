using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
