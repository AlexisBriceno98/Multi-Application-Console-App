using KyhProject1.Controllers;
using KyhProject1.Data.RPS_Game;
using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Menus
{
    public class MainMenu
    {
        public void StartMainMenu()
        {
            var ProjectBuilder = new Builder();
            var dbContext = ProjectBuilder.projectBuilder();
            var errorMessage = new ErrorMessageHandling();
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to AP1");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Please choose a program");
                    Console.WriteLine("1. Shapes, 2. Calculator, 3. Rock Paper Scissors game, 4. Exit");
                    var programSelection = Convert.ToInt32(Console.ReadLine());
                    

                    if (programSelection == 4)
                    {
                        Console.Clear();
                        break;
                    }

                    else if (programSelection == 1)
                    {
                        Console.Clear();
                        var MenuforShapes = new ShapesMenu(dbContext);
                        MenuforShapes.MenuForShapes();
                    }
                    else if (programSelection == 2)
                    {
                        Console.Clear();
                        var MenuForCalculator = new CalculatorMenu(dbContext);
                        MenuForCalculator.RunCalculator();
                    }
                    else if (programSelection == 3)
                    {
                        Console.Clear();
                        var MenuForRpsGame = new RpsGame(dbContext);
                        MenuForRpsGame.StartRpsGame();
                    }
                    else
                    {
                        errorMessage.ErrorHandling();
                        continue;
                    }
                }
                catch
                {
                    errorMessage.ErrorHandling();
                    continue;
                    
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thank you for using AP1, Bye!");
            Console.ResetColor();
        }

    }
}
