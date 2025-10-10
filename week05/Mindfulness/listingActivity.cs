using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string item;
        
        Console.Write("> ");
        item = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(item))
        {
            userList.Add(item);
        }

        return userList;
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        string prompt = GetRandomPrompt();
        Console.WriteLine("List answering the next question:");
        Console.WriteLine($"---{prompt}---");
        
        Console.Write("Start to think...");
        ShowCountDown(5); // 5 seconds
        Console.WriteLine("\nStart writing/listing the elements now (write 'end' or press Enter to go to the next one, or wait that the time runs out):");

        Stopwatch timer = new Stopwatch();
        timer.Start();
        
        _count = 0;
        
        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(item) || item.ToLower() == "end")
            {
                continue; 
            }
            
            _count++;
        }
        
        timer.Stop();
        
        Console.WriteLine($"\n¡You have listed {_count} things!");
        DisplayEndingMessage();
    }
}