using KyhProject1.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class RectanglePerimeterAndArea
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NameOfShape { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }


        public double CalculateRectanglePerimeter(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }

        public void RectanglePerimeterResult()
        {
            Console.WriteLine("Enter the length of the first side of the rectangle:");
            double Side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of the rectangle:");
            double Side2 = Convert.ToInt32(Console.ReadLine());

            RectanglePerimeterAndArea Rectangle = new RectanglePerimeterAndArea();
            double PerimeterResult = Rectangle.CalculateRectanglePerimeter(Side1, Side2);

            Console.WriteLine($"The perimeter of the rectangle is {PerimeterResult}");

        }
    }
}
