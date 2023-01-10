using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class ParallelogramPerimeter
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public ParallelogramPerimeter(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double CalculateParallelogramPerimeter()
        {
            return 2 * (Side1 + Side2);
        }

        public void ParallelogramPerimeterResult()
        {
            Console.WriteLine("Enter the length of the first side of the parallelogram:");
            double Side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of the parallelogram:");
            double Side2 = Convert.ToInt32(Console.ReadLine());

            ParallelogramPerimeter Parallelogram = new ParallelogramPerimeter(Side1, Side2);
            double PerimeterResult = Parallelogram.CalculateParallelogramPerimeter();

            Console.WriteLine($"The perimeter of the parallelogram is {PerimeterResult}");
        }
    }
}
