using KyhProject1.Controllers;
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

        }
    }
}
