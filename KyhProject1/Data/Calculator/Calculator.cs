using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Calculator
{
    public class Calculator
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Operator { get; set; }
        [Required]
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double Result { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Mult(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }

        public double SquareRt(double num1)
        {
            return Math.Sqrt(num1);
        }

        public double Modu(double num1, double num2)
        {
            return num1 % num2;
        }

    }
}
