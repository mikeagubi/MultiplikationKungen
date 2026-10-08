using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MultiplikationKungen.Models
{
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int Xp { get; set; } = 0;
    }
}
