using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.RPS_Game
{
    public class RpsCreation
    {
        private readonly ApplicationDbContext _dbContext;

        public RpsCreation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string playerChoice;
        public string computerChoice;
        RPS rps = new RPS();

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

        public void Scissors()
        {
            computerChoice = GetComputerChoice();
            playerChoice = "Scissors";
            if (computerChoice == "Rock")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Computer wins");
                Console.ResetColor();
                rps.Losses++;
                rps.Rounds++;
            }
            else if (computerChoice == "Paper")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win");
                Console.ResetColor();
                rps.Wins++;
                rps.Rounds++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It's a tie");
                Console.ResetColor();
                rps.Rounds++;
            }
            _dbContext.RPSGames.Add(new RPS
            {
                Date = DateTime.Now,
                Wins = rps.Wins,
                Losses = rps.Losses,
                Rounds = rps.Rounds,
                PlayerChoice = playerChoice,
            });
            _dbContext.SaveChanges();
        }
        public void Paper()
        {
            computerChoice = GetComputerChoice();
            playerChoice = "Paper";
            if (computerChoice == "Rock")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win");
                Console.ResetColor();
                rps.Wins++;
                rps.Rounds++;
            }
            else if (computerChoice == "Paper")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It's a tie");
                Console.ResetColor();
                rps.Rounds++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Computer wins");
                Console.ResetColor();
                rps.Losses++;
                rps.Rounds++;
            }
            _dbContext.RPSGames.Add(new RPS
            {
                Date = DateTime.Now,
                Wins = rps.Wins,
                Losses = rps.Losses,
                Rounds = rps.Rounds,
                PlayerChoice = playerChoice,
            });
            _dbContext.SaveChanges();
        }
   
        public void Rock()
        {
            computerChoice = GetComputerChoice();
            playerChoice = "Rock";
            if (computerChoice == "Rock")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It's a tie");
                Console.ResetColor();
                rps.Rounds++;
            }
            else if (computerChoice == "Paper")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Computer wins");
                Console.ResetColor();
                rps.Losses++;
                rps.Rounds++;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win");
                Console.ResetColor();
                rps.Wins++;
                rps.Rounds++;

            }
            _dbContext.RPSGames.Add(new RPS
            {
                Date = DateTime.Now,
                Wins = rps.Wins,
                Losses = rps.Losses,
                Rounds = rps.Rounds,
                PlayerChoice = playerChoice,
            });
            _dbContext.SaveChanges();
        }
    }
}

