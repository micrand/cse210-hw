class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        //Console.WriteLine($"1/1;");
        _top = 1;
        _bottom = 1;
        return;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        //Console.WriteLine($"{wholeNumber}/1;");

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        //Console.WriteLine($"{top}/{bottom};");
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}