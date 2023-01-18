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
            while (start)
            {
                try
                {
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
                            var startAddition = new CalculatorCreation(_dbContext);
                            startAddition.Addition();
                            break;

                        case 2:
                            var startSubstraction = new CalculatorCreation(_dbContext);
                            startSubstraction.Substraction();
                            break;

                        case 3:
                            var startMultiply = new CalculatorCreation(_dbContext);
                            startMultiply.Multiplication();
                            break;

                        case 4:
                            var startDivision = new CalculatorCreation(_dbContext);
                            startDivision.Division();
                            break;

                        case 5:
                            var startSquareRoot = new CalculatorCreation(_dbContext);
                            startSquareRoot.squareRoot();
                            break;

                        case 6:
                            var startModulus = new CalculatorCreation(_dbContext);
                            startModulus.Modulus();
                            break;
                        case 7:
                            var returnToMainMenu = new ReturnToMainMenu();
                            returnToMainMenu.returnToMainMenu();
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
            }

        }
        public void CalculatorRead()
        {
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
            while (true)
            {
                try
                {
                    Console.Clear();
                    CalculatorRead();
                    Console.WriteLine("\nChoose the ID of the calculation that you want to UPDATE");
                    var choice = Convert.ToInt32(Console.ReadLine());
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
