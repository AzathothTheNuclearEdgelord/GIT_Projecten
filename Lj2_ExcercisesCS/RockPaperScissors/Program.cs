using System;
using System.Collections.Generic;
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

            //AI input
            string inputAI;
          
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
                if(Array.Find(rockPaperScissors, rps => rps.ToLower() == userInput.ToLower()) != null)
                {
                    resume = true;
                }
                else
                {
                    resume = false;
                }
            } while (!resume);

            Console.WriteLine("You chose {0}.", userInput);
            choiceAI = rndm.Next(1, 4);
            inputAI = rockPaperScissors[choiceAI];
            Console.WriteLine("AI chose {0}.", inputAI);
            Console.ReadLine();
            if(userInput == rockPaperScissors[0] && inputAI == rockPaperScissors[0]) if (userInput == rockPaperScissors[1] && inputAI == rockPaperScissors[1]) if (userInput == rockPaperScissors[2] && inputAI == rockPaperScissors[2])
            {
                Console.WriteLine("Nobody wins.");
            }
            if (userInput == rockPaperScissors[0] && inputAI == rockPaperScissors[1]) if (userInput == rockPaperScissors[1] && inputAI == rockPaperScissors[2]) if (userInput == rockPaperScissors[2] && inputAI == rockPaperScissors[0])
            {
                Console.WriteLine("The player wins.");
            }
            if (userInput == rockPaperScissors[0] && inputAI == rockPaperScissors[2]) if (userInput == rockPaperScissors[1] && inputAI == rockPaperScissors[0]) if (userInput == rockPaperScissors[2] && inputAI == rockPaperScissors[1])
            {
                Console.WriteLine("The computer wins.");
            }
            Console.ReadLine();
        }
    }
}
