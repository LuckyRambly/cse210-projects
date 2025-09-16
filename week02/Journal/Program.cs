class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator myPromptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("\nWelcome to non-dream diary V2");

        while (running)
        {
            Console.WriteLine("\nPlease, select an option:");
            Console.WriteLine("1 - Write a new entry");
            Console.WriteLine("2 - Show all previous entries");
            Console.WriteLine("3 - Save the diary");
            Console.WriteLine("4 - Load a new diary");
            Console.WriteLine("5 - Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    myJournal.AddEntry(myPromptGenerator);
                    break;

                case "2":

                    myJournal.DisplayJournal();
                    break;

                case "3":

                    Console.Write("Write a name for this savefile, like: diary, journal. catlog, etc. ");
                    string saveFilename = Console.ReadLine();
                    Console.WriteLine("What format do you prefer?");
                    Console.WriteLine("1 - Text file (.txt)");
                    Console.WriteLine("2 - Excel CSV (.csv)");
                    Console.Write("Select an option, please: ");
                    string saveFormat = Console.ReadLine();
                    
                    if (saveFormat == "1")
                    {
                        if (!saveFilename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                        {
                            saveFilename += ".txt";
                        }
                        myJournal.SaveToFile(saveFilename);
                    }
                    else if (saveFormat == "2")
                    {
                        if (!saveFilename.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                        {
                            saveFilename += ".csv";
                        }
                        myJournal.SaveToCsv(saveFilename);
                    }
                    else
                    {
                        Console.WriteLine("No valid option, please use a number for select your format. / error in line 62.");
                    }
                    break;

                case "4":

                    Console.Write("Insert the name of your savefile, like: diary, including the format like .txt or .csv ");
                    string loadFilename = Console.ReadLine();
                    if (loadFilename.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        myJournal.LoadFromCsv(loadFilename, myPromptGenerator);
                    }
                    else
                    {
                        myJournal.LoadFromFile(loadFilename, myPromptGenerator);
                    }
                    break;

                case "5":

                    running = false;
                    break;
                default:
                    Console.WriteLine("No valid option, please use a number from 1 to 5.");
                    break;
            }
        }
        Console.WriteLine("Thanks, see you the net time!");
    }
}

//The program works as intended and has the option to save files in .csv format for exceed the requirements, I think I could abstract more parts of the program but I think its fine like this.