public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        // _isHidden = false;
    }

    public string Hide()
    {
        
        return "____";

    }

    public string Show()
    {        
        return _text;
    }

    public bool isHidden()
    {
        if( _text == "____")
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false;
        }
        return _isHidden;
    }

    public string GetDisplayText()
    {        
        string _return_text = "";        
        
        if(!isHidden())
        {            
            _return_text = Show();
        }
        else
        {
            _return_text = Hide();
        }
        
        return $"{_return_text}";
    }

}