public class Employee
{
    private int _employeeID;

    private string _employeeName;

    private string _employeeFirstName;

    private string _employeeType;

    private List<string> _employees = new List<string>();

    public Employee()
    {

    }
    
    public Employee(int id, string name, string firstName, string employeeType)
    {
        this.SetEmployeeID(id);
        this.SetEmployeeName(name);
        this.SetEmployeeFirstName(firstName);
        this.SetEmployeeType(employeeType);

    }

    public int GetEmployeeID()
    {
        return _employeeID;
    }

    public void SetEmployeeID( int id )
    {
        _employeeID = id;
    }

    public string GetEmployeeName()
    {
        return _employeeName;

    }

    public void SetEmployeeName( string name )
    {
        _employeeName = name;        
    } 

    public string GetEmployeeFirstName()
    {
        return _employeeFirstName;
    }

    public void SetEmployeeFirstName(string firstName)
    {
        _employeeFirstName = firstName;        
    }

    public string GetEmployeeType()
    {
        return _employeeType;
    }

    public void SetEmployeeType( string type )
    {
        _employeeType = type;
    }

    public virtual string GetStringDataInformations()
    {
        return "nan";
    }

    public virtual string ShowEmployeesDetails()
    {
        Console.WriteLine("ShowEmployees default");
        return "";
    }
}