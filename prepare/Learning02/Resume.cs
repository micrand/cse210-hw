public class Resume
{
    public string _name;

    public List<Jobs> _jobs = new List<Jobs>();

    public Resume()
    {

    }

    public void Display()
    {
        Console.WriteLine( $"{this._name}");
    }
}