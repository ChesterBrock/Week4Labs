
/// Chapter No. 4		Exercise No. 2
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Sep 19, 2021
///
/// Problem Statement: Program the flow chart to check why a lamp is not working.  
/// 
/// 
/// Overall Plan:
/// 1) Prompt the user to enter if the lamp is plugged in and read in the result. 
/// 2) do the same for if the bulb is out. 
/// 3) Check if the user answered yes or no for each question and respond accordingly. 
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            // statments to simulate a Lamp flowchart
            // prompt user 
            Console.WriteLine("The Lamp doesn't work? \n Well is the Lamp plugged in?\n(Type: yes or n" +
                "o - Lowercased)");
            String pluggedIn = (Console.ReadLine() == "yes") ? "yes" : "no"; // checking to see if plugged in
            Console.WriteLine("Is the bulb out?");
            String BulbOut = (Console.ReadLine() == "yes") ? "yes" : "no"; // checking for bulb out

            // displaying results 
            if (pluggedIn.Equals("yes") && BulbOut.Equals("no"))
            {
                Console.WriteLine("Something else is wrong with the lamp.");
            }
            else if(pluggedIn.Equals("yes") && BulbOut.Equals("yes"))
            {
                Console.WriteLine("The Light bulb needs to be replaced");
            }
            else if(pluggedIn.Equals("no") && BulbOut.Equals("no"))
            {
                Console.WriteLine("The lamp needs to be plugged in");
            }
            else
            {
                Console.WriteLine("The bulb is out and the lamp is unplugged");
            }
            // to pause the output 
            Console.ReadLine();

        }
    }
}
