using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_To_The_City
{
    internal class Greeting
    { 
        public static string SayHello(string[] name, string city, string state)
        {
            string nameOfPerson = name[0];           // Getting a name 

            for (int i = 1; i < name.Length; i++)
            {
                nameOfPerson += " " + name[i];
            }
            

            string nameOfCity = city;       // Gettting a name of city
            string nameOfState = state;     // Getting a name of state

            string sayHello = "Hello, " + nameOfPerson +
                              "! Welcome to " + nameOfCity +
                              ", " + nameOfState + "!";

            return sayHello;
        }
    }
}
