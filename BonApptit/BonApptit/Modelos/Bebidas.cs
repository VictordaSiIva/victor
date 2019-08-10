using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BonApptit.Modelos
{
  [Table("Bebidas")]
   public  class Bebidas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public string tamanho { get; set; }
        public int categoria { get; set; }

    }
}
