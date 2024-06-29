using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abriviate_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static string AbrevName(string name)
        {
            string abriviate = name[0] + ".";
            for (int i = 1; i < name.Length; i++)
            {
                if (name[i] == ' ')
                    abriviate += name[i + 1];
            }

            return abriviate.ToUpper();
        }

    }
}
