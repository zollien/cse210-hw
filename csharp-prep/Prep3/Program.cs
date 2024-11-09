using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

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

//Working to this point, lines 1-35 all ok.


//This is an attempte as adding the stretch code

/*
using System;

namespace MyApplication
{
class Program
{
static void Main(string[] args)
{
  Console.Write("Hello World! ");
  Console.Write("I will print on the same line.");
}
}
}

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

string foo = Console.ReadLine();
string[] guesses = foo.Split(",");
List<int> guess_input = new List<int>();
int oneNum;
foreach (string guess in guesses)
{
    if (Int32.TryParse(guesses, out oneNum))
        guess_input.Add(oneNum);
    {
        Console.WriteLine(guess_input.Count);
    }
}
}
*/
/*const int _max = 100;
var guess_total = Stopwatch.StartNew();
for (int guess_input = 0; guess_input < _max; guess_input++)
{
    var list = new List<int>();
    list.AddRange(array);
    if (list.Count != 100)
    {
        return;
        {
            Console.WriteLine($" You guess the magic number on after {outputs} tries";
        }
    }
}
*/
/*
List<int> guess_input = new List<int>();
{
    Console.WriteLine(guess_input.Count);
}

while count_inputs = Console.ReadLine() != "") ;
if

quess_input++;
{
    Console.WriteLine("You made {guess_input} guesses!");
}
int outputs = guess_input.Count();
{
    Console.WriteLine($" You guess the magic number on after {outputs} tries");
}
 */
