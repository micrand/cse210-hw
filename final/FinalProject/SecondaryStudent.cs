public class SecondaryStudent : Student
{
    public List<Discipline> _disciplines;
    private List<Grade> _grades;
    public SecondaryStudent()
    {
        
    }

    public virtual string GetInformations()
    {
        return "";
    }
}