using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.RPS_Game
{
    public class RpsGame
    {
        public string playerChoice;
        public string computerChoice;

        public void StartRpsGame()
        {
            bool choice = true;
            while (choice)
            {
                Console.WriteLine(" Welcome to Rock, Paper, Scissors Game");
                Console.WriteLine(" Please enter your choice: ");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Quit");

                playerChoice = Console.ReadLine();
                if (playerChoice == "4")
                {
                    break;
                }
                if (!ValidateChoice(playerChoice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    continue;
                }
                computerChoice = GetComputerChoice();
                DetermineWinner();
                Console.WriteLine("Do you want to play again? Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

           public bool ValidateChoice(string choice)
            {
                if (choice == "1" || choice == "2" || choice == "3")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public string GetComputerChoice()
            {
                Random rand = new Random();
                int choice = rand.Next(1, 4);
                if (choice == 1)
                {
                Console.WriteLine("Computer chose Rock");
                    return "Rock";
                }
                else if (choice == 2)
                {
                Console.WriteLine("Computer chose Paper");
                    return "Paper";
                }
                else
                {
                Console.WriteLine("Compueter chose Scissors");
                    return "Scissors";
                }
            }

            public void DetermineWinner()
            {

                if (playerChoice == "1")
                {
                    if (computerChoice == "Rock")
                    {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("It's a tie");
                    Console.ResetColor();
                    }
                    else if (computerChoice == "Paper")
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins");
                    Console.ResetColor();
                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win");
                    Console.ResetColor();
                    }
                }

                else if (playerChoice == "2")
                {
                    if (computerChoice == "Rock")
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win");
                    Console.ResetColor();
                    }
                    else if (computerChoice == "Paper")
                    {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("It's a tie");
                    Console.ResetColor();
                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins");
                    Console.ResetColor();
                    }
                }

                else if (playerChoice == "3")
                {
                    if (computerChoice == "Rock")
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer wins");
                    Console.ResetColor();
                    }
                    else if (computerChoice == "Paper")
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win");
                    Console.ResetColor();
                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("It's a tie");
                    Console.ResetColor();
                    }
                }
            }
    }
}
