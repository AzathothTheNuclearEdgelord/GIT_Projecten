using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Ask the user for a number.
// Determine whether the input is even or odd.
// Give the output back.
// Make sure code and user interaction is clean.

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            string userInput;
            
            //Habitual continue function
            void Continue()
            {
                Console.WriteLine("\nPress [ENTER] to continue.");
                Console.ReadLine();
            }

            Console.WriteLine("Please enter a number to see if it's even or odd.");
            
            do
            {
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out userNumber));

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("\nYour number, {0} is an even number", userNumber);
            }
            else
            {
                Console.WriteLine("\nYour number, {0} is an odd number", userNumber);
            }
            
            Continue();
        }
    }
}