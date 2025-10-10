using System;
using System.Threading;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("breathing", "This activity will help you to relax using slow breathing exercises. clean your mind and focus in your breathing.")
    {
        // No special stuff here
    }

    public void Run()
    {
        DisplayStartingMessage();

        // timer
        Stopwatch timer = new Stopwatch();
        timer.Start();

        // 4 secs + 6 secs
        while (timer.Elapsed.TotalSeconds < _duration)
        {
            // In
            Console.Write("Inhale... ");
            ShowCountDown(4);
            Console.WriteLine();
            
            // Out
            if (timer.Elapsed.TotalSeconds < _duration)
            {
                Console.Write("Exhile... ");
                ShowCountDown(6);
                Console.WriteLine();
            }
        }
        
        timer.Stop();
        DisplayEndingMessage();
    }
}