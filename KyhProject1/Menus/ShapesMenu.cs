using KyhProject1.Controllers;
using KyhProject1.Data.Shapes;
using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Menus
{
    public class ShapesMenu
    {
        private readonly ApplicationDbContext _dbContext;

        public ShapesMenu(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void MenuForShapes()
        {
            var errorMessage = new ErrorMessageHandling();

            while (true) 
            {
                try
                {
                    Console.WriteLine("Welcome to Shapes");
                    Console.WriteLine("Please choose the shape you want to calculate");
                    Console.WriteLine("1. Rectangle\n2. Parallellogram\n3. Triangle\n4. Romb");
                    string answer = "";

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
                            errorMessage.ErrorHandling();
                            continue;
                    }


                    Console.WriteLine("Would you like to continue? 1. Yes, 2. No");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (answer == "2")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        errorMessage.ErrorHandling();
                    }
                }
                catch
                {
                    errorMessage.ErrorHandling();
                }

            }
 
            Console.WriteLine("Thank you for using our program, You will now return to Main Menu!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press any key to continue");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
