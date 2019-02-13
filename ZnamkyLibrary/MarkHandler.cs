using System;
using System.Collections.Generic;
using System.Text;

namespace ZnamkyLibrary
{
    public class MarkHandler
    {
        private SQLHandler sqlHandler = new SQLHandler();
        public List<Mark> Marks = new List<Mark>();

        public List<Mark> GetMarks() {
            return sqlHandler.GetMarksFromDb(); 
        }

        public bool InsertMark(string subject, int value, int weight, string comment)
        {
            sqlHandler.AddMark(subject, value, weight, comment);
            return true;
        }
    }
}
