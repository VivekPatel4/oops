using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Student Performance Analyzer =====");
        while (true)
        {
            Console.Write("Enter the number of subjects: ");
            int subjectCount = int.Parse(Console.ReadLine());

            int[] marks = new int[subjectCount];
            int total = 0;

            
            for (int i = 0; i < subjectCount; i++)
            {
                Console.Write($"Enter marks for Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }

            double average = (double)total / subjectCount;
            Console.WriteLine($"\nTotal Marks: {total}");
            Console.WriteLine($"Average Marks: {average:F2}");

            
            string grade;
            if (average >= 90) grade = "A+";
            else if (average >= 80) grade = "A";
            else if (average >= 70) grade = "B";
            else if (average >= 60) grade = "C";
            else if (average >= 50) grade = "D";
            else grade = "F";

            Console.WriteLine($"Grade: {grade}");

            string performance;
            switch (grade)
            {
                case "A+":
                case "A":
                    performance = "very Good!";
                    break;
                case "B":
                    performance = "Good!";
                    break;
                case "C":
                    performance = "Average!";
                    break;
                case "D":
                    performance = "Below Average!";
                    break;
                default:
                    performance = "Fail!";
                    break;
            }

            Console.WriteLine($"Performance: {performance}");

            Console.Write("\nDo you want to analyze another student? (yes/no): ");
            string choice = Console.ReadLine().ToLower();

            if (choice != "yes")
            {
                Console.WriteLine("Exiting Program. Thank you!");
                break;
            }
        }
    }
}
