public class Jobs 
{
    public string _jobTitle;

    public string _company;
    public int _startYear;
    public int _endYear;

    public Jobs()
    {
    }

    public void Display() {
        Console.WriteLine( $"{this._jobTitle} ({this._company}) {this._startYear}-{this._endYear}");
    }


}