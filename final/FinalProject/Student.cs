public class Student 
{
    private int _ID;
    private string _name;
    private string _firstname;
    private string _birthdate;
    private string _studentClass;

    public Student()
    {

    }

    public void SetID(int id)
    {
        _ID = id;
    }

    public int GetID()
    {
        return _ID;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
}