using KyhProject1.Data.Calculator;
using KyhProject1.Data.RPS_Game;
using KyhProject1.Data.Shapes;
using KyhProject1.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Controllers
{
    public class DataInitializer
    {
        public void MigratedAndSeed(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedShapes(dbContext);
            dbContext.SaveChanges();
        }

        public void SeedShapes(ApplicationDbContext dbContext)
        {
            if (!dbContext.Shapes.Any(c => c.Id == 1))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Date = DateTime.Now,
                    TypeOfShape = "Rectangle",
                    Side1 = 0,
                    Side2 = 0,
                    Perimeter = 0,
                    Area = 0,                 
                });
            }

            else if (!dbContext.Shapes.Any(c => c.Id == 2))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Date = DateTime.Now,
                    TypeOfShape = "Parallellogram",
                    Side1 = 0,
                    Side2 = 0,
                    Perimeter = 0,
                    Area = 0,
                });
            }

            else if (!dbContext.Shapes.Any(c => c.Id == 3))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Date = DateTime.Now,
                    TypeOfShape = "Triangle",
                    Side1 = 0,
                    Side2 = 0,
                    Side3 = 0,
                    Height = 0,
                    Perimeter = 0,
                    Area = 0,
                });
            }
            else if (!dbContext.Shapes.Any(c => c.Id == 4))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Date = DateTime.Now,
                    TypeOfShape = "Rhombus",
                    Side1 = 0,
                    Side2 = 0,
                    Perimeter = 0,
                    Area = 0,
                });
            }
        }
    }
}

