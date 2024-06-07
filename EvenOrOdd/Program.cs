using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++) 
                Console.WriteLine(EvenOrOdd(i));

            Console.ReadKey();
        }

        static string EvenOrOdd(int number)
        {
            return (number % 2 == 0) ? "Even" : "Odd";
        }
    }
}
