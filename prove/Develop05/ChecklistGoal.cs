public class ChecklistGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal( string name, string description, string points, int target, int bonus) : base(name, description, points)
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return base.IsComplete();
    }

    
    public string GetDetailsString()
    {
        return "";
    }

    public string GetStringsRepresentation()
    {
        return "";
    }
}