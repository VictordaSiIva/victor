using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BonApptit.Modelos
{
    [Table ("Acompanhamento")]
    public class Acompanhamento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }


        [ManyToMany(typeof(AcompanhamentoPedido))]
        public List<Pedido> pedidos { get; set; }







    }
}
