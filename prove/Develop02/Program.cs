using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine($"This is your journal. ");

        while (true)
        {
            Console.WriteLine($"Menu:  \n"
            + "1. Write \n"
            + "2. Display \n"
            + "3. Load \n"
            + "4. Save \n"
            + "5. Quit \n");

            Console.Write("Please enter a number from the menu above: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) //option 1 write new entry
            {
                journal.AddEntry();
            }
            else if (choice == 2) //option 2 diplay entries
            {
                journal.DisplayAll();
            }
            else if (choice == 3) //option 3 load journal from file
            {
                Console.WriteLine("Load your journal. Enter the file name");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == 4) //option 4 save journal entry to file
            {
                Console.WriteLine("Where should this journal save? Enter the file name");
                string file = Console.ReadLine();
                journal.SaveToFile(journal._entries, file); //this accesses the journal variable _entries

            }
            else if (choice == 5) //option 5 quits the journal program
            {
                break;
            }
            else //option 6 invalid entry runs nothing, gives prompt to try again
            {
                Console.WriteLine("Invalid Input: please select from the menu");
            }
        }
    }
}
