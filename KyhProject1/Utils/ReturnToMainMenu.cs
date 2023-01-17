using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Utils
{
    public class ReturnToMainMenu
    {
        public void returnToMainMenu()
        {
            Console.WriteLine("You will now return to the Main Menu");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }
    }
}
