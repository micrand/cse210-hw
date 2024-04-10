public class FullEmployee : Employee
{  

    public FullEmployee(int id, string name, string firstName, string employeeType):base(id, name, firstName, employeeType)
    {
        
    }

    public override string GetStringDataInformations()
    {
        return "nan";
    }

    public override string ShowEmployeesDetails()
    {
        
        return "";
    }

}