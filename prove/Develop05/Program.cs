/*
* Purpose: Week 05 Develop: Eternal Quest Program
* Author: Mickael Randriamihaja
* Description: Gamification program that helps user to create, store, achieve goals, and calculate related points.
* There are some types of Goals (Simple, Eternal, Checklist Goals)
* Creativities: I added some controls in order to the program, when the user type another number than permitted, 
* there is notification to choose appropriate number.
*/
using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        
    }
}