public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string Hide()
    {
        return "____";

    }

    public string Show()
    {        
        return _text;
    }

    public void isHidden()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {        
        string _return_text = Hide();
        
        return _return_text;
    }

}