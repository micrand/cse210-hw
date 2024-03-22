using System;
using System.Collections.Generic;
using System.Text;

class Journal 
{
    public List<Entry> _entries = new List<Entry>();    

    public void AddEntry(Entry NewEntry)
    {   
        _entries.Add(NewEntry);
    }

    public string DisplayAll()
    {
        var textToDisplay = "";
        foreach(var data in _entries)
        {            
            textToDisplay += data.Display();
            textToDisplay += "\n";           
        }
        return textToDisplay;
    }

    public void SaveToFile(string journalFileName)
    {
        string[] arrayExtension = journalFileName.Split(".");
        string extension = arrayExtension[1];

        if(extension=="csv")
        {
            string separator = ";";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Date", "Q/R", "Topic" };
            output.AppendLine(string.Join(separator, headings));

            foreach(var line in _entries)
            {
                
                string data = line.Display();
                string[] row = data.Split("-");
                
                string date = row[0].Replace("Date: ","");
                string question = row[1].Replace("Prompt: ", "");
                string topic = row[2].Replace("(","").Replace(")","");                
                
                String[] newLine = { date.Trim(), question.Trim(), topic.Trim() };
                output.AppendLine(string.Join(separator, newLine));
                
            }
            try{
                File.AppendAllText(journalFileName, output.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is error when writ to the CSV file \n");
                Console.WriteLine(ex);
                return;

            }
            
            
        }
        else
        {
            using ( StreamWriter outputFile = new StreamWriter(journalFileName) )
            {   
                
            
                string textToWrite = DisplayAll();
                outputFile.WriteLine(textToWrite);
            
                
            }
        }

    }

    public void LoadFromFile(string journalFileName)
    {
        string[] lines = System.IO.File.ReadAllLines(journalFileName);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }

    }

}