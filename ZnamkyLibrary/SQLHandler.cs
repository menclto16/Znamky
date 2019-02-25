using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace ZnamkyLibrary
{
    class SQLHandler
    {
        private string marksDatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Marks.db");

        public SQLHandler()
        {
            DbCreation();
        }
        public void DbCreation()
        {
            var db = new SQLiteConnection(marksDatabasePath);
            db.CreateTable<Mark>();
            db.CreateTable<Subject>();
        }
        public List<Mark> GetMarksFromDb(string subject = "")
        {
            var db = new SQLiteConnection(marksDatabasePath);
            if (subject != "")
            {
                var query = db.Table<Mark>().Where(v => v.Subject.Contains(subject));
                List<Mark> results = query.ToList();
                return results;
            }
            else
            {
                var query = db.Table<Mark>();
                List<Mark> results = query.ToList();
                return results;
            }
        }
        public List<Subject> GetSubjectsFromDb()
        {
            var db = new SQLiteConnection(marksDatabasePath);
            var query = db.Table<Subject>();
            List<Subject> results = query.ToList();
            return results;
        }
        public void AddMark(string subject, int value, int weight, string comment)
        {
            var db = new SQLiteConnection(marksDatabasePath);
            var mark = new Mark()
            {
                Subject = subject,
                Value = value,
                Weight = weight,
                Comment = comment
            };
            db.Insert(mark);
        }
        public void AddSubject(string name)
        {
            var db = new SQLiteConnection(marksDatabasePath);
            var subject = new Subject()
            {
                Name = name
            };
            try
            {
                db.Insert(subject);
            }
            catch (Exception)
            {
            }
        }
    }
}
