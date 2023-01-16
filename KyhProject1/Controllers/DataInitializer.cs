using KyhProject1.Data.Calculator;
using KyhProject1.Data.RPS_Game;
using KyhProject1.Data.Shapes;
using KyhProject1.Menus;
using Microsoft.EntityFrameworkCore;
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
            SeedCalculators(dbContext);
            dbContext.SaveChanges();
        }

        public void SeedShapes(ApplicationDbContext dbContext)
        {
            //if (!dbContext.RectanglePerimeterAndArea.Any(c => c.Id == 1))
            //{
            //    dbContext.RectanglePerimeters.Add(new RectanglePerimeterAndArea
            //    {
            //        Date = DateTime.Now,
            //        NameOfShape = "Rectangle"
            //    });
            //}
        }
        public void SeedCalculators(ApplicationDbContext dbContext)
        {
            if (!dbContext.Calculators.Any(c => c.Id == 1))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    Date = DateTime.Now,
                    Operator = "Addition",
                    num1 = 1,
                    num2 = 2,
                    Result = 3,
                });
            }
        }

        public void SeedRPSGames(ApplicationDbContext dbContext)
        {
            if (!dbContext.RPSGames.Any(c => c.Id == 1))
            {
                dbContext.RPSGames.Add(new RPS
                {
                    Date = DateTime.Now,
                    Wins = 0,
                    Losses = 0,
                    Rounds = 0,
                });
            }
        }

    }
}
