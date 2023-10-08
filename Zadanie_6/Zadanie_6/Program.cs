using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int n = random.Next(3, 5);
            int m = random.Next(3, 5);
            int[,] mass = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = random.Next(0, 10);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int ser = m / 2;
                int minF = int.MaxValue;
                int minS = int.MaxValue;
                for (int j = 0; j < ser; j++)
                {
                    if (minF > mass[i, j])
                    {
                        minF = mass[i, j];
                    }
                }

                for (int j = ser; j < m; j++)
                {
                    if (minS > mass[i, j])
                    {
                        minS = mass[i, j];
                    }
                }
                Console.WriteLine((i+1) + " строка, первая половина: " + minF + "\n" + (i+1) + " строка, втроая половина: " + minS);
            }
            Console.ReadKey();
        }
    }
}