public class SecondaryStudent : Student
{


    public SecondaryStudent()
    {

    }

    public SecondaryStudent(int id, string name, string firstName, string studentClass):base(id, name, firstName, studentClass)
    {
        
    }

    public override string GetStringData()
    {
        string name = base.GetStudentName();
        string firstName = base.GetStudentFirstName();
        string studentClass = base.GetStudentClass();
        Console.WriteLine( $"{name};{firstName};{studentClass}" );

        return "";
    }

}