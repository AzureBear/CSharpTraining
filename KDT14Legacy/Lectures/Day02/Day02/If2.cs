using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class If2
    {
        static void Main(string[] args)
        {
            //난수 => 무작위 수
            Random rnd = new Random();
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(rnd.Next(1, 46) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
