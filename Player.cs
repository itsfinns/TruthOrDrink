using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TruthOrDrink
{

    [SQLite.Table("Player")]
    public class Player
    {
        [PrimaryKey]
        [AutoIncrement]
        [SQLite.Column("id")]
        public int Id { get; set; }
        [SQLite.Column("player")]
        public string PlayerName { get; set; }
    }
}
