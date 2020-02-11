using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Let a user input a number of seconds and format it so that it comes out in years, months, weeks, days, hours, minutes, seconds.
// Do NOT use build in formatting. You have the calculate this result yourself.
// Keep it clean.

namespace FormatSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Save the user input
            int userInput = 0;
            
            //Get the user input until they give a number
            do
            {
                //Tell user to input a number
                Console.WriteLine("Please insert the amount of seconds you want to format.");
                //Try to parse the input the users gives and output to userInput
                int.TryParse(Console.ReadLine(), out userInput);
                
                //If User inserted no number or a number below 1 then tell them to retry
                if(userInput <= 0) Console.WriteLine("Oops you didn't insert a number that I can format.\n");
            } while (userInput > 0);
        }
    }
}
