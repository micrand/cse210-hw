/*
* Purpose: Final project Milestone - 
* Description: This is an open-ended project which is named Small School Management. It manages students, school employees (which types are administration employees or teachers).
* The teachers are paid monthly as fix employees, or hourly. It also handles disciplines, grades, students as parent class of Secondary and postSecondary students (subclasses).* 
* It will applies the principles learnt which are OOP based: Abstraction, Encapsulation, Inheritence and Polymorphism.
* Author: Mickael Randriamihaja
*
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        SchoolManager program = new SchoolManager();
        program.RunProgram();
    }
}