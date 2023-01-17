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

        Shape shape = new Shape();
        public void Rectangle()
        {
            Console.WriteLine("Enter the length of the first side of the rectangle:");
            double width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side of the rectangle:");
            double height = Convert.ToInt32(Console.ReadLine());

            double rectanglePerimeter = 2 * (width + height);
            Console.WriteLine($"The perimeter of the rectangle is: {rectanglePerimeter}");

            double rectangleArea = (width * height);
            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");


            _dbContext.Shapes.Add(new Shape
            {
                TypeOfShape = "Rectangle",
                Date = DateTime.Now,
                Width = width,
                Height = height,
                Perimeter = rectanglePerimeter,
                Area = rectangleArea
            });
                
        }
        
    }
}

