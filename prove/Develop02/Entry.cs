class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {

    }

    public Entry(string promptText, string entryText)
    {
        _promptText = promptText;
        _entryText = entryText;
    }

    public string Display()
    {       
        DateTime theCurrentTime = DateTime.Now;        
        _date = theCurrentTime.ToShortDateString();

        _promptText = $"Date: {_date}  - Prompt: {_promptText}";
        _entryText = $"{_entryText}";

        // Console.WriteLine($"{_promptText}");
        // Console.WriteLine($"{_entryText}");
        return _promptText + "\n" + _entryText;

    }
    
}