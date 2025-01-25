using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Array2
    {
        static void Main(string[] args)
        {
            string[] arr = { "딸기", "사과", "수박", "참외" };

            if (arr.Length > 0)
            {
                Console.WriteLine(arr[0]);
            }

            if (arr.Length > 4)
            {
                Console.WriteLine(arr[4]);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i+1}. {arr[i]}");
            }

            double[] jumsus = { 78.4, 89.0, 56.9, 89.9, 90.5 };

            foreach (double num in jumsus)
            {
                Console.WriteLine(num);
            }

            for(int i=0; i<jumsus.Length; i++)
            {
                Console.WriteLine(jumsus[i]);
            }
        }
    }
}
