using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Program a game of rock-paper-scissors against the computer.
// Extra: 2 player game.
// Keep it clean.

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //array Rock, Paper, Scissors
            string[] rockPaperScissors = new string[3];
            rockPaperScissors[0] = "Rock";
            rockPaperScissors[1] = "Paper";
            rockPaperScissors[2] = "Scissors";

            //Random
            Random rndm = new Random();

            //choice AI
            int choiceAI;

            //user input
            string userInput;
          
            //choice player
            int choice;

            //continue Rock Paper Scissors input do-while loop
            bool resume = true;

            //introduction
            Console.WriteLine("We've gathered here today to play Rock, Paper, Scissors... AGAINST A COMPUTER!");
            Console.WriteLine("Here we go...");
            Console.ReadLine();

            //input Rock, Paper or Scissors
            do
            {
                Console.Clear();
                resume = true;
                Console.WriteLine("Player, type your choice: Rock - Paper - Scissors");
                userInput = Console.ReadLine();
                Console.WriteLine();
                if(userInput != "Rock")
                {
                    resume = true;
                }
                else
                {
                    resume = false;
                }
            } while (resume = true);

           

            

        }
    }
}
