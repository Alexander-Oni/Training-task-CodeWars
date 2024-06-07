using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Smash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] testArr = { "Hello", "world", "this", "is", "great" };

            Console.WriteLine(SentenceSmash(testArr));
        }

        static string SentenceSmash(string[] array)
        {
            string finalString = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                finalString += " " + array[i];
            }

            return finalString;
        }
    }
}
