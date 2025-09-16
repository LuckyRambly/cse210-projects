public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Question: {Prompt}");
        Console.WriteLine($"Answer : {Response}\n");
    }
}