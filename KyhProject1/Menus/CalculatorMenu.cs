using KyhProject1.Controllers;
using KyhProject1.Data.Calculator;
using KyhProject1.Data.Shapes;
using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Menus
{
    public class CalculatorMenu
    {
        private readonly ApplicationDbContext _dbContext;

        public CalculatorMenu(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void RunCalculator()
        {
            bool exit = true;
            var errorMessage = new ErrorMessageHandling();
            var returnToMenu = new ReturnToMainMenu();

            while (exit)
            {
                try
                {
                    Console.WriteLine("Welcome to the Calculator, what do you want to calculate?");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Square Root");
                    Console.WriteLine("6. Modulus");
                    Console.WriteLine("7. Exit");
                    Console.Write("Please Enter your choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    string answer = "";
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            var startAddition = new CalculatorCreation(_dbContext);
                            startAddition.Addition();
                            break;

                        case 2:
                            Console.Clear();
                            var startSubstraction = new CalculatorCreation(_dbContext);
                            startSubstraction.Substraction();
                            break;

                        case 3:
                            Console.Clear();
                            var startMultiply = new CalculatorCreation(_dbContext);
                            startMultiply.Multiplication();
                            break;

                        case 4:
                            Console.Clear();
                            var startDivision = new CalculatorCreation(_dbContext);
                            startDivision.Division();
                            break;

                        case 5:
                            Console.Clear();
                            var startSquareRoot = new CalculatorCreation(_dbContext);
                            startSquareRoot.squareRoot();
                            break;

                        case 6:
                            Console.Clear();
                            var startModulus = new CalculatorCreation(_dbContext);
                            startModulus.Modulus();
                            break;

                        case 7:
                            Console.Clear();
                            exit = false;
                            returnToMenu.returnToMainMenu();
                            break;
                        default:
                            errorMessage.ErrorHandling();
                            continue;
                    }

                    Console.WriteLine("Would you like to start a new calculation? 1.(Yes) 2.(No)");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (answer == "2")
                    {
                        returnToMenu.returnToMainMenu();
                        break;
                    }
                    else
                    {
                        errorMessage.ErrorHandling();
                    }
                }
                catch
                {
                    errorMessage.ErrorHandling();
                   
                }

            }
        }
    }
}
