using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ZnamkyLibrary
{
    public class MarkGroup : ObservableCollection<Mark>
    {
        public string SubjectName { get; set; }
        public string SubjectShortName { get; set; }
        public double Average { get; set; }
        public string Heading { get; set; }
    }
}
