using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Assignment test---");
            Assignment generalAssignment = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(generalAssignment.GetSummary()); 
            Console.WriteLine("\n" + new string('-', 20) + "\n");
            Console.WriteLine("---Math Assignment test---");
            MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            
            string mathSummary = math.GetSummary();
            string homeworkList = math.GetHomeworkList(); 
            
            Console.WriteLine(mathSummary);
            Console.WriteLine(homeworkList);
            Console.WriteLine("\n" + new string('-', 20) + "\n");

            Console.WriteLine("---Writing Assignment test---");
            WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

            string writingSummary = writing.GetSummary();
            string writingInfo = writing.GetWritingInformation();

            Console.WriteLine(writingSummary);
            Console.WriteLine(writingInfo);
        }
    }
}