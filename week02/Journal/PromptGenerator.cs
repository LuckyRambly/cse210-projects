public class PromptGenerator
{
    public List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Have you peted your pet today? Do you want a pet?",
            "Have you medidated today?",
            "What made your day better today?",
            "How do you feel from 1 to 10? How can you improve or keep it?",
            "Name 3 things that improves your life",
            "When was the last time did you call a friend?",
            "Whst is your favorite movie?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}