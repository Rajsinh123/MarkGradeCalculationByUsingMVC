using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarkGradeCalculation.Models
{
    public class StudentMark
    {
        public string StudentName { get; set; }
        public int Math { get; set; }
        public int Science { get; set; }
        public int English { get; set; }

        public int History { get; set; }
        public int Total { get; set; }

        public int Percentage { get; set; }
        public string Grade { get; set; }
        



    }
}