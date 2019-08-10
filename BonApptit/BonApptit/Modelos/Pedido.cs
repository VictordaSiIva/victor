using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BonApptit.Modelos
{
    [Table ("Pedido")]
    public class Pedido
    {
        public int Id { get; set; }
        public string descricao { get; set; }


    }
}
