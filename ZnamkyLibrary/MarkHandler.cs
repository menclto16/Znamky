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
        public List<Subject> GetSubjects()
        {
            return sqlHandler.GetSubjectsFromDb();
        }
        public bool InsertMark(string subject, int value, int weight, string comment)
        {
            sqlHandler.AddMark(subject, value, weight, comment);
            return true;
        }
        public bool InsertSubject(string name)
        {
            sqlHandler.AddSubject(name);
            return true;
        }
    }
}
