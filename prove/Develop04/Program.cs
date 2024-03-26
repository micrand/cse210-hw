/*
 * Purpose: W04 - Inheritence application - Mindfulness activities
 * Author: Mickael Randriamihaja
 * Creativities: Add additional activity, keep log of how many activities were performed for a session.
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string display_option = "";

        int totalActivityCount = 0;

        while (display_option !=  "5")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Start Physical activity");
            Console.WriteLine("5. Quit");
            display_option = Console.ReadLine();

            string activityName = "";
            string activityDescription = "Breathing Activity";
            int activityDuration = 0;

            if( display_option == "1" )
            {
                activityName = "Breathing Activity";
                activityDescription = "This activity will help you relax by walking your through ";
                activityDescription += "breathing in and out slowly. Clear your mind and focus ";
                activityDescription += "on your breathing.";

                Console.Write("How long in seconds, would you like for your session? ");

                string duration = Console.ReadLine();        
                activityDuration = Convert.ToInt32(duration);
                        
                BreathingActivity breathActivity = new BreathingActivity( activityName, activityDescription, activityDuration );
                breathActivity.DisplayStartingMessage();
                breathActivity.Run();

            }
            else if( display_option == "2" )
            {
                activityName = "Reflecting Activity";
                activityDescription = "This activity will help you reflect on times in your life ";
                activityDescription += "when you have shown strength and resilience. This will help you ";
                activityDescription += "recognize the power you have and how you can use it in other ";
                activityDescription += " aspects of your life.";

                Console.Write("How long in seconds, would you like for your session? ");
                string duration = Console.ReadLine();        
                activityDuration = Convert.ToInt32(duration);
                        
                ReflectingActivity reflectActivity = new ReflectingActivity( activityName, activityDescription, activityDuration );
                reflectActivity.DisplayStartingMessage();
                reflectActivity.Run();
                

            }
            else if( display_option == "3" )
            {
                activityName = "Listing Activity";
                activityDescription = "This activity will help you reflect on the good things in your life ";
                activityDescription += "by having you list as many thing as you can in certain area.";

                Console.Write("How long in seconds, would you like for your session? ");
                string duration = Console.ReadLine();
                activityDuration = Convert.ToInt32(duration);
                        
                ListingActivity listActivity = new ListingActivity( activityName, activityDescription, activityDuration );
                listActivity.DisplayStartingMessage();
                listActivity.Run();

            }else if(display_option == "4" )
            {
                activityName = "Physical Activity";
                activityDescription = "This activity will help you to move your body and be strong and dynamic.";
                activityDescription += "Some body activities will be prompt to you for that.";

                Console.Write("How long in seconds, would you like for your session? ");
                string duration = Console.ReadLine();
                activityDuration = Convert.ToInt32(duration);
                        
                PhysicalActivity physicsActivity = new PhysicalActivity( activityName, activityDescription, activityDuration );
                physicsActivity.DisplayStartingMessage();
                physicsActivity.Run();

            }

            totalActivityCount++;

        }

        Console.WriteLine("Congratulations!");
        Console.WriteLine($"You have done {totalActivityCount} today.");
        Console.WriteLine($"Keep going on regularly.");
        
    }
}