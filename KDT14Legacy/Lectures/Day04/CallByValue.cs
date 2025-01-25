using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class CallByValue
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine($"x={x}, y={y}"); //5, 3
            Swap(x, y);
            Console.WriteLine($"x={x}, y={y}"); //5, 3

            Console.WriteLine($"x={x}, y={y}"); //5, 3
            Swap(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}"); //3, 5 
        }

        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
