using KyhProject1.Controllers;
using KyhProject1.Data.Shapes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Menus
{
    public class ShapesMenu
    {
        public ShapesMenu(ApplicationDbContext dbContext)
        {

        }
        public void MenuForShapes()
        {
            
            Console.WriteLine("Welcome to Shapes, what do you want to calculate?");
            Console.WriteLine("1. Perimeter of a Shape, 2. Area of a Shape");
            var selection = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string answer = "";

            while(true) 
            {

                if (selection == 1)
                {
                  
                    Console.WriteLine("Please choose the shape you want to calculate");
                    Console.WriteLine("1. Rectangle,\n2. Parallellogram\n3. Triangle\n4. Romb");
                    var selectionOfShape = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                        switch (selectionOfShape)
                        {
                            case 1:
                            var RectanglePerimeterCalculation = new RectanglePerimeterAndArea();
                                RectanglePerimeterCalculation.RectanglePerimeterResult();
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
                
            }
 
            Console.WriteLine("Thank you for using our program, Bye!");
            
        }
    }
}
