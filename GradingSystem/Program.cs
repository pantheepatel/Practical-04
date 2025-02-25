namespace GradingSystem
{
    internal class GradingSystem
    {
        enum Options
        {
            // default assignment so that comparison with choice would be easier
            Aggregate = 1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }
        static void Main(string[] args)
        {
            // creating new object
            Student stu1 = new();

        getInpAgain:
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            // checking if there is no input for name
            if (userName.Length == 0)
            {
                stu1.Name = userName;
                goto getInpAgain;
            }

            decimal[] marksArr = stu1.Marks; // reference of student class's marks array
            int marksLength = marksArr.Length; 
            for (int i = 0; i < marksLength; i++)
            {
                decimal mark;
                do
                {
                getControl:
                    Console.Write($"Marks of sub {i + 1}: ");
                    while (!decimal.TryParse(Console.ReadLine(), out mark)) // assigning parsed decimal value to mark variable if parsing is successful else it will go into loop
                    {
                        Console.WriteLine("Enter correct value");
                        goto getControl;
                    }
                } while (mark < 0 || mark > 100); // user marks between 0 to 100 marks only
                marksArr[i] = mark; // assigning element to specified index
            }

            int choice = 0; // to store user's input of user
            do
            {
                Console.WriteLine("\n\n1 - Aggregate: Displays the Name: Average marks\n" +
                    "2 - MinMark: Displays the minimum marks of the student\n" +
                    "3 - MaximumMark: Displays the maximum mark\n" +
                    "4 - Grade: Displays grade\n" +
                    "0 - Exit");
            getControl:
                while (!int.TryParse(Console.ReadLine(), out choice)) // assigning parsed string value to choice variable if parsing is successful else it will go into loop
                {
                    Console.WriteLine("enter correct choice of integer between 0 to 4");
                    goto getControl;
                }

                Options selectedOption = (Options)choice; // getting value of enum member according to choice of user
                Console.WriteLine($"Your selected choice: {selectedOption}");
                switch (selectedOption) // Comparing the input by the user by enum value
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
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            } while (choice != 0); // loop until user chooses to exit(0)
        }
    }
}