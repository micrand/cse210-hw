public class SecondaryStudent : Student
{
    private List<Grade> _grades = new List<Grade>();


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


    // Handle custom data display for Secondary studens
    public override void FillStudentsData()
    {
        

    }

    public override void ShowStudents(List<Student> studentsData)
    {
        // Console.WriteLine(students);
        foreach( Student student in studentsData ?? new List<Student>() )
        {         
            Console.WriteLine("sec="+student.GetStudentName());
        }
    }

}