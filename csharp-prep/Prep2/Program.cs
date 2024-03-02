using System;

class Program
{
    class printBonus
    {
        public static string printAddMinus(int currentGrade, string level)
        {
            string suffixBonus = "";   
            int lastDigit = currentGrade % 10;         

            if( lastDigit >= 7 )
            {   
                if( level != "A" ) 
                {
                    suffixBonus = "+";
                }
               
            }
            else if( lastDigit <= 3 ) 
            {                
                if (level != "F" ) 
                {
                    suffixBonus = "-";
                }                
            }
            
            return suffixBonus;

        }
    }

    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        string gradeResult;

        if( gradeInt >= 90)
        {
            gradeResult = "A";            
        }
        else if(gradeInt >= 80)
        {
            gradeResult = "B";            
        }
        else if(gradeInt >= 70)
        {
            gradeResult = "C";
        }
        else if(gradeInt >= 60 )
        {
            gradeResult = "D";
        }
        else
        {   
            gradeResult = "F";
        }

        string addOrMinus = printBonus.printAddMinus(gradeInt, gradeResult);
        Console.WriteLine($"Your grade is {gradeResult}{addOrMinus}");
        

    }
}