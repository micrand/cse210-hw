using System.Drawing;
using System.IO; 


public class GoalManager
{
    private List<string> _goals = new List<string>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        int quitProgram = 0;

        while(quitProgram!=6)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();

            Console.WriteLine("Menu options:");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string doProgram = Console.ReadLine();
            quitProgram = Int16.Parse(doProgram);   


            if(quitProgram == 1) 
            {
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string typeOfGoal = Console.ReadLine();

                // string commaSeparator = ",";
                string semiColonSeparator = ":";

                // if( typeOfGoal == "1" )
                // {
                if( typeOfGoal == "1" || typeOfGoal == "2" || typeOfGoal == "3" )
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string shortDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string pointInput = Console.ReadLine();
                    int pointAmount = Int16.Parse(pointInput);

                    string goalType = "";

                    if (typeOfGoal == "2")
                    {
                        goalType = "EternalGoal";
                        EternalGoal eternalGoal = new EternalGoal(goalName, shortDescription, pointAmount);
                        string eternalGoalContent = goalType+semiColonSeparator;
                        eternalGoalContent += eternalGoal.GetStringsRepresentation();
                        _goals.Add(eternalGoalContent);
                        
                    }
                    else if(typeOfGoal == "3")
                    {
                        goalType = "ChecklistGoal";                        
                        
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        string targetPoint = Console.ReadLine();
                        int target = Int16.Parse(targetPoint);

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        string bonusPoint = Console.ReadLine();
                        int bonus = Int16.Parse(bonusPoint);

                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, shortDescription, pointAmount, target, bonus);
                        string checklistGoalContent = goalType+semiColonSeparator;
                        checklistGoalContent += checklistGoal.GetStringsRepresentation();
                        _goals.Add(checklistGoalContent);
                        
                    }
                    else {
                        goalType = "SimpleGoal";
                        SimpleGoal simpleGoal = new SimpleGoal(goalName, shortDescription, pointAmount);
                        string simpleGoalContent =  goalType+semiColonSeparator;
                        simpleGoalContent += simpleGoal.GetStringsRepresentation();
                        
                        _goals.Add(simpleGoalContent);
                    }
                   
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("!!!Please enter correct value: choose 1, 2 or 3 only!!!");
                    Console.WriteLine();
                }
                
            }
            else if(quitProgram == 2)
            {

                int i = 0;
                if( _goals.Count > 0 ) 
                {
                    // Console.WriteLine("The goals are: ");
                    
                    // foreach( string goal in _goals ) 
                    // {
                    //     i++;        
                    //     string[] typeParts = goal.Split(":");
                    //     string[] goalParts = typeParts[1].Split(",");
                    //     string goalName = goalParts[0];
                    //     string goalDescription = goalParts[1];
                        
                    //     Console.WriteLine( $"{i}. [ ] {goalName} ({goalDescription})" ) ;
                    // }    
                    this.ListGoalDetails();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("!!!There are no goal defined yet!!!");
                    Console.WriteLine("---Please create new goal or load from file, choose appropriate menu.---");
                    Console.WriteLine();
                }


            }
            else if(quitProgram == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                this.SaveGoals(fileName);


            }
            else if(quitProgram == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                this.LoadGoals(fileName);
            }
            else if(quitProgram == 5)
            {

                this.ListGoalNames();

                Console.Write("Which goal did you accomplish? ");
                string fileName = Console.ReadLine();

                Console.WriteLine("Congratulations! You have earned points!");
                Console.WriteLine($"You now have {_score} points.");
            }

        }

    }

    public void DisplayPlayerInfo()
    {
       
    }

    public string ListGoalNames()
    {
        if(_goals.Count > 0 )
        {
            Console.WriteLine("The goals are: ");
            foreach( string goal in _goals )
            {
                string[] partsType = goal.Split(":");
                string[] parts = goal.Split(",");
                string goalName = "";
                
                Console.WriteLine("goal name="+parts[1]+" "+parts[2]);
            }
        }
        else
        {
            Console.WriteLine("There are no goal defined yet!");
        }
        return "";

    }

    public string ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        int i = 0;
        foreach( string goal in _goals )
        {
            i++;
            string[] partsType = goal.Split(":");
            string[] parts = partsType[0].Split(",");

           
            string goalName = parts[0];
            string goalDescription = parts[1];
                
            Console.WriteLine( $"{i}. [ ] {goalName} ({goalDescription})" ) ;
        }
        return "";
    }    

    public void CreateGoal()
    {
    }    
    
    public void RecordEvent()
    {
    }    

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            Console.WriteLine(0);
            foreach(var goal in _goals)
            {
                outputFile.WriteLine(goal);
            }
        }
    }        

    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach( string line in lines )
        {
            string[] parts = line.Split(",");

            Console.WriteLine(parts[0],parts[1],parts[2]);
            _goals.Add(line);
        }
    }
}