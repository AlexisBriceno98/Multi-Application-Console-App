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
            SeedShape(dbContext);
            dbContext.SaveChanges();
        }

        public void SeedShape(ApplicationDbContext dbContext)
        {

        }

    }
}
