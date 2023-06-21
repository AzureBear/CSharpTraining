using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class Test_Bravo
    {
        static void Main(string[] args)
        {

            for (int dan = 2; dan < 10; dan++)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.Write($"{dan} x {i} 는 {dan * i,2}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
