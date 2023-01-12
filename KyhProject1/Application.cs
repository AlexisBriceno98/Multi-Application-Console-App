using KyhProject1.Controllers;
using KyhProject1.Data.Shapes;
using KyhProject1.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1
{
    public class Application
    {
        public void Run()
        {
            var ProjectBuilder = new Builder();
            var dbContext = ProjectBuilder.projectBuilder();

            while (true)
            {

                Console.WriteLine("Welcome to AP1");
                Console.WriteLine("--------------");
                Console.WriteLine("Please choose a program");
                Console.WriteLine("1. Shapes, 2. Calculator, 3. Rock Paper Scissors game, 0. Exit");
                var programSelection = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (programSelection == 0)
                {
                    break;
                }

                else if (programSelection == 1)
                {
                    var MenuforShapes = new ShapesMenu(dbContext);
                    MenuforShapes.MenuForShapes();
                }
            }
            Console.WriteLine("Thank you for using AP1, Bye!");
        }
    }
}
