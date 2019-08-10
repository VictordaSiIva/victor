﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BonApptit.Modelos
{
  [Table ("Lanches")]
  public class Lanches
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }

    }
}
