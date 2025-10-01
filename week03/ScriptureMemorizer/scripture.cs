

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        // Split words into sections
        string[] wordArray = text.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        _words = new List<Word>();

        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var availableWords = _words.Where(w => !w.IsHidden()).ToList();

        if (availableWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (availableWords.Count == 0) break;

            int randomIndex = _random.Next(0, availableWords.Count);
            Word wordToHide = availableWords[randomIndex];
            
            wordToHide.Hide();
            availableWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string referenceString = _reference.GetDisplayText();

        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        
        return $"{referenceString}\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
