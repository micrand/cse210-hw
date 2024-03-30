using System;
using System.Collections.Generic;

public class Scripture
{
    private string _reference;
    private List<string> _words = new List<string>();

    public Scripture(Reference reference, string text)
    {   
        foreach(var data in text.Split(" "))
        {
            Word displayWord = new Word(data.ToString());                
            string newWord = displayWord.GetDisplayText();

            _words.Add(data.ToString());
        }   
       
    }

    public void HideRandomWords(int numberToHide)
    {
       
        // Random random = new Random();
        // int indexRandom = random.Next(0, _words.Count);
        // return indexRandom;
        
    }

    public string GetDisplayText()
    {
        string fullWord = "";
        string separatorWord = " ";
        List<string> arrayHiddenWords = new List<string>();
        Random intRandom = new Random();        
        
        for(var i=0; i<_words.Count;i++)
        {            
            Word word = new Word(_words[i]);
            Random random = new Random();
            int nbToHide = random.Next(0, _words.Count);

            int maxToHide = nbToHide + 3;
            
            // Console.Write(word.GetDisplayText());      
            string currentWord = word.GetDisplayText();
            if(i>nbToHide && i<maxToHide) 
            {
                arrayHiddenWords[i] = currentWord;
            }

            if(arrayHiddenWords.Contains(currentWord))
            {
                word.Hide();
            }else{
                word.Show();
            }
           
            
            string displayedWord = "";           
            
            // Console.Write(currentWord);
            // Console.Write(HideRandomWords(i));
            
            Console.Write(separatorWord);

        }

        // Console.WriteLine(arrayHiddenWords.ToString().ToList());
       
        return fullWord;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}