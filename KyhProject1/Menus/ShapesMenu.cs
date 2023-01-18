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
            var shapeCrud = new ShapeCrud(_dbContext);
            bool startShapeLoop = true;

            while (startShapeLoop)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to Shapes");
                    Console.WriteLine("Please choose a function");
                    Console.WriteLine("1. Start a shape calculation || 2. Read shapes || 3. Update a shape || 4. Delete a shape || 5. Exit to main menu ");
                    var functionChoice = Convert.ToInt32(Console.ReadLine());
                    switch (functionChoice)
                    {
                        case 1:
                            shapeCrud.ShapeCreate();
                            break;
                        case 2:
                            shapeCrud.ShapeRead();
                            break;
                        case 3:
                            shapeCrud.ShapeUpdate();
                            break;
                        case 4:
                            shapeCrud.ShapeDelete();
                            break;
                        case 5:
                            startShapeLoop = false;
                            break;
                        default:
                            {
                                errorMessage.ErrorHandling();
                                continue;
                            }
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
