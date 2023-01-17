using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Utils
{
    public class ErrorMessageHandling
    {

        public void ErrorHandling()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please use a valid choice:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press any key to retry");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
