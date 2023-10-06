using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            XN(X, N);
            Console.ReadKey();
        }
        static void XN(int X, int N)
        {
            for (int i = 1; i < X+1; i++)
            {
                if (i % N == 0)
                {
                    Console.Write(i + " ");
                }
                
            }
        }
    }
}
