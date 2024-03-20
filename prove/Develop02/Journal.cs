using System;
using System.Collections.Generic;

class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry NewEntry)
    {   
        _entries.Add(NewEntry);
    }

    public void DisplayAll()
    {
        foreach(var data in _entries)
        {            
            Console.WriteLine(data.Display());
        }
    }

    public void SaveToFile(string journalFileName)
    {
        using ( StreamWriter outputFile = new StreamWriter(journalFileName) )
        {
            foreach(var data in _entries)
            {            
            
                outputFile.WriteLine(data.Display());
            }
        }
    }

    public void LoadFromFile(string journalFileName)
    {

    }

}