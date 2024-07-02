using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collinearity
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static bool IsCollinear(int x1, int y1, int x2, int y2)
        {
            if ((x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0)) return true;
            try
            {
                if ((x2 / x1 == y2 / y1) && (x1 / x2 == y1 / y2)) return true;
            }
            catch 
            {
                if(x1 == 0 && x2 == 0 || y1 == 0 && y2 == 0) return true;
                return false;
            }

            return false;
        } 
    }
}
