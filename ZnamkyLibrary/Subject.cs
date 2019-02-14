using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ZnamkyLibrary
{
    public class Subject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
