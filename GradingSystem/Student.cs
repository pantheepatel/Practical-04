using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        static decimal AverageMarks;

        public decimal CalculateAverageMarks() {
            AverageMarks = Marks.Average();
            return AverageMarks; 
        }
        public decimal MinMarks()
        {
            return Marks.Min();
        }
        public decimal MaxMarks()
        {
            return Marks.Max();
        }
        public string CalculateGrade(decimal marks)
        {
            int marksInt = (int)marks;
            string remark = "none";
            switch (marksInt)
            {
                case > 90:
                    remark = "grade A";
                    break;
                case > 80:
                    remark = "grade B";
                    break;
                case > 70:
                    remark = "grade C";
                    break;
                case < 70:
                    remark = "grade D";
                    break;
                default:
                    remark = "no remark";
                    break;
            }
            return remark;
        }
    }
}
