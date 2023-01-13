using KyhProject1.Data.Calculator;
using KyhProject1.Data.Shapes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1
{
    public class ApplicationDbContext : DbContext
    {
       public DbSet<Shape> Shapes { get; set; }
       public DbSet<Calculator> Calculators { get; set; }

        public ApplicationDbContext()
        {
            
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=AlexisProject1;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

    }



}
