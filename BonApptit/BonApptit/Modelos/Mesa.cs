using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BonApptit.Modelos
{
    [Table ("Mesa")]
    public class Mesa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }

 

    }
}
