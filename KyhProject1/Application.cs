﻿using KyhProject1.Controllers;
using KyhProject1.Data.Shapes;
using KyhProject1.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1
{
    public class Application
    {
        public void Run()
        {
            var MainMenu = new MainMenu();
            MainMenu.StartMainMenu();
        }
    }
}
