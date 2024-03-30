public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public void SetBook(string book)
    {
        _book = book;        
    }

    public string GetBook()
    {
        return _book;

    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {        
        Console.Write(_book+" "+_chapter+":"+_verse);
        if(_endVerse != 0)
        {
            Console.Write("-"+_endVerse);
        }
        Console.Write(" ");
        return "";
    }


}