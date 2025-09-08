using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project. ");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("It's higher ");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("It's lower ");
            }
            else
            {
                Console.WriteLine("Congrats! You guessed the number! ");
            }
        }
    }
}