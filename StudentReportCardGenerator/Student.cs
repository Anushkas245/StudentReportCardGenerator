using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCardGenerator
{
    public class Student
    {
        public string Name { get; set; }
        public string RollNo { get; set; }
        public int Math { get; set; }
        public int Science { get; set; }
        public int English { get; set; }

        public int Total => Math + Science + English;
        public double Percentage => Total / 3.0;

        public string Grade
        {
            get
            {
                if (Percentage >= 90) return "A+";
                if (Percentage >= 80) return "A";
                if (Percentage >= 70) return "B";
                if (Percentage >= 60) return "C";
                return "F";
            }
        }

        public override string ToString()
        {
            return $"{RollNo} - {Name} ({Grade})";
        }
    }
}
