using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class CallByOut
    {
        static void Main(string[] args)
        {
            int max, min;
            int tot = MyCalc(new int[] { 80, 58, 78, 93 }, out max, out min);

            Console.WriteLine($"총점:{tot} 최고점:{max} 최저점:{min}");
        }

        //전달받은 수들의 합을 구하시오.
        static int MyCalc(int[] args, out int max, out int min)
        {
            if (args == null || args.Length < 1)
            {
                max = min = -1;
                return -1;
            }

            max = args[0];
            min = args[0];

            int tot = 0;

            foreach (int item in args)
            {
                tot += item;

                if (max < item) max = item;
                if (min > item) min = item;
            }
            return tot;
        }
    }
}
