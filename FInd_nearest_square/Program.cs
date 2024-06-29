using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInd_nearest_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static int NearestSq(int number)
        {
            int minNearSquare = (int)Math.Pow((int)Math.Sqrt(number), 2);
            int maxNearSquare = (int)Math.Pow((int)Math.Sqrt(number) + 1, 2);

            int nearSquare = ((number - minNearSquare) < (maxNearSquare - number)) ? minNearSquare :  maxNearSquare;

            return nearSquare;
        }
    }
}
