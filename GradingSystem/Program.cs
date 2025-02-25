using System.Diagnostics;

namespace GradingSystem
{
    internal class GradingSystem
    {
        enum Options
        {
            Aggregate = 1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }
        static void Main(string[] args)
        {

            Student stu1 = new();

            Console.Write("Enter your name: ");
            string userName = Convert.ToString(Console.ReadLine());
            stu1.Name = userName;

            decimal[] marksArr = stu1.Marks;
            int marksLength = marksArr.Length;
            for (int i = 0; i < marksLength; i++)
            {
                decimal mark;
                do
                {
                getControl:
                    Console.Write($"Marks of sub {i + 1}: ");
                    while (!decimal.TryParse(Console.ReadLine(), out mark))
                    {
                        Console.WriteLine("enter correct value");
                        goto getControl;
                    }
                } while (mark < 0 || mark > 100);
                marksArr[i] = mark;
            }

            int choice = 0;
            do
            {
                Console.WriteLine("\n\n1 - Aggregate: Displays the Name: Average marks\n" +
                    "2 - MinMark: Displays the minimum marks of the student\n" +
                    "3 - MaximumMark: Displays the maximum mark\n" +
                    "4 - Grade: Displays grade\n" +
                    "0 - Exit");
            getControl:
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
                {
                    Console.WriteLine("enter correct choice of integer between 0 to 4");
                    goto getControl;
                }

                Options selectedOption = (Options)choice;
                Console.WriteLine($"Your selected choice: {selectedOption}");
                switch (selectedOption)
                {
                    case Options.Aggregate:
                        Console.WriteLine($"Name: {stu1.Name}, Average Marks: {stu1.CalculateAverageMarks()}");
                        break;
                    case Options.MinMark:
                        Console.WriteLine($"Your minimum marks are: {stu1.MinMarks()}");
                        break;
                    case Options.MaximumMark:
                        Console.WriteLine($"Your maximum marks are: {stu1.MaxMarks()}");
                        break;
                    case Options.Grade:
                        Console.WriteLine($"Your Grade is: {stu1.CalculateGrade(stu1.CalculateAverageMarks())}");
                        break;
                    default:
                        break;
                }

            } while (choice != 0);
        }
    }
}