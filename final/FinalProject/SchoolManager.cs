using System;
using System.Collections.Generic;
using System.IO; 

public class SchoolManager
{

    private List<Student> _students = new List<Student>();

    private List<string> _employees;


    public void RunProgram()
    {
        Console.WriteLine("Welcome to the Small School Management program");
        Console.WriteLine();

        int quitProgram = 0;

        while(quitProgram != 4)
        {
            // string strSeparator = ";";
            Console.WriteLine("Menu Options:");            
            Console.WriteLine("1. Student Management");
            Console.WriteLine("2. Employee Management");

            Console.Write("Which program do you want to run? ");
            string inputProgram = Console.ReadLine();
            quitProgram = Int32.Parse(inputProgram);
            
            // Student
            if(quitProgram == 1)
            {
                
                Console.WriteLine("1. Add new Student");
                Console.WriteLine("2. Search Student");                
                Console.WriteLine("3. Show Students");                

                Console.Write("Which action would you like to do? ");
                string input = Console.ReadLine();

                if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("---Please enter correct value---");
                }
                else
                {

                    int studentAction = Int32.Parse(input);

                    

                    if( studentAction == 1 )
                    {
                        Console.Write("What is the student ID? ");
                        string inputID = Console.ReadLine();
                        int studentID = Int32.Parse(inputID);

                        Console.Write("What is the name of the student? ");
                        string studentName = Console.ReadLine();
                        Console.Write("What is the first name of the student? ");
                        string studentFirstName = Console.ReadLine();
                        Console.Write("Enter the class of this student? (secondary|postsecondary) ");
                        string studentClass = Console.ReadLine();

                        if( studentClass != "secondary" && studentClass != "postsecondary")
                        {
                            Console.WriteLine("---Please choose the correct value:---");
                            Console.Write("Enter the class of this student? (secondary|postsecondary) ");
                            studentClass = Console.ReadLine();

                        }

                        Student student = new Student(studentID, studentName, studentFirstName, studentClass);

                        string studentData = student.GetStringData();
                        if ( studentClass == "secondary" )
                        {
                            _students.Add(new SecondaryStudent());                    
                        }
                        else 
                        {
                            _students.Add(new PostSecondaryStudent());
                        }
                

                    }
                    // search student
                    else if( studentAction == 2 )
                    {
                        Console.WriteLine($"===There are {_students.Count} students found===");
                    }
                    // show student
                    else if ( studentAction == 3 )
                    {
                        Student student = new Student();
                        student.ShowStudents(_students);
                    }
                }
                
            }
            // Employee 
            else if( quitProgram == 2 )
            {

                Console.WriteLine("1. Add new employee");
                Console.WriteLine("2. Show employees");
                Console.Write("Which action would you like to do? ");
                string employeeAction = Console.ReadLine();

                if( employeeAction == "1" )
                {         
                    Console.WriteLine("Please enter the following informations:");           
                    Console.Write("Employee ID: ");
                    string inputID = Console.ReadLine();
                    int employeeID = Int32.Parse(inputID);

                    Console.Write("Employee name: ");
                    string employeeName = Console.ReadLine();
                    Console.Write("Employee first name: ");
                    string employeeFirstName = Console.ReadLine();
                    Console.Write("Type of employee (fix or hourly): ");
                    string employeeType = Console.ReadLine();

                    Employee employee = new Employee( employeeID, employeeName, employeeFirstName, employeeType );
                    string employeeData = employee.GetStringDataInformations();
                    _employees.Add(employeeData);

                }
                else if( employeeAction == "2" )
                {

                }

            }
            //
            else if(quitProgram == 3)
            {

            }

        }

    }

    public class AddRecord()
    {

    }

    public string SearchData(string type)
    {
        return "";
    }

    public string GetStats()
    {
        return "";
    }

    public string ShowStudentsData()
    {
        foreach(Student student in _students )
        {
            Console.WriteLine( student );
        }
        return "";
    }

    public void SaveDataToFile( string fileName, string data )
    {
        using (StreamWriter outputFile = new StreamWriter( fileName ) ) 
        {
            outputFile.WriteLine( data );
        }
    }
}