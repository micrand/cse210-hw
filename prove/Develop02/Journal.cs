class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry NewEntry)
    {        
        _entries.Add(NewEntry);        
    }

    public void Display()
    {
        Entry entry = new Entry();
        entry.Display(); 
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string journalFileName)
    {
        using ( StreamWriter outputFile = new StreamWriter(journalFileName) )
        {
            outputFile.WriteLine("test test test");
        }
    }

    public void LoadFromFile(string file)
    {

    }

}