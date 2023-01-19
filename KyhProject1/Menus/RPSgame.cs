using KyhProject1.Data.Calculator;
using KyhProject1.Data.RPS_Game;
using KyhProject1.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Menus
{
    public class RpsGame
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ErrorMessageHandling _errorMessage;

        public RpsGame(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _errorMessage = new ErrorMessageHandling();
        }

        public string playerChoice;
        public string computerChoice;
        RPS rps = new RPS();

        public void StartRpsGame()
        {
            var game = new RpsCreation(_dbContext);
            var returnToMainMenu = new ReturnToMainMenu();
            bool choice = true;
            var answer = "";
            while (choice)
            {
                bool choice1 = true;
                try
                {
                    Console.WriteLine(" Welcome to Rock, Paper, Scissors Game");
                    Console.WriteLine(" Please enter your choice: ");
                    Console.WriteLine("1. Rock");
                    Console.WriteLine("2. Paper");
                    Console.WriteLine("3. Scissors");
                    Console.WriteLine("4. Quit");
                    var playerChoice = Convert.ToInt32(Console.ReadLine());
                    switch (playerChoice)
                    {
                        case 1:
                            game.Rock();
                            break;
                        case 2:
                            game.Paper();
                            break;
                        case 3:
                            game.Scissors();
                            break;
                        case 4:
                            Console.Clear();
                            returnToMainMenu.returnToMainMenu();
                            choice1 = false;
                            choice = false;
                            break;
                        default:
                            {
                                _errorMessage.ErrorHandling();
                                continue;
                            }
                    }
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                    continue;
                }
                while (choice1)
                {
                    Console.WriteLine("Would you like to play again? 1. Yes, 2. No");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        choice1 = false;
                        choice = true;

                    }
                    else if (answer == "2")
                    {
                        Console.Clear();
                        returnToMainMenu.returnToMainMenu();
                        choice1 = false;
                        choice = false;
                    }
                    else
                    {
                        _errorMessage.ErrorHandling();
                    }
                }
            }
            Console.Clear();
        }
    }
}
