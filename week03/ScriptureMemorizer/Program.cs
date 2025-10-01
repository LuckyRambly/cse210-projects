using System;

class Program
{
    static void Main(string[] args)
    {
        // Proverb or sentence that will be use for the exercise
        Reference proverbsRef = new Reference("Proverbs", 3, 5, 6);
        string proverbsText = "Trust in the LORD with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        
        Scripture scripture = new Scripture(proverbsRef, proverbsText);

        string userInput = "";

        // Quit or enter
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear(); 

            Console.WriteLine(scripture.GetDisplayText()); 
            
            Console.WriteLine("\nPress ENTER to hide 3 words or write 'quit' to finish this session.");
            userInput = Console.ReadLine();
            
            // hiding stuff
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            
            // change number if you want more or less hidden words per enter, remeber to change the .writeline of quit or enter
            scripture.HideRandomWords(3); 
        }

        // final message
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText()); 
        Console.WriteLine("\n Session ended. ¡Thanks!");
    }
}