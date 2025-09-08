using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("And now, what is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}