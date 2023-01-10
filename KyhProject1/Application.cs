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
            ProjectBuilder.projectBuilder();

            Console.WriteLine("Welcome to AP1");
            Console.WriteLine("Please choose a program");
            Console.WriteLine("1. Shapes, 2, Calculator, 3. Rock Paper Scissors game");
            var programSelection = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (programSelection == 1)
            {
                var MenuforShapes = new ShapesMenu();
                MenuforShapes.MenuForShapes();
            }

        }
    }
}
