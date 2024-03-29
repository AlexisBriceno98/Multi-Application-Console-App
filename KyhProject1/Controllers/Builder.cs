﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Controllers
{
    public class Builder
    {
        public ApplicationDbContext projectBuilder()
        {
         var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
         var config = builder.Build();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);

            using (var dbContext = new ApplicationDbContext(options.Options))
            {
                var dataInitiaizer = new DataInitializer();
                dataInitiaizer.MigratedAndSeed(dbContext);
            }
            var dbContextReturned = new ApplicationDbContext(options.Options);
            return dbContextReturned;

        }
    }
}
