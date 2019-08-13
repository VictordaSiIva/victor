using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BonApptit.Modelos
{
    [Table ("Sobremesa")]
    public class Sobremesa
    {
        [PrimaryKey, AutoIncrement]
        public int iD { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }

        [ManyToMany(typeof(SobremesaPedido))]
        public List<Pedido> pedidos { get; set; }

    }
}
