using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project. ");

        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello and welcome! ");
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please input a number please!: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name} , the quare of your number is {square}! ");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please type your name, please!: ");
        string name = Console.ReadLine();

        return name;
    }
}