using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ZnamkyLibrary
{
    public class MarkHandler
    {
        private SQLHandler sqlHandler = new SQLHandler();
        public List<Mark> Marks = new List<Mark>();

        public List<Mark> GetMarks(string subject = "") {
            return sqlHandler.GetMarksFromDb(subject); 
        }
        public List<Subject> GetSubjects()
        {
            return sqlHandler.GetSubjectsFromDb();
        }
        public ObservableCollection<MarkGroup> GetGroupedMarks()
        {
            ObservableCollection<MarkGroup> groupedMarks = new ObservableCollection<MarkGroup>();

            List<Subject> subjects = new List<Subject>();
            subjects = GetSubjects();

            foreach (var subject in subjects)
            {
                var markGroup = new MarkGroup() { SubjectName = subject.Name, SubjectShortName = subject.Name };
                int markSum = 0;
                int weightSum = 0;
                foreach (var mark in GetMarks(subject.Name))
                {
                    markGroup.Add(mark);
                    markSum += mark.Value * mark.Weight;
                    weightSum += mark.Weight;
                }
                if (weightSum != 0) markGroup.Average = Math.Round((double)markSum / (double)weightSum, 2);

                markGroup.Heading = markGroup.SubjectName + " - " + markGroup.Average;
                groupedMarks.Add(markGroup);
            }

            return groupedMarks;
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
