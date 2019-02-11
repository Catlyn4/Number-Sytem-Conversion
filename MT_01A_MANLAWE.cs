using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_01A_MANLAWE
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
            Console.ReadLine();

        }
    }

}
   
