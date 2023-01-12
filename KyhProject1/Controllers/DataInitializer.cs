using KyhProject1.Data.Shapes;
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
            dbContext.SaveChanges();
        }

        public void SeedShapes(ApplicationDbContext dbContext)
        {
            if (!dbContext.RectanglePerimeters.Any(c => c.Id == 1))
            {
                dbContext.RectanglePerimeters.Add(new RectanglePerimeterAndArea
                {
                    Date = DateTime.Now,
                    NameOfShape = "Rectangle"
                });
            }
        }

    }
}
