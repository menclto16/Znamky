using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace ZnamkyLibrary
{
    class SQLHandler
    {
        private string dbName = "Marks";
        public SQLHandler()
        {
            DbCreation();
        }
        public void DbCreation()
        {
            var conn = new SQLiteAsyncConnection(dbName);
            conn.CreateTableAsync<Mark>();
        }

        public bool InsertRow(Mark mark)
        {
            var conn = new SQLiteAsyncConnection(dbName);
            conn.InsertAsync(mark).ContinueWith((t) =>
            {
                return true;
            });
            return false;
        }
        
    }
}
