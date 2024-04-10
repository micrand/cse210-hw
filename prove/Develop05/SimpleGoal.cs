public class SimpleGoal : Goal 
{
    public SimpleGoal( string name, string description, int points) : base(name, description, points)
    {
        base.SetShortName(name);        
        base.SetDescription(description);
        base.SetPoints(points);        
    }

    public override void RecordEvent()
    {
        
    }

    public bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetStringsRepresentation()
    {
        string name = base.GetShortName();
        string description = base.GetDescription();
        int points = base.GetPoints();

        string sGoalText = $"{name},{description},{points},False";
        return sGoalText;
    }
}