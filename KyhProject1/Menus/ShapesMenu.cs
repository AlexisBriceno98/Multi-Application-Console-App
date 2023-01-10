using KyhProject1.Data.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Menus
{
    public class ShapesMenu
    {
        public void MenuForShapes()
        {
            Console.WriteLine("Welcome to Shapes, what do you want to calculate?");
            Console.WriteLine("1. Perimeter of a Shape, 2. Area of a Shape");
            var selection = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (selection == 1)
            {
                Console.WriteLine("Please choose the shape you want to calculate");
                Console.WriteLine("1. Rectangle,\n 2. Parallellogram\n 3. Triangle\n 4. Romb");
                var selectionOfShape = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                while (true)
                {

                    switch (selectionOfShape)
                    {
                        case 1:
                            var RectanglePerimeterCalculation = new RectanglePerimeter(1, 2);
                            RectanglePerimeterCalculation.RectanglePerimeterResult();
                            break;
                        case 2:
                            var ParallelogramPerimeterCalculation = new ParallelogramPerimeter(1, 2);
                            ParallelogramPerimeterCalculation.ParallelogramPerimeterResult();
                            break;

                        case 3:
                            var TrianglePerimeterCalculation = new TrianglePerimeter(1, 2, 3);
                            TrianglePerimeterCalculation.TrianglePerimeterResult();

                            return;
                    }
                }
            }
        }

    }
}
