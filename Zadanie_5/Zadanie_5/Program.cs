using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp,next;
            Random rnd = new Random();
            int[] mass = new int[rnd.Next(5,10)];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] =i;
                Console.Write(mass[i] + " ");
            }
            Console.Write("\n\n");
            for (int i = 0; i < mass.Length-1; i++)
            {
                next = i + 1;
                temp = i;
                i = next;
                next = temp;
                Console.Write(mass[i]+" " + mass[temp] + " ");
                
            }
            if(mass.Length%2!=0)
            {
                Console.Write(mass[mass.Length-1]);
            }
            Console.ReadKey();
        }
    }
}
