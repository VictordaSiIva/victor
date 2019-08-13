using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace BonApptit.Modelos
{
  [Table ("Adicional")]
  public class Adicional
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
      

        [ManyToMany(typeof(LancheAdicional))]
        public List<Lanches> lanches { get; set; }

    }
}
