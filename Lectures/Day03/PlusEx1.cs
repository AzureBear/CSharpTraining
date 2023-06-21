using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class PlusEx1
    {
        static void Main(string[] args)
        {
            int k = 5;
            k++;
            int p = k;

            Console.WriteLine($"k={k}, p={p}"); //6, 6

            ++k;
            p = k;
            Console.WriteLine($"k={k}, p={p}"); //7, 7

            p = ++k;
            Console.WriteLine($"k={k}, p={p}"); //8, 8

            //p = k++;
            //Console.WriteLine($"k={k}, p={p}"); //8, 7
        }
    }
}
