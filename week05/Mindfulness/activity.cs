using System;
using System.Threading;
using System.Diagnostics;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0; 
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"¡Welcome to {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        
        // set a timer
        Console.Write("For how much seconds you would like to do this activity? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("No valid answer. we'll use 30 seconds.");
            _duration = 30;
        }

        Console.Clear();
        Console.Write("get ready...");
        ShowSpinner(5); // 5 seconds lapse
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3); // spinner 3 secs
        Console.WriteLine();
        Console.WriteLine($"you completed {_name} for {_duration} seconds.");
        ShowSpinner(5); 
    }

    // spin animation
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b");

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            
            string spaces = new string(' ', i.ToString().Length);
            Console.Write($"\b{spaces}\b"); 
        }
    }
}