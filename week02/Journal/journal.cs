public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(PromptGenerator promptGenerator)
    {
        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\n{randomPrompt}");
        Console.Write("Your answer: ");
        string userResponse = Console.ReadLine();
        Entries.Add(new Entry(randomPrompt, userResponse));
        Console.WriteLine("Succesfully saved!.");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\n----- Your diary! -----");
        if (Entries.Count == 0)
        {
            Console.WriteLine("This place is empty... for now.");
        }
        else
        {
            foreach (var entry in Entries)
            {
                entry.DisplayEntry();
            }
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine($"Diary saved as '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"There was an error while saving: {ex.Message}, try again or use another name.");
        }
    }

    public void LoadFromFile(string filename, PromptGenerator promptGenerator)
    {
        Entries.Clear();
        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
                    }
                }
                Console.WriteLine($"Loaded diary from: '{filename}'.");
            }
            else
            {
                Console.WriteLine("That file does not exist... (Or we can not find it)");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading: {ex.Message}");
        }
    }
    
    public void SaveToCsv(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Response");
                foreach (var entry in Entries)
                {
                    string date = EscapeCsv(entry.Date);
                    string prompt = EscapeCsv(entry.Prompt);
                    string response = EscapeCsv(entry.Response);
                    writer.WriteLine($"{date},{prompt},{response}");
                }
            }
            Console.WriteLine($"Diary saved as .CSV: '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving as .CSV: {ex.Message}");
        }
    }

    public void LoadFromCsv(string filename, PromptGenerator promptGenerator)
    {
        Entries.Clear();
        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                if (lines.Length > 1) 
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        var parts = ParseCsvLine(line);
                        if (parts.Count == 3)
                        {
                            Entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
                        }
                    }
                }
                Console.WriteLine($"Diary loaded from: '{filename}'.");
            }
            else
            {
                Console.WriteLine("The file does not exist.. or is lost anywhere else.....");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from .CSV: {ex.Message}");
        }
    }

    //, and . stuff
    private string EscapeCsv(string value)
    {
        if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }
        return value;
    }
    
    // CSV stuff to keep the program working and do not explode 
    private List<string> ParseCsvLine(string line)
    {
        var parts = new List<string>();
        int start = 0;
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (line[i] == ',' && !inQuotes)
            {
                parts.Add(line.Substring(start, i - start).Trim('\"').Replace("\"\"", "\""));
                start = i + 1;
            }
        }
        parts.Add(line.Substring(start).Trim('\"').Replace("\"\"", "\""));
        return parts;
    }
}