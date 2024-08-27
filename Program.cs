using System;

/*
This program helps you keep track of how many Sodas, Chips, and Candy bars you have left in your store.
First, it asks you how many of each item you sold today.
Then, it tells you how many are left and if you need to get more.
How it works:
 1. The program starts with a certain number of each item in stock.
 2. You tell the program how many were sold.
 3. It checks how many are left and lets you know if it's time to restock.
*/
class Program
{
    static void Main()
    {
        int sodaRemaining = 100;
        int sodaThreshold = 40;

        int chipsRemaining = 40;
        int chipsThreshold = 20;

        int candyRemaining = 60;
        int candyThreshold = 40;

        // Process soda sales
        Console.WriteLine("Welcome to the restocking tool.");
        Console.WriteLine($"How many Sodas have been sold today? 100 are in stock");
        if (int.TryParse(Console.ReadLine(), out int sodaSold))
        {
            if (sodaSold > sodaRemaining)
            {
                Console.WriteLine("That number is too high. Stock not updated.");
            }
            else
            {
                sodaRemaining -= sodaSold;
                Console.WriteLine($"There are {sodaRemaining} Sodas left.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Stock not updated.");
        }

        // Begin chips sales
        Console.WriteLine($"How many Chips have been sold today? 40 are in stock");
        if (int.TryParse(Console.ReadLine(), out int chipsSold))
        {
            if (chipsSold > chipsRemaining)
            {
                Console.WriteLine("That number is too high. Stock not updated.");
            }
            else
            {
                chipsRemaining -= chipsSold;
                Console.WriteLine($"There are {chipsRemaining} Chips left.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Stock not updated.");
        }

        // Begin candy sales
        Console.WriteLine($"How many Candy have been sold today? 60 are in stock");
        if (int.TryParse(Console.ReadLine(), out int candySold))
        {
            if (candySold > candyRemaining)
            {
                Console.WriteLine("That number is too high. Stock not updated.");
            }
            else
            {
                candyRemaining -= candySold;
                Console.WriteLine($"There are {candyRemaining} Candy left.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Stock not updated.");
        }

        // Restock check
        Console.WriteLine("\nThank you for filling out the values. Here’s what needs to be restocked.");
        if (sodaRemaining <= sodaThreshold)
        {
            Console.WriteLine("Sodas need to be restocked.");
        }
        if (chipsRemaining <= chipsThreshold)
        {
            Console.WriteLine("Chips need to be restocked.");
        }
        if (candyRemaining <= candyThreshold)
        {
            Console.WriteLine("Candy needs to be restocked.");
        }

        Console.WriteLine("\nGoodbye!");
    }
}
