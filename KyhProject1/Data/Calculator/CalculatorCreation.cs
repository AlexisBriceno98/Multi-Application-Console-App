using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Calculator
{
    public class CalculatorCreation
    {
        private readonly ApplicationDbContext _dbContext;

        public CalculatorCreation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        Calculator calculator = new Calculator();
        public void Addition()
        {
            var errorMessage = new ErrorMessageHandling();
            while (true)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    calculator.num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    calculator.num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Result: " + (calculator.num1 + calculator.num2));
                    calculator.Operator = "+";
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
                }
                catch
                {
                    errorMessage.ErrorHandling();
                }
                continue;
            }
        }

        public void Substraction()
        {
            Console.Write("Enter the first number: ");
            calculator.num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            calculator.num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (calculator.num1 - calculator.num2));

            _dbContext.Calculators.Add(new Calculator
            {
                Operator = "-",
                Date = DateTime.Now,
                num1 = calculator.num1,
                num2 = calculator.num2,
                Result = calculator.num1 - calculator.num2,
            });
            _dbContext.SaveChanges();
        }

        public void Multiplication()
        {
            Console.Write("Enter the first number: ");
            calculator.num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            calculator.num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (calculator.num1 * calculator.num2));

            _dbContext.Calculators.Add(new Calculator
            {
                Operator = "*",
                Date = DateTime.Now,
                num1 = calculator.num1,
                num2 = calculator.num2,
                Result = calculator.num1 * calculator.num2,
            });
            _dbContext.SaveChanges();
        }

        public void Division()
        {
            Console.Write("Enter the first number: ");
            calculator.num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            calculator.num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (calculator.num1 / calculator.num2));

            _dbContext.Calculators.Add(new Calculator
            {
                Operator = "/",
                Date = DateTime.Now,
                num1 = calculator.num1,
                num2 = calculator.num2,
                Result = calculator.num1 / calculator.num2,
            });
            _dbContext.SaveChanges();
        }

        public void squareRoot()
        {
            Console.Write("Enter number: ");
            calculator.num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + Math.Sqrt(calculator.num1));

            _dbContext.Calculators.Add(new Calculator
            {
                Operator = "sqrt",
                Date = DateTime.Now,
                num1 = calculator.num1,
                num2 = calculator.num2,
                Result = Math.Sqrt(calculator.num1)
            });
            _dbContext.SaveChanges();
        }

        public void Modulus()
        {
            Console.WriteLine("Enter the first number: ");
            calculator.num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            calculator.num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + (calculator.num1 % calculator.num2));

            _dbContext.Calculators.Add(new Calculator
            {
                Operator = "%",
                Date = DateTime.Now,
                num1 = calculator.num1,
                num2 = calculator.num2,
                Result = calculator.num1 % calculator.num2,
            });
            _dbContext.SaveChanges();
        }
    }
}
