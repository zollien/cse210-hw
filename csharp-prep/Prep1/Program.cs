using System;
/*using system call the system name space*/
/*"namepaces game" the there is ususally a namesspace which like a package that can be referenced game would be the name of the package */
class Program /*the class program is the shell that contains teh program*/
{
    static void Main(string[] args) /*here we call the main program, static means , void means this program will return nothing, (string[] args says the program can recieve strings which are arguements*/
    {
        /*code that will run is placed in {} inside the main*/
        Console.WriteLine("This is Zollien Dove's C# Code.");

        /*Program code*/
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}. ");
    }
}