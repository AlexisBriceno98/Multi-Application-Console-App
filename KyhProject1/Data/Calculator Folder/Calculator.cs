using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Calculator
{
    public class Calculator
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double Add()
        {
            return num1 + num2;
        }

        public double Subtract()
        {
            return num1 - num2;
        }

        public double Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            return num1 / num2;
        }

        public double Modulus()
        {
            return num1 % num2;
        }
        public double SquareRoot()
        {
            return Math.Sqrt(num1);
        }
    }
}
