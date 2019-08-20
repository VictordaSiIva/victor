using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace BonApptit.Modelos
{
  [Table ("Lanches")]
  public class Lanches
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public double precoTotal { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
     

        [ManyToMany(typeof(LancheAdicional))]
        public List<Adicional> adicional { get; set; }


        [ManyToMany(typeof(LanchesPedido))]
        public List<Pedido> pedidos { get; set; }

    }
}
