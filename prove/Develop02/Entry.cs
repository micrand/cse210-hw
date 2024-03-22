class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string _topic;

    public Entry()
    {

    }

    public Entry(string promptText, string entryText, string topic)
    {
        _promptText = promptText;
        _entryText = entryText;
        _topic = topic;
    }

    public string Display()
    {       
        DateTime theCurrentTime = DateTime.Now;        
        _date = theCurrentTime.ToShortDateString();

        string textToShow = $"Date: {_date}  - Prompt: {_promptText}" + "\n";
        textToShow += $"{_entryText} - ({_topic})";

        return textToShow;

    }
    
}