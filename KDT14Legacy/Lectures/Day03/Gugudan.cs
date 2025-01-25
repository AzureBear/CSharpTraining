using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Gugudan
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int dan = 2; dan < 10; dan++)
                {
                    Console.Write($"{dan} * {i} = {dan * i,2}\t");
                }
                Console.WriteLine();
            }


            /*
            for (int dan = 2; dan < 10; dan++)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"{dan} * {i} = {dan * i}");
                }
                Console.WriteLine();
            }*/
        }
    }
}
