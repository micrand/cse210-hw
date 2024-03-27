public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color, side)
    {       
        _side = side;

    }

    public override double GetArea()
    {
        return base.GetArea();
    }

}