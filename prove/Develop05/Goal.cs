using System.Drawing;

public class Goal
{
    private string _shortName;
    private string _description;

    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }

    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string description)
    {
        _shortName = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public virtual void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;

    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringsRepresentation()
    {
        return "";
    }
}