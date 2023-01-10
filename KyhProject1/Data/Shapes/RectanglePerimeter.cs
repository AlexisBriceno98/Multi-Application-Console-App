using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class RectanglePerimeter
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public RectanglePerimeter(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double CalculateRectanglePerimeter()
        {
            return 2 * (Side1 + Side2);
        }

        public void RectanglePerimeterResult()
        {
            Console.WriteLine("Enter the length of the first side of the rectangle:");
            double Side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of the rectangle:");
            double Side2 = Convert.ToInt32(Console.ReadLine());

            RectanglePerimeter Rectangle = new RectanglePerimeter(Side1, Side2);
            double PerimeterResult = Rectangle.CalculateRectanglePerimeter();

            Console.WriteLine($"The perimeter of the rectangle is {PerimeterResult}");
        }
    }
}
