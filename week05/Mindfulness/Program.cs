using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the mindfulness app!");
            Console.WriteLine("Select one of this options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Exit");
            Console.Write("Your pick: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("\nThanks for using the app!");
                    break;
                default:
                    Console.WriteLine("Invalid answer. press enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}