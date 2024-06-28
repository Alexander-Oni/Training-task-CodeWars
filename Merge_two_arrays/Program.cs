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
            int[] test = { 4, 3, 2 };
            int[] anotherTest = { 5, 4, 6, 9 };
            int[] expected = MergeArrays(test, anotherTest);
        }
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            for (; i < arr1.Length; i++)
                result[i] = arr1[i];
            for (; j < arr2.Length; j++)
            {
                result[i] = arr2[j];
                i++;
            }

            Array.Sort(result);

            return result.Distinct().ToArray();
        }
    }

    // 1. функция проверки длин массивов
    // 2. функция сверки и удаления дубликатов из массива
    // 3. функция создания нового массива длиной из двух без дупликатов
    // 4. функция соединия двух массивов


}
