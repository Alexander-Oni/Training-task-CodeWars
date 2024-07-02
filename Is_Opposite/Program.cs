using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Opposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "abC";
            string test1 = "ABc";

            Console.WriteLine(IsOpposite(test1,test));
        }
        static bool IsOpposite(string firstString, string secondString)
        {
            if (firstString == "" || secondString == "") return false;
            if (firstString.Length != secondString.Length) return false;

            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] == secondString[i]) return false;
                if (char.ToLower(firstString[i]) != char.ToLower(secondString[i])) return false;
            }
            return true;
        }
    }
}
