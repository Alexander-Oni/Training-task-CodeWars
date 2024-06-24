using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportation_on_vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int RentalCarCost(int days)
        {
            int dayCost = 40;
            int totalAmount = dayCost * days;

            if (days >= 3 && days < 7)
                return totalAmount -= 20;
            
            else if (days >= 7)
                return totalAmount -= 50;
            
            else
                return totalAmount;

            // return d*40-(d>6?50:d>2?20:0); a more compact and correct option
        }
    }
}
