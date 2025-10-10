using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Think about the next question:");
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine("When have yoy think about it, press enter.");
        Console.ReadLine();
    }

    public void DisplayQuestions(Stopwatch timer)
    {
        Console.WriteLine("Now think about every of that questions related to that experience.");
        
        while (timer.Elapsed.TotalSeconds < _duration)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            
            ShowSpinner(7); 
            Console.WriteLine();
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        DisplayPrompt();
        
        Console.WriteLine("Get ready for the next question...");
        ShowSpinner(5);

        Stopwatch timer = new Stopwatch();
        timer.Start();

        DisplayQuestions(timer);

        timer.Stop();
        DisplayEndingMessage();
    }
}