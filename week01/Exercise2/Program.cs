using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.Write("Please enter your grade as a percentage in numbers: ");
        string valueFromUser = Console.ReadLine();
        /*variable is valueFromUser in camelCase*/
        /*this will return the number entered as a string*/

        int percentage_grade = int.Parse(valueFromUser);
        /*this tells the program that the input string is actually a number=percentage_grade*/

        string grade = "";
        /*this tells the program that the grade that is output will be a string ie grade=A */


        /*conditional statements with if, else if and else statements*/
        /*if (percentage_grade == 100) {
            Console.WriteLine("Grade: A. Congrautlations you got 100%");
            This is unneccessary */

        if (percentage_grade == 100)
        {
            grade = "A";
        }

        /* if (percentage_grade < 100 && >= 90)
        this will not work because I did not declare which variable is being assessed as >= 90*/
        if (percentage_grade < 100 && percentage_grade >= 93)
        {
            /*
            Console.WriteLine("Grade: A");
            tried to write the grade output here but it does not work because i have not used the grade variable here */
            grade = "A";
            /*this needs "" because it is a string*/
        }

        else if (percentage_grade < 93 && percentage_grade >= 90)
        {
            grade = "A-";
        }        
        else if (percentage_grade < 90 && percentage_grade >= 87)
        {
            grade = "B+";
        }
        else if (percentage_grade < 87 && percentage_grade >= 83)
        {
            grade = "B";
        }
        else if (percentage_grade < 83 && percentage_grade >= 80)
        {
            grade = "B-";
        }
        else if (percentage_grade < 80 && percentage_grade >=77)
        {
            grade = "C+";
        }
        else if (percentage_grade < 77 && percentage_grade >= 73)
        {
            grade = "C";
        }
        else if (percentage_grade < 73 && percentage_grade >= 70)
        {
            grade = "C-";
        }

        else if (percentage_grade < 70 && percentage_grade >= 0)
        {
            grade = "F - this is a failing grade.";
        }
        else if (percentage_grade > 100 || percentage_grade <= 0)
        /* This rules out all the numbers outside 0-100*/
        {
            grade = "invalid entry, please enter 0-100";
        }
        Console.WriteLine($"Your grade is {grade}.");

        /* this code works but i dont know what to do about decimals if entered, as it will not run */
    }
}