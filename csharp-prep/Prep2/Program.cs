using System;
/*using system call the system name space*/
/*"namepaces game" the there is ususally a namesspace which like a package that can be referenced game would be the name of the package */
class Program /*the class program is the shell that contains teh program*/
{
    static void Main(string[] args) /*here we call the main program, static means , void means this program will return nothing, (string[] args says the program can recieve strings which are arguements*/
    {
        /*code that will run is placed in {} inside the main*/
        /*Program code*/
        {
            // This is prep 2
            Console.WriteLine("What is your percentage grade? ");
            string grade_input = Console.ReadLine();
            int percentage_grade = int.Parse(grade_input);
            /*adding int.Parse changes it to an integer*/

            string grade = "";

            if (percentage_grade >= 94 && percentage_grade <= 100)
            {
                grade = "A";
            }
            else if (percentage_grade >= 90 && percentage_grade <= 94)
            {
                grade = "A-";
            }
            else if (percentage_grade >= 87 && percentage_grade <= 90)
            {
                grade = "B+";
            }
            else if (percentage_grade >= 84 && percentage_grade <= 87)
            {
                grade = "B";
            }
            else if (percentage_grade >= 80 && percentage_grade <= 84)
            {
                grade = "B-";
            }
            else if (percentage_grade >= 77 && percentage_grade <= 80)
            {
                grade = "C+";
            }
            else if (percentage_grade >= 74 && percentage_grade <= 77)
            {
                grade = "C";
            }
            else if (percentage_grade >= 70 && percentage_grade <= 74)
            {
                grade = "C-";
            }
            else if (percentage_grade >= 60 && percentage_grade <= 70)
            {
                grade = "D";
            }
            else if (percentage_grade < 60)
            {
                grade = "F";
            }
            else if (percentage_grade > 100)
            {
                grade = "Undefined";
            }

            Console.WriteLine($"Your grade is: {grade}.");
            if ((percentage_grade >= 70) && (percentage_grade <= 100))
            {
                Console.WriteLine("Congratulations, you have passed!");
            }
            else if (percentage_grade >= 100)
            {
                Console.WriteLine("You are mistaken, 100% is the maximum grade!");
            }
            else
            {
                Console.WriteLine("Unfortunately, you did not pass. Sign up for tutoring!");
            }
        }
    }
}