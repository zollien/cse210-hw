using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();

        //declare a variable before it is used in a loop
        int number = 1;

        //while loop
        while (number != 0)
        // this loop will evaluate the input number and if it can continue it will or it will stop because the condition in not met to continue
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                //number not equal to 0 (!=0)
                numbers.Add(number);
            }
        }
        //foreach loops will iterate through the list of input numbers
        int sum = 0;  //this is the sum 
        foreach (int item in numbers)
        {
            sum += item; // this will add each new item to the sum
        }
        float average = sum / numbers.Count; //counts items in numbers list

        int largestnumber = int.MinValue; //this sets the minimum value as a very small number 10^-1000000000000000 etc.

        foreach (int item in numbers)
        {
            if (item > largestnumber)
            {
                largestnumber = item;
            }
        }

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {largestnumber}.");


    }
}