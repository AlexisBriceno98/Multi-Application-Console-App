using KyhProject1.Controllers;
using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.Shapes
{
    public class ShapeCrud
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ErrorMessageHandling _errorMessage;
        public ShapeCrud(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _errorMessage = new ErrorMessageHandling();
        }

        public void ShapeCreate()
        {
            string answer = "";
            bool start = true;

            while (start)
            {
                bool start1 = true;
                try
                {
                    Console.Clear();
                    Console.WriteLine("Please choose the shape you want to calculate");
                    Console.WriteLine("1. Rectangle\n2. Parallellogram\n3. Triangle\n4. Romb");

                    var selectionOfShape = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (selectionOfShape)
                    {
                        case 1:
                            var rectangleCalculation = new ShapeCreation(_dbContext);
                            rectangleCalculation.Rectangle();
                            break;

                        case 2:
                            var parallellogramCalculation = new ShapeCreation(_dbContext);
                            parallellogramCalculation.Parallellogram();
                            break;

                        case 3:
                            var triangleCalculation = new ShapeCreation(_dbContext);
                            triangleCalculation.Triangle();
                            break;

                        case 4:
                            var rhombusCalculation = new ShapeCreation(_dbContext);
                            rhombusCalculation.Rhombus();
                            break;
                        default:
                            {
                                _errorMessage.ErrorHandling();
                                continue;
                            }
                    }
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                }
                while (start1)
                {
                    Console.WriteLine("Would you like to continue? 1. Yes, 2. No");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        start1 = false;
                        start = true;

                    }
                    else if (answer == "2")
                    {
                        Console.Clear();
                        start1 = false;
                        start = false;
                    }
                    else
                    {
                        _errorMessage.ErrorHandling();
                    }
                }
            }
        }
        public void ShapeRead()
        {

            foreach (var shape in _dbContext.Shapes)
            {
                Console.WriteLine($"ID: {shape.Id}  | TypeOfShape: {shape.TypeOfShape}  | Side1: {shape.Side1}  | Side2: {shape.Side2}  | Side3: {shape.Side3}  | Height: {shape.Height}    " +
                    $"| Area: {shape.Area}  | Perimeter: {shape.Perimeter}  | Date: {shape.Date}");
                Console.WriteLine("==================================================================================================================================================");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press any key to continue");
            Console.ResetColor();
            Console.ReadKey();
        }
        public void ShapeUpdate()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("UPDATE");
                    Console.WriteLine("--------\n");
                    Console.WriteLine(".1 - Rectangle\n.2 - Parallellogram\n.3 - Rhombus\n.4 - Triangle");
                    var userChoice = Convert.ToDouble(Console.ReadLine());
                    var shape = "";

                    if (userChoice >= 1 && userChoice <= 3)
                    {
                        if (userChoice == 1) shape = "Rectangle";
                        if (userChoice == 2) shape = "Parallellogram";
                        if (userChoice == 3) shape = "Rhombus";
                        Update4sidedShape(shape);
                    }
                    else if (userChoice == 4)
                    {
                        shape = "Triangel";
                        UpdateTriangleShape(shape);
                    }
                    break;
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                }

            }
        }

        public void Update4sidedShape(string shape)
        {
            var shapeToUpdate = new Shape();
            while (true)
            {
                try
                {
                    ShapeRead();
                    Console.WriteLine("\nChoose the ID of the shape you want to UPDATE");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    shapeToUpdate = _dbContext.Shapes
                        .Where(sR => sR.TypeOfShape == "Rectangle" || sR.TypeOfShape == "Parallellogram" || sR.TypeOfShape == "Rhombus")
                        .FirstOrDefault(g => g.Id == choice);
                    if (shapeToUpdate == null)
                    {
                        _errorMessage.ErrorHandling();
                        continue;
                    }
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                    continue;
                }
                break;
            }
            while (true)
            {
                try
                {
                    if (shapeToUpdate != null)
                    {
                        Console.Write("Side 1: ");
                        var side1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Side 2: ");
                        var side2 = Convert.ToDouble(Console.ReadLine());

                        var area = side1 * side2;
                        var perimiter = 2 * (side1 + side2);

                        Console.WriteLine($"\nArea: {area}\nPerimeter: {perimiter}\n\nDate: {DateTime.Now}\n");

                        shapeToUpdate.TypeOfShape = shape;
                        shapeToUpdate.Side1 = side1;
                        shapeToUpdate.Side2 = side2;
                        shapeToUpdate.Area = area;
                        shapeToUpdate.Perimeter = perimiter;
                        shapeToUpdate.Date = DateTime.Now;
                    }     
                    _dbContext.SaveChanges();
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                    continue;
                }
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to continue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

        }

        public void UpdateTriangleShape(string shape)
        {
            var shapeToUpdate = new Shape();
            while (true)
            {
                try
                {
                    ShapeRead();
                    Console.WriteLine("\nChoose the ID of the shape you want to UPDATE");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    shapeToUpdate = _dbContext.Shapes
                        .Where(sR => sR.TypeOfShape == "Triangle")
                        .FirstOrDefault(g => g.Id == choice);
                    if (shapeToUpdate == null)
                    {
                        _errorMessage.ErrorHandling();
                        continue;
                    }
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                    continue;
                }
                break;
            }
            while (true)
            {
                try
                {
                    if (shapeToUpdate != null)
                    {
                        Console.Write("Side 1: ");
                        var side1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Side 2: ");
                        var side2 = Convert.ToDouble(Console.ReadLine());

                        var area = side1 * side2;
                        var perimiter = 2 * (side1 + side2);

                        Console.WriteLine($"\nArea: {area}\nPerimeter: {perimiter}\n\nDate: {DateTime.Now}\n");

                        shapeToUpdate.TypeOfShape = shape;
                        shapeToUpdate.Side1 = side1;
                        shapeToUpdate.Side2 = side2;
                        shapeToUpdate.Area = area;
                        shapeToUpdate.Perimeter = perimiter;
                        shapeToUpdate.Date = DateTime.Now;
                    }
                    _dbContext.SaveChanges();
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                    continue;
                }
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to continue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public void ShapeDelete()
        {
            while (true)
            {
                try
                {
                    ShapeRead();
                    Console.WriteLine("\nChoose the ID of the shape you want to DELETE");
                    var choice = Convert.ToInt32(Console.ReadLine());

                    var shapeToDelete = _dbContext.Shapes.FirstOrDefault(r => r.Id == choice);
                    if (shapeToDelete != null)
                    {
                        _dbContext.Shapes.Remove(shapeToDelete);
                        _dbContext.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nDeletion of shape succeded\n\n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Press any key to continue");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    else if (shapeToDelete == null)
                    {
                        _errorMessage.ErrorHandling();
                        continue;
                    }
                    break;
                }
                catch
                {
                    _errorMessage.ErrorHandling();
                    continue;
                }
            }
        }
    }



}
