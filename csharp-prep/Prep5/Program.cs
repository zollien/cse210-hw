using System;

class Program
{
    static void Main(string[] args)
    {
        // is this main, is this like calling in the main in python where you have to identify each function that is about to be used in the program?
        DisplayWelcome();
        //user inputs
        string name = PromtUserName();
        int favnumber = PromptUserNumber();
        //outputs
        int square = SquareNumber(favnumber);
        DisplayResult(name, square);
    }

    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    /*can use static voice in function name if you want ti to return something AND function names should have empty(), unles asking to compute something*/
    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnumber = int.Parse(Console.ReadLine());
        return favnumber;
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer) - int needed in () to enable return int
    static int SquareNumber(int favnumber)
    {
        int square = favnumber * favnumber;
        return square;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int square)
    {   
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}
