using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0;
            for (; i < arr1.Length; i++)
                result[i] = arr1[i];
            for (int j = 0; j < arr2.Length; j++)
            {
                result[i] = arr2[j];
                i++;
            }

            Array.Sort(result);

            return result.Distinct().ToArray();
        }
    }
}
