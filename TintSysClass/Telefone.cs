using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Telefone
    {
        //atributos
        private int id;
        private string tipo;
        private string tel;
        private int cliente_id;

        //propriedades
        public int Id { get => Id; set => Id = value; }
        public string Tipo { get => Tipo; set => Tipo = value; }
        public string Tel { get => Tel; set => Tel = value; }
        public int Cliente_id { get => Cliente_id; set => Cliente_id = value; }

        //métodos construtores
        public Telefone() { }

        public Telefone(int id, string tipo, string tel, int cliente_id)
        {
            Id = id;
            Tipo = tipo;
            Tel = tel;
            Cliente_id = cliente_id;
        }

        public Telefone(int id, string tipo, string tel)
        {
            Id = id;
            Tipo = tipo;
            Tel = tel;
        }

        public Telefone (string tipo, string tel, int cliente_id)
        {
            Tipo = tipo;
            Tel = tel;
            Cliente_id = cliente_id;
        }
        public Telefone(string tipo, string tel)
        {
            Tipo = tipo;
            Tel = tel;
        }
        //métodos da classe

    }
}
