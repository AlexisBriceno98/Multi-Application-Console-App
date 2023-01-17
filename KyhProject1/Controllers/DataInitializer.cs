﻿using KyhProject1.Data.Calculator;
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
            SeedCalculators(dbContext);
            SeedRPSGames(dbContext);
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
                    Width = 0,
                    Height = 0,
                    Perimeter = 0,
                    Area = 0,
                    
                });
            }
        }
        public void SeedCalculators(ApplicationDbContext dbContext)
        {
            if (!dbContext.Calculators.Any(c => c.Id == 1))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    Date = DateTime.Now,
                    Operator = "Addition",
                    num1 = 0,
                    num2 = 0,
                    Result = 0,
                });
            }

            if (!dbContext.Calculators.Any(c => c.Id == 2))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    Date = DateTime.Now,
                    Operator = "Substraction",
                    num1 = 0,
                    num2 = 0,
                    Result = 0,
                });
            }

            if (!dbContext.Calculators.Any(c => c.Id == 3))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    Date = DateTime.Now,
                    Operator = "Multiplication",
                    num1 = 0,
                    num2 = 0,
                    Result = 0,
                });
            }

            if (!dbContext.Calculators.Any(c => c.Id == 4))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    Date = DateTime.Now,
                    Operator = "Division",
                    num1 = 0,
                    num2 = 0,
                    Result = 0,
                });
            }

            if (!dbContext.Calculators.Any(c => c.Id == 5))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    Date = DateTime.Now,
                    Operator = "Square Root",
                    num1 = 0,
                    num2 = 0,
                    Result = 0,
                });
            }

            if (!dbContext.Calculators.Any(c => c.Id == 6))
            {
                dbContext.Calculators.Add(new Calculator
                {
                    Date = DateTime.Now,
                    Operator = "Modulus",
                    num1 = 0,
                    num2 = 0,
                    Result = 0,
                });
            }
        }

        public void SeedRPSGames(ApplicationDbContext dbContext)
        {
            if (!dbContext.RPSGames.Any(c => c.Id == 1))
            {
                dbContext.RPSGames.Add(new RPS
                {
                    PlayerChoice = "Rock",
                    Date = DateTime.Now,
                    Wins = 0,
                    Losses = 0,
                    Rounds = 0,
                });
            }

            else if (!dbContext.RPSGames.Any(c => c.Id == 2))
            {
                dbContext.RPSGames.Add(new RPS
                {
                    PlayerChoice = "Paper",
                    Date = DateTime.Now,
                    Wins = 0,
                    Losses = 0,
                    Rounds = 0,
                });
            }

            else if (!dbContext.RPSGames.Any(c => c.Id == 3))
            {
                dbContext.RPSGames.Add(new RPS
                {
                    PlayerChoice = "Scissors",
                    Date = DateTime.Now,
                    Wins = 0,
                    Losses = 0,
                    Rounds = 0,
                });
            }
        }
    }
}
