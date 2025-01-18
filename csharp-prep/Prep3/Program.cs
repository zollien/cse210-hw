using System;

class Program
{
    static void Main(string[] args)
    {

        //Prep3 Loops

        // call random number generator
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        //Range for random number is 1 to 100 
        Console.WriteLine("Can you guess the magic number? ");
        int guess_input = -1;


        while (guess_input != magic_number)
        {
            //use loop to keep trying
            Console.Write("What is the magic number? ");
            guess_input = int.Parse(Console.ReadLine());

            //if statements
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

        }
        /*
        //number of tries added up

        int tries = 0; //starts at 0 and adds tries on
        string input = Console.ReadLine();
        tries++;
        {
            Console.WriteLine("Your guess took {tries} tries");
            guess_input = int.Parse(Console.ReadLine());
        } */
    }
}
