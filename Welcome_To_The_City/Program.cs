using System;


namespace Welcome_To_The_City
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name1 = { "John", "Smith" };
            string nameOfCity1 = "Phoenix";
            string nameOfState1 = "Arizona";

            string hello = Greeting.SayHello(name1, nameOfCity1, nameOfState1);
            Console.WriteLine(hello);
        }
    }
}
