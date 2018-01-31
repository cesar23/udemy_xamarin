using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLite.Model
{
    public class Post
    {
        [PrimaryKey,AuotIncrement]
        public int Id { get; set; }
        public string Experience { get; set; }
    }
}
