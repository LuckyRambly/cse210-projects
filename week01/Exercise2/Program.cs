using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project. ");
        Console.WriteLine("What is your score? ");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        string letter ="";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"This is your grade: {letter} ");

        if (score >= 70)
        {
            Console.WriteLine("You passed! ");
        }
        else
        {
            Console.WriteLine("Better luck next time dude! ");
        }
    }
}