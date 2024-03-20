using System;
using System.Collections.Generic;

class WritingAssignment : Assignment
{
    protected string _string = "";

    public WritingAssignment(string studentName, string topic, string str): base( studentName, topic )
    {
        _string = str;
    }

    public string GetWritingInformation()
    {
       return _string;
    }

    
}