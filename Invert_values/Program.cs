using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invert_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] InvertValues(int[] inputArray)
        {
            int[] outputArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
               outputArray[i] = -inputArray[i];
            }

            return outputArray;
        }
    }
}
