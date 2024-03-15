class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        Console.WriteLine($"1/1;");
        return;
    }

    public Fraction(int wholeNumber)
    {
        Console.WriteLine($"{wholeNumber}/1;");

    }

    public Fraction(int top, int bottom)
    {
        Console.WriteLine($"{top}/{bottom};");
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
}