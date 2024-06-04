using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();
        }
    }
    public class Kata
    {
        public string Rps(string p1, string p2)
        {
            if (p1 == p2)
                return "Draw!";

            if (((p1 == "rock") && (p2 == "scissors")) ||
                ((p1 == "scissors") && (p2 == "paper")) ||
                ((p1 == "paper") && (p2 == "rock")))
            {
                return "Player 1 won!";
            }
            else
            {
                return "Player 2 won!";
            }
        }
    }
}
