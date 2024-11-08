using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Prep3 Loops

        // call random number generator
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        //Range for random number 1 to 11 if (1, 11)
        Console.WriteLine("Can you guess the magic number? ");

        int guess_input = -1;

        while (guess_input != magic_number)
        {
            //use
            Console.Write("What is the magic number? ");
            guess_input = int.Parse(Console.ReadLine());

            if (guess_input > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess_input < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess_input == magic_number)
            {
                Console.WriteLine("You guessed it!");
            }
            // break; can it be used here to stop the loop?

        }
    }