using KyhProject1.Data.Shapes;
using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Calculator
{
    public class CalculatorCrud
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ErrorMessageHandling _errorMessage;
        private readonly Calculator _calculator;
        public CalculatorCrud(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _errorMessage = new ErrorMessageHandling();
            _calculator = new Calculator();
        }

        public void CalculatorCreate()
        {
            bool start = true;
            var startCalculation = new CalculatorCreation(_dbContext);
            var answer = "";
            while (start)
            {
                bool start1 = true;
                try
                {
                    Console.Clear();
                    Console.WriteLine("Please choose an arithmetic operation");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Square Root");
                    Console.WriteLine("6. Modulus");
                    Console.WriteLine("7. Exit");
                    Console.Write("Please Enter your choice: ");
                    var userChoice = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();                    
                            startCalculation.Addition();
                            break;

                        case 2:
                            Console.Clear();
                            startCalculation.Substraction();
                            break;

                        case 3:
                            Console.Clear();
                            startCalculation.Multiplication();
                            break;

                        case 4:
                            Console.Clear();
                            startCalculation.Division();
                            break;

                        case 5:
                            Console.Clear();
                            startCalculation.squareRoot();
                            break;

                        case 6:
                            Console.Clear();
                            startCalculation.Modulus();
                            break;
                        case 7:
                            Console.Clear();
                            var returnToMainMenu = new ReturnToMainMenu();
                            returnToMainMenu.returnToMainMenu();
                            start1 = false;
                            start = false;
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
                while (start1)
                {
                    Console.WriteLine("Would you like to continue? 1. Yes, 2. No");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        start1 = false;
                        start = true;

                    }
                    else if (answer == "2")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You will now return to the Calculator Menu");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Press ANY key to continue");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        start1 = false;
                        start = false;
                    }
                    else
                    {
                        _errorMessage.ErrorHandling();
                    }
                }
            }

        }
        public void CalculatorRead()
        {
            Console.Clear();
            foreach (var calc in _dbContext.Calculators)
            {
                Console.WriteLine($"ID: {calc.Id}  | Operator: {calc.Operator}  | Num1: {calc.num1}  | Num2: {calc.num2}  | Result: {calc.Result}  | Height: {calc.Date}");
                Console.WriteLine("=================================================================================");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press any key to continue");
            Console.ResetColor();
            Console.ReadKey();

        }

        public void CalculatorUpdate()
        {
            bool start = true;
            while (start)
            {
                try
                {

                    CalculatorRead();
                    Console.WriteLine("\nChoose the ID of the calculation that you want to UPDATE");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    var calcToUpdate = _dbContext.Calculators
                        .FirstOrDefault(g => g.Id == choice);
                    Console.WriteLine("\nAcceptable operators:  +  |  -  |  *  |  /  |  %  |  sqrt");
                    Console.Write("Operator: ");
                    var operatorChar = Console.ReadLine().ToLower().Trim();

                    if (operatorChar == null || operatorChar == string.Empty)
                    {
                        _errorMessage.ErrorHandling();
                        continue;
                    }
                    Console.Write("Please enter the first number: ");
                    var num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    var num2 = Convert.ToDouble(Console.ReadLine());
                    double calculation = 0;

                    if (operatorChar == "+") calculation = _calculator.Add(num1, num2);
                    if (operatorChar == "-") calculation = _calculator.Sub(num1, num2);
                    if (operatorChar == "*") calculation = _calculator.Mult(num1, num2);
                    if (operatorChar == "/") calculation = _calculator.Div(num1, num2);
                    if (operatorChar == "sqrt") calculation = _calculator.SquareRt(num1);
                    if (operatorChar == "%") calculation = _calculator.Modu(num1, num2);

                    calcToUpdate.Operator = operatorChar;
                    calcToUpdate.num1 = num1;
                    calcToUpdate.num2 = num2;
                    calcToUpdate.Result = calculation;
                    calcToUpdate.Date = DateTime.Now;
                    _dbContext.SaveChanges();


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nUpdate of calculation succeeded\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press ANY key to continue");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    start = false;
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                }
            }
        }

        public void CalculatorDelete()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    CalculatorRead();
                    Console.WriteLine("\nChoose the ID of the shape you want to DELETE");
                    var choice = Convert.ToInt32(Console.ReadLine());

                    var calcToDelete = _dbContext.Calculators.FirstOrDefault(r => r.Id == choice);
                    if (calcToDelete != null)
                    {
                        _dbContext.Calculators.Remove(calcToDelete);
                        _dbContext.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nDeletion of shape succeded\n\n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Press any key to continue");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (calcToDelete == null)
                    {
                        _errorMessage.ErrorHandling();
                        continue;
                    }
                    break;
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                    continue;
                }
            }
        }
    }
}
