using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace ZnamkyLibrary
{
    class SQLHandler
    {
        public void DatabaseCreation()
        {
            // Get an absolute path to the database file
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Marks.db");

            var db = new SQLiteConnection(databasePath);
            db.CreateTable<Mark>();
        }
        
    }
}
