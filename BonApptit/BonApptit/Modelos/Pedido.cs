using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace BonApptit.Modelos
{
    [Table ("Pedido")]
    public class Pedido
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }

        [ForeignKey(typeof(Mesa))]
        public int MesaID { get; set; }

        [ManyToMany(typeof(LanchesPedido))]
        public List<Lanches> lanches { get; set; }

        [ManyToMany(typeof(AcompanhamentoPedido))]
        public List<Acompanhamento> acompanhamentos { get; set; }

        [ManyToMany(typeof(SobremesaPedido))]
        public List<Sobremesa> sobremesas { get; set; }

        [ManyToMany(typeof(BebidaPedido))]
        public List<Sobremesa> bebidas { get; set; }



    }
}
