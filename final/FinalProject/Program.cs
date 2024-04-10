/*
* Purpose: W07 - Final project Milestone - Open-ended
* Description: This is an open-ended project which is named Small School Management. It manages students and
* school employees (which types are administration employees or teachers).
* The teachers are paid monthly as fix employees, or hourly. It also handles Student management, and 
* It will applies the principles learnt which are OOP based: Abstraction, Encapsulation, Inheritence and 
* Polymorphism.
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