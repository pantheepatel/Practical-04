namespace GradingSystem
{
    class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        static decimal AverageMarks;
        // to calculate average
        public decimal CalculateAverageMarks() {
            AverageMarks = Marks.Average();
            return AverageMarks; 
        }
        // to find minimum marks from array
        public decimal MinMarks()
        {
            return Marks.Min();
        }
        // to find maximum marks from array
        public decimal MaxMarks()
        {
            return Marks.Max();
        }
        // to calculate grade from marks(argument - average)
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
