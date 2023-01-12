using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Utils
{
    public class ErrorMessageHandling
    {
        public int IValidInt(string stringToCheckIfValid)
        {
            int value;
            if (int.TryParse(stringToCheckIfValid, out value))
            {
                if (value >= 1 && value <= 100000) return value;
                return 0;
            }
            else return 0;
        }
    }
}
