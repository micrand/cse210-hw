using System;

class Program
{
    static void Main(string[] args)
    {
        int quitProgram = 0;
        while(quitProgram!=6)
        {

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

            }

        }
    }
}