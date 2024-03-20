using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Assignment assign = new Assignment("Samuel Bennett","Multiplication");
       var summary = assign.GetSummary();      

       MathAssignment math = new MathAssignment("","","Section 7.3","Problem 8-19");
       var homeworkInfo = math.GetHomeworkList();

       Console.WriteLine(summary);
       Console.WriteLine(homeworkInfo);
       Console.WriteLine("===========");

       WritingAssignment writing = new WritingAssignment("","","The Causes of WWII by Mary Waters");
       var writingInfo = writing.GetWritingInformation();
       Console.WriteLine(summary);
       Console.WriteLine(writingInfo);

    }
}