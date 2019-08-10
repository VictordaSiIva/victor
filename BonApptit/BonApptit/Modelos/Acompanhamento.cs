using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BonApptit.Modelos
{
    [Table ("Acompanhamento")]
    public class Acompanhamento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }



    }
}
