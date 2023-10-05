using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(factorial(num));
            Console.ReadKey();
        }
        static int factorial(int num)
        {
            int resh = 1;
            for (int i = 1; i < num+1; i++)
            {
                resh *= i;
            }
            return resh;
        }
    }
}
