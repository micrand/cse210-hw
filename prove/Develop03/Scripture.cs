public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {          
        _reference = reference.GetDisplayText();
        Word newWord = new Word(text);
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}