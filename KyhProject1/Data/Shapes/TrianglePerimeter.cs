using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class TrianglePerimeterAndArea
    {
        public int Id { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double CalculateTrianglePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        public void TrianglePerimeterResult()
        {
            Console.WriteLine("Enter the length of the first side of the triangle:");
            double Side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of the triangle:");
            double Side2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side of the triangle:");
            double Side3 = Convert.ToInt32(Console.ReadLine());

            TrianglePerimeterAndArea triangle = new TrianglePerimeterAndArea();
            double PerimeterResult = triangle.CalculateTrianglePerimeter(Side1, Side2, Side3);

            Console.WriteLine($"The perimeter of the triangle is {PerimeterResult}");
        }
    }
}
