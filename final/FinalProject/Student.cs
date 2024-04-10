public class Student 
{

    private int _studentID;

    private string _studentName;

    private string _studentFirstName;

    private string _studentClass;

    public Student()
    {

    }

    public Student(int id, string name, string firstName, string studentClass)
    {
        this.SetStudentID(id);
        this.SetStudentName(name);
        this.SetStudentFirstName(firstName);
        this.SetStudentClass(studentClass);

    }


    public void SetStudentID(int id)
    {
        _studentID = id;
    }

    public int GetStudentID()
    {
        return _studentID;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string name)
    {
        _studentName = name;
    }

    public string GetStudentFirstName()
    {
        return _studentFirstName;
    }

    public void SetStudentFirstName(string firstName)
    {
        _studentFirstName = firstName;
    }

    public string GetStudentClass()
    {
        return _studentClass;

    }

    public void SetStudentClass(string sClass)
    {
        _studentClass = sClass;
    }

    public virtual string GetStringData()
    {
        string studentData = $"{_studentID};{_studentName};{_studentFirstName};{_studentClass}...";
        Console.WriteLine(studentData);

        return studentData;
    }

}