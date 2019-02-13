using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace ZnamkyLibrary
{
    class SQLHandler
    {
        string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Marks.db");

        public SQLHandler()
        {
            DbCreation();
        }

        public void DbCreation()
        {
            var db = new SQLiteConnection(databasePath);
            db.CreateTable<Mark>();
        }

        public List<Mark> GetMarksFromDb()
        {
            var db = new SQLiteConnection(databasePath);
            var query = db.Table<Mark>();
            List<Mark> results = query.ToList();
            return results;
        }

        public void AddMark(string subject, int value, int weight, string comment)
        {
            var db = new SQLiteConnection(databasePath);
            var mark = new Mark()
            {
                Subject = subject,
                Value = value,
                Weight = weight,
                Comment = comment
            };
            db.Insert(mark);
        }

    }
}
