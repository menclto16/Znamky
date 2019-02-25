using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ZnamkyLibrary
{
    public class Subject
    {
        [PrimaryKey]
        public string Name { get; set; }
    }
}
