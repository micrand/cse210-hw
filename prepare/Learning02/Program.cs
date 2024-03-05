using System;

class Program
{
    static void Main(string[] args)
    {
        //create first job instance
        Jobs job1 = new Jobs();
        job1._jobTitle = "Software engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //create second job instance
        Jobs job2 = new Jobs();
        job2._jobTitle = "Anne Marie";
        job2._company = "IBM";
        job2._startYear = 2017;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Friedrich Erbert";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();        
    }    
}