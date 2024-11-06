using System;

class Program
{
    static void Main(string[] args)
    {
        //comment: code in body, strings are named, print function similar to python.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}