using System;

class Program
{
    static void Main(string[] args)
    {
        static void Welcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static void Name(string name)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
        }

        static void SquareNumber(int favnumber)
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favnumber = Console.ReadLine();

            int square = Math.Sqrt(favnumber);
        }

        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}