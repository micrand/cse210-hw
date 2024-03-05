public class Resume
{
    public string _name;

    public List<Jobs> _jobs = new List<Jobs>();

    public Resume()
    {

    }

    public void Display()
    {
        Console.WriteLine( $"Name: {this._name}");
        Console.WriteLine( $"Job: ");
        foreach(Jobs jb in _jobs)
        {
            jb.Display();
        }

    }
}