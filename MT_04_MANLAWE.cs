using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_O4_Manlawe
{
    class Program
    {
        static void conversion(string value)
        {
            Console.WriteLine("{0} to decimal is {1}.",
                value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} to decimal is {1}.\n", value,
                Convert.ToString(Convert.ToInt32(value, 16), 2));
        }
        static void Main(string[] args)
        {
            conversion("FA");
            conversion("2A3E");
            conversion("FFFF");
            conversion("5A0E9");
            Console.ReadLine();
        }
    }
}
