using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class TrianglePerimeter
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public TrianglePerimeter(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateTrianglePerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public void TrianglePerimeterResult()
        {
            Console.WriteLine("Enter the length of the first side of the triangle:");
            double Side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of the triangle:");
            double Side2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side of the triangle:");
            double Side3 = Convert.ToInt32(Console.ReadLine());

            TrianglePerimeter triangle = new TrianglePerimeter(Side1, Side2, Side3);
            double PerimeterResult = triangle.CalculateTrianglePerimeter();

            Console.WriteLine($"The perimeter of the triangle is {PerimeterResult}");
        }
    }
}
