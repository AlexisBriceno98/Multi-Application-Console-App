using KyhProject1.Controllers;
using KyhProject1.Data.Calculator;
using KyhProject1.Data.Shapes;
using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Menus
{
    public class CalculatorMenu
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ErrorMessageHandling _errorMessage;

        public CalculatorMenu(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _errorMessage = new ErrorMessageHandling();
        }
        public void RunCalculator()
        {
            bool exit = true;
            var returnToMenu = new ReturnToMainMenu();
            var calcCrud = new CalculatorCrud(_dbContext);
            while (exit)
            {
                try
                {
                    Console.WriteLine("Welcome to the Calculator");
                    Console.WriteLine("Please choose a function");
                    Console.WriteLine("1. Start a calculation || 2. Read calculations || 3. Update a calculation || 4. Delete a calculation || 5. Exit to main menu ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            calcCrud.CalculatorCreate();
                            break;
                        case 2:
                            calcCrud.CalculatorRead();
                            Console.Clear();
                            break;
                        case 3:
                            calcCrud.CalculatorUpdate();
                            break;
                        case 4:
                            calcCrud.CalculatorDelete();
                            break;
                        case 5:
                            Console.Clear();
                            returnToMenu.returnToMainMenu();
                            exit = false;
                            break;
                        default:
                            {
                                _errorMessage.ErrorHandling();
                                continue;
                            }
                    }

                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("Press ENTER to go back to Calculator Menu");
                    //Console.ResetColor();
                    //Console.ReadKey();
                    //Console.Clear();
                }
                catch
                {
                    _errorMessage.ErrorHandling();

                }
            }
        }
    }
}
     
