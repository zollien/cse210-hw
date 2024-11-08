using System;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.WriteLine("What is your percentage grade? ");
        string grade_input = Console.ReadLine();
        int percentage_grade = int.Parse(grade_input);

        string grade = "";

        if (percentage_grade >= 94)
        {
            grade = "A";
        }
        else if (percentage_grade >= 90)
        {
            grade = "A-";
        }
        else if (percentage_grade >= 87)
        {
            grade = "B+";
        }
        else if (percentage_grade >= 84)
        {
            grade = "B";
        }
        else if (percentage_grade >= 80)
        {
            grade = "B-";
        }
        else if (percentage_grade >= 77)
        {
            grade = "C+";
        }
        else if (percentage_grade >= 74)
        {
            grade = "C";
        }
        else if (percentage_grade >= 70)
        {
            grade = "C-";
        }
        else if (percentage_grade >= 60)
        {
            grade = "D";
        }
        else if (percentage_grade < 60)
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}.");
        if (percentage_grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Sign up for tutoring!");
        }
    }
}
