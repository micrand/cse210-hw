class Entry 
{
    public string _date;
    public string _promptText;

    public string _entryText;

    public string Display()
    {       
        DateTime theCurrentTime = DateTime.Now;        
        this._date = theCurrentTime.ToShortDateString();

        this._promptText = $"Date: {this._date}  - Prompt: {this._promptText}";
        this._entryText = $"{this._entryText}";

        Console.WriteLine($"Date: {this._date}  - Prompt: {this._promptText}");
        Console.WriteLine($"{this._entryText}");
        return this._promptText + "\n" + this._entryText;

    }
}