using System;
using System.ComponentModel.DataAnnotations;

class Program
//class4 to write last - Unstarted

{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine($"Menu\n "
            + "1 write \n"
            + "2 display\n"
            + "3 save \n"
            + "4 load \n"
            + "5 quit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the file name");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter the file name");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == 5)
            {
                break; //quits
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}