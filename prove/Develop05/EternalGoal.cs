public class EternalGoal : Goal 
{
    public EternalGoal( string name, string description, string points) : base(name, description, points)
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return base.IsComplete();
    }

    public string GetStringsRepresentation()
    {
        return "";
    }
}