public class HourlyEmployee : Employee
{
    private int _salary;

    public HourlyEmployee(int id, string name, string firstName, string employeeType):base(id, name, firstName, employeeType)
    {
        int salary = 250;
        int hours = 4;
        this.SetSalary(salary, hours);
    }

    public float GetSalary()
    {
        return _salary;
    }

    public void SetSalary( int salary, int hours )
    {
        _salary = salary * hours;
    }

    public override string ShowEmployeesDetails()
    {
        
        return "";
    }


}