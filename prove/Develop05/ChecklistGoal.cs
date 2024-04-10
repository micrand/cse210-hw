public class ChecklistGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal( string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        base.SetShortName(name);
        base.SetDescription(description);
        base.SetPoints(points);
        _target = target;
        _bonus = bonus;

    }

    public override void RecordEvent()
    {
        
    }

    public bool IsComplete()
    {
        return base.IsComplete();
    }

    
    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringsRepresentation()
    {
        string name = base.GetShortName();
        string description = base.GetDescription();
        int points = base.GetPoints();

        string sGoalText = $"{name},{description},{points} -- Currently completed: 0/{_target}";
        return sGoalText;
    }
}