using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string evenNumbers = Revers(number);
            Console.WriteLine(evenNumbers);
            Console.ReadLine();
        }

        static string Revers(int number)
        {
            string result = "";

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    result += digit;
                }

                number /= 10;
            }

            return result;
        }
    }
}