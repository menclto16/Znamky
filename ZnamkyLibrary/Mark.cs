using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ZnamkyLibrary
{
    public class Mark
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Subject { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
        public string Comment { get; set; }
    }
}
