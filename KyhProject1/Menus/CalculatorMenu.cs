using KyhProject1.Controllers;
using KyhProject1.Data.Calculator;
using KyhProject1.Data.Shapes;
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
            Calculator calculator = new Calculator();
            bool exit = true;
            while (exit)
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
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the first number: ");
                        calculator.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        calculator.num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Result: " + calculator.Add());
                        calculator.Operator = "Addition";
                        calculator.Date = DateTime.Now;

                        _dbContext.Calculators.Add(new Calculator
                        {
                          Operator = calculator.Operator,
                          Date = calculator.Date,
                          num1 = calculator.num1,
                          num2 = calculator.num2,
                          Result = calculator.num1 + calculator.num2,
                          
                        });
                        _dbContext.SaveChanges();
                        break;

                    case 2:
                        Console.Write("Enter the first number: ");
                        calculator.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        calculator.num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Result: " + calculator.Subtract());

                        _dbContext.Calculators.Add(new Calculator
                        {
                            Operator = "Subtraction",
                            Date = DateTime.Now,
                            num1 = calculator.num1,
                            num2 = calculator.num2,
                            Result = calculator.num1 - calculator.num2,
                        });
                        _dbContext.SaveChanges();
                        break;

                    case 3:
                        Console.Write("Enter the first number: ");
                        calculator.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        calculator.num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Result: " + calculator.Multiply());

                        _dbContext.Calculators.Add(new Calculator
                        {
                            Operator = "Multiplication",
                            Date = DateTime.Now,
                            num1 = calculator.num1,
                            num2 = calculator.num2,
                            Result = calculator.num1 * calculator.num2,
                        });
                        _dbContext.SaveChanges();
                        break;

                    case 4:
                        Console.Write("Enter the first number: ");
                        calculator.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        calculator.num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Result: " + calculator.Divide());

                        _dbContext.Calculators.Add(new Calculator
                        {
                            Operator = "Division",
                            Date = DateTime.Now,
                            num1 = calculator.num1,
                            num2 = calculator.num2,
                            Result = calculator.num1 / calculator.num2,
                        });
                        _dbContext.SaveChanges();
                        break;

                    case 5:
                        Console.Write("Enter number: ");
                        calculator.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Result: " + calculator.SquareRoot());

                        _dbContext.Calculators.Add(new Calculator
                        {
                            Operator = "Square Root",
                            Date = DateTime.Now,
                            num1 = calculator.num1,
                            num2 = calculator.num2,
                            Result = Math.Sqrt(calculator.num1)
                        });
                        _dbContext.SaveChanges();
                        break;

                    case 6:
                        Console.WriteLine("Enter the first number: ");
                        calculator.num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        calculator.num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: "+ calculator.Modulus());

                        _dbContext.Calculators.Add(new Calculator
                        {
                            Operator = "Modulus",
                            Date = DateTime.Now,
                            num1 = calculator.num1,
                            num2 = calculator.num2,
                            Result = calculator.num1 % calculator.num2,
                        });
                        _dbContext.SaveChanges();
                        break;

                    case 7:
                        exit = false;
                        Console.WriteLine("You will now return to the Main Menu");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice, please use only the numbers that are displayed.");
                        Console.ResetColor();
                        break;
                        

                }

            }
        }
    }
}
