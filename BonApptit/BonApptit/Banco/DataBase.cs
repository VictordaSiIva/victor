using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BonApptit.Modelos;
using Xamarin.Forms;
namespace BonApptit.Banco
{
    public class DataBase
    {
        private SQLiteConnection _conexao;
        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
        }
    }
}
