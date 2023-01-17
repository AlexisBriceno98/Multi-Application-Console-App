using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class ShapeCreation
    {
        private readonly ApplicationDbContext _dbContext;

        public ShapeCreation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Rectangle()
        {
            Console.WriteLine("Enter the length of the first side of the rectangle:");
            double side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side of the rectangle:");
            double side2= Convert.ToInt32(Console.ReadLine());

            double rectanglePerimeter = 2 * (side1 + side2);
            Console.WriteLine($"The perimeter of the rectangle is: {rectanglePerimeter}");
            double rectangleArea = (side1 * side2);
            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");

            _dbContext.Shapes.Add(new Shape
            {
                TypeOfShape = "Rectangle",
                Date = DateTime.Now,
                Side1 = side1,
                Side2 = side2,
                Perimeter = rectanglePerimeter,
                Area = rectangleArea
            });            
        }

        public void Parallellogram()
        {
            Console.WriteLine("Enter the length of the first side of the parallelogram:");
            double side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side of the parallelogram:");
            double side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the height side of the parallelogram:");
            double height = Convert.ToInt32(Console.ReadLine());

            double parallellogramPerimeter = 2 * (side1 + side2);
            Console.WriteLine($"The perimeter of the parallelogram is: {parallellogramPerimeter}");
            double parallellogramArea = (side1 * side2);
            Console.WriteLine($"The area of the parallelogram is: {parallellogramArea}");

            _dbContext.Shapes.Add(new Shape
            {
                TypeOfShape = "Parallellogram",
                Date = DateTime.Now,
                Side1 = side1,
                Side2 = side2,
                Perimeter = parallellogramPerimeter,
                Area = parallellogramArea
            });
        }

        public void Triangle()
        {
            Console.WriteLine("Enter the length of the first side of the triangle:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side of the triangle:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the base of the triangle:");
            double side3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the height of the triangle");
            double height = Convert.ToDouble(Console.ReadLine());
            double trianglePerimeter = (side1 + side2 + side3);
            Console.WriteLine($"The perimeter of the triangle is: {trianglePerimeter}");
            double triangleArea = (side3 * height / 2);
            Console.WriteLine($"The area of the triangle is: {triangleArea}");

            _dbContext.Shapes.Add(new Shape
            {
                TypeOfShape = "Triangle",
                Date = DateTime.Now,
                Side1 = side1,
                Side2 = side2,
                Side3 = side3,
                Height = height,
                Perimeter = trianglePerimeter,
                Area = triangleArea
            });
        }
        public void Rhombus()
        {
            Console.WriteLine("Enter the length of the first side of the rhombus:");
            double side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side of the rhombus:");
            double side2 = Convert.ToInt32(Console.ReadLine());

            double rhombusPerimeter = 2 * (side1 + side2);
            Console.WriteLine($"The perimeter of the rhombus is: {rhombusPerimeter}");
            double rhombusArea = (side1 * side2);
            Console.WriteLine($"The area of the rhombus is: {rhombusArea}");

            _dbContext.Shapes.Add(new Shape
            {
                TypeOfShape = "Rectangle",
                Date = DateTime.Now,
                Side1 = side1,
                Side2 = side2,
                Perimeter = rhombusPerimeter,
                Area = rhombusArea
            });
        }
    }
}

