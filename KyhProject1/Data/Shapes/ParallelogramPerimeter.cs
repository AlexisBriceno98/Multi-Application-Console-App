using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class ParallelogramPerimeterAndArea
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double CalculateParallelogramPerimeter(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }

        public void ParallelogramPerimeterResult()
        {
            Console.WriteLine("Enter the length of the first side of the parallelogram:");
            double Side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of the parallelogram:");
            double Side2 = Convert.ToInt32(Console.ReadLine());

            ParallelogramPerimeterAndArea Parallelogram = new ParallelogramPerimeterAndArea();
            double PerimeterResult = Parallelogram.CalculateParallelogramPerimeter(Side1, Side2);

            Console.WriteLine($"The perimeter of the parallelogram is {PerimeterResult}");
        }
    }
}
