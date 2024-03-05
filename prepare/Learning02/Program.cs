using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobTitle = "Software engineer (Microsoft)";
        job1._startYear = "2019";
        job1._endYear = "2022";
        
        Console.WriteLine( $"{job1._jobTitle} {job1._startYear}-{job1._endYear}");
    }
}