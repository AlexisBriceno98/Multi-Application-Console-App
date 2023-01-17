using KyhProject1.Controllers;
using KyhProject1.Data.Shapes;
using KyhProject1.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
            
            Console.WriteLine("Welcome to Shapes, what do you want to calculate?");
            Console.WriteLine("1. Perimeter of a Shape, 2. Area of a Shape");
            var selection = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string answer = "";
            var stringToCheckIfValid = "0";

            while (true) 
            {
                Console.Clear();
                if (selection == 1)
                {
                  
                    Console.WriteLine("Please choose the shape you want to calculate");
                    Console.WriteLine("1. Rectangle,\n2. Parallellogram\n3. Triangle\n4. Romb");
                    var selectionOfShape = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                        switch (selectionOfShape)
                        {
                            case 1:
                            var rectangleCalculation = new ShapeCreation(_dbContext);
                                rectangleCalculation.Rectangle();
                                break;

                            case 2:
                                var ParallelogramPerimeterCalculation = new ParallelogramPerimeterAndArea();
                                ParallelogramPerimeterCalculation.ParallelogramPerimeterResult();
                                break;

                            case 3:
                                var TrianglePerimeterCalculation = new TrianglePerimeterAndArea();
                                TrianglePerimeterCalculation.TrianglePerimeterResult();
                                break;
                                
                        }
                }
                Console.WriteLine("Would you like to continue? 1. Yes, 2. No");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    continue;
                }
                else if (answer == "2")
                {
                    break;
                }
                else if (answer == "")
                {
                    var errorMessage = new ErrorMessageHandling();
                    errorMessage.IsValidInt(stringToCheckIfValid);
                    Console.WriteLine("Invalid number, please use 1. (Yes) or 2. (No)");
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
